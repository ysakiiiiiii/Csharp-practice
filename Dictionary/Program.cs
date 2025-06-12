using System;
using System.ComponentModel.Design;

class Book
{
    public string name { get; set; }
    public string author { get; set; }
    public int publishedDate { get; set; }
}

class Library
{
    private Dictionary<string, Book> books = new Dictionary<string, Book>();
    
    public void searchBooks()
    {   

        if (books.Count == 0)
        {
            Console.WriteLine("No books yet");
            return;
        }
        Console.Write("Name of the Book : ");
        string name = Console.ReadLine();

        if (books.ContainsKey(name))
        {
            var book = books[name];
            Console.WriteLine($"Author of the Book : {book.author}");
            Console.WriteLine($"Publised Data : {book.publishedDate}");
        }
        else
        {
            Console.WriteLine($"{name} does not exist");
        }

    }

    public void addBook()
    {
        Console.Write("Name of the Book : ");
        string name = Console.ReadLine();

        Console.Write("Name of the Author : ");
        string author = Console.ReadLine();

        Console.Write("Published Data : ");
        int publishedDate = int.Parse(Console.ReadLine());

        books[name] = new Book
        {
            name = name,
            author = author,
            publishedDate = publishedDate
        };

        Console.WriteLine($"Success added the book \"{name}\"");
    }

    public void removeBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books yet");
            return;
        }

        string name;
        while (true)
        {
            Console.Write("Name of the Book : ");
            name = Console.ReadLine();

            if (books.ContainsKey(name))
            {
                books.Remove(name);
                Console.WriteLine($"Successfully remove the book \"{name}\"");
                break;
            }
            else
            {
                Console.WriteLine($"\"{name}\" does not exist. Please input a valid book");
            }
        }

    }

    public void updateBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books yet");
            return;
        }

        Console.WriteLine("Name of the Book: ");
        string name = Console.ReadLine();

        if (books.ContainsKey(name)) {
            Console.Write("New Book Name :");
            string newName = Console.ReadLine();

            Console.Write("New Author : ");
            string newAuthor = Console.ReadLine();

            Console.WriteLine("New Date : ");
            int newDate = int.Parse(Console.ReadLine());

            books[name].author = newAuthor;
            books[name].publishedDate = newDate;
            books[name].name = newName;


            var bookDetails = books[name];
            books.Remove(name);

            books[newName] = bookDetails;

            Console.WriteLine($"Successully Update the book \"{name}\"");

        }
        else
        {
            Console.WriteLine($"{name} does not exist...");
        }

    }
}



class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        int choice;
        do
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO OUR LIBRARY: ");
            Console.WriteLine("[1] Search a Book");
            Console.WriteLine("[2] Add Book");
            Console.WriteLine("[3] Remove a Book");
            Console.WriteLine("[4] Update a Book");
            Console.WriteLine("[0] Exit Library");
            Console.WriteLine("================");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    library.searchBooks();
                    break;

                case 2:
                    library.addBook();
                    break;

                case 3:
                    library.removeBook();
                    break;

                case 4:
                    library.updateBook();
                    break;

                case 0:
                    Console.WriteLine("GoodBye!");
                    break;
                default:
                    Console.WriteLine("Invalid input Try Again");
                    break;

            }

            if (choice != 0)
            {
                Console.Write("Press Any Key to Continue...");
                Console.ReadKey();
            }

        } while (choice != 0);
    }
}