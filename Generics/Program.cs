using System.Security.Principal;

namespace Generics
{
    public delegate int Comparison<T>(T x, T y);
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, Comparison<Person> comparison)
        {
            for (int i = 0; i < people.Length-1; i++)
            {
                for(int j = i+1; j < people.Length; j++)
                {
                    if (comparison(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //string[] array = { "One", "Two", "Three" };
            //PrintArray(numbers);
            //PrintArray(array);

            Person[] people = {
                new Person{Name = "Alice", Age = 30},
                new Person{Name = "Bob", Age = 24},
                new Person{Name = "Cassyy", Age = 20},

            };

            PersonSorter sorter = new PersonSorter();
            sorter.Sort(people, CompareByAge);

            foreach(Person person in people)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

        }

        static int CompareByAge(Person x , Person y)
        {
            return x.Age.CompareTo(y.Age);
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

        }

        public static void PrintStringArray(string[] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintArray<T>(T[] array){
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

    }


}
