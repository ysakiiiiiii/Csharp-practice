using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class TaskManager
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            void main()
            {
                Console.Clear();

                Console.WriteLine("TASK MANAGER:");

                Console.WriteLine("===========================");
                Console.WriteLine("[1] View Tasks");
                Console.WriteLine("[2] Add Task");
                Console.WriteLine("[3] Remove a Task");
                Console.WriteLine("[4] Exit the Program");
                Console.WriteLine("===========================");
                Console.Write("Choose : ");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        viewTask();
                        Console.Write("Press any key to go back! ");
                        Console.ReadKey();
                        break;
                    case 2:
                        addTask();
                        break;
                    case 3:
                        viewTask();
                        Console.Write("Enter task ID to remove : ");
                        int.TryParse(Console.ReadLine(), out int taskID);
                        removeTask(taskID);
                        break;
                    case 4:
                        Console.WriteLine("Exiting the Program");
                        return;
                    default:
                        Console.Write("Wrong input. Please enter a valid input! ");
                        Console.ReadKey();
                        break;
                }


                main();
            }


            void viewTask()
            {
                Console.Clear();
                Console.WriteLine("CURRENT TASKS");
                Console.WriteLine("=======================");
                if (tasks == null || tasks.Count == 0)
                {
                    Console.WriteLine("No task at the moment");
                }
                else
                {
                    int count = 1;
                    foreach (string task in tasks)
                    {
                        
                        Console.WriteLine($"[ {count++} ] {task}");
                    }

                    Console.WriteLine("=======================");

                }

            }
            

            void addTask()
            {
                Console.Write("Task to Add : ");
                string task = Console.ReadLine();
                tasks.Add(task);
                Console.Write("Success Add the Task!");
                Console.ReadKey();
            }

            void removeTask(int taskID)
            {
                int index = taskID - 1;

                if (index >= 0 && index < tasks.Count)
                {
                    string removedTask = tasks[index];
                    tasks.RemoveAt(index);
                    Console.Write($"Successfully Removed: {removedTask}");
                }
                else
                {
                    Console.Write("Invalid Task ID!");
                }



                Console.ReadKey();
            }

            main();
        }



    }
}
