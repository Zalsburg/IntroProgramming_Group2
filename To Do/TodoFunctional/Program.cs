using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoFunctional
{
    class Program
    {

        static List<string> TodoTitles = new List<string>();
        static List<bool> TodoCompleted = new List<bool>();


        static int AddTodo(string title, bool completed)
        {
            var index = TodoTitles.Count;
            TodoTitles.Add(title);
            TodoCompleted.Add(completed);

            return index;
        }
        static void RemoveTodo(int index)
        {
            TodoTitles.RemoveAt(index);
            TodoCompleted.RemoveAt(index);
        }

        static void DisplayTodo(int index)
        {
            var title = TodoTitles[index];
            var completed = TodoCompleted[index];

            if (completed)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(" - " + title);
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void DrawSepearator()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", Console.BufferWidth)));
        }
        static void DisplayAllTodos()
        {
            DrawSepearator();
            for (int i = 0; i < TodoTitles.Count; i++)
            {
                DisplayTodo(i);
            }

            DrawSepearator();
        }

        static void ReadNewTodo()
        {
            Console.WriteLine("Add Todo: ");
            // Do stuff in here to create a new Todo.
            Console.Write("Enter title for new ToDo item: ");
            string newTitle = Console.ReadLine();

            //why ask this if we're not going to make it green if it's true? therefore it's getting commented out:
            //Console.Write("Is ToDo complete? (T/F) ");
            //string newCompleteInput = Console.ReadLine().ToUpper();
            bool newComplete = false;

            //while (newCompleteInput != "T" && newCompleteInput != "F") {
            //    Console.WriteLine("Please enter T or F");
            //    newCompleteInput = Console.ReadLine();
            //}

            AddTodo(newTitle, newComplete);
        }

        static void ReadToggleExistingTodo()
        {
            Console.WriteLine("Toggle Todo: ");
            // Do something to toggle the todo item thingy-ma-bob thing
            Console.Write($"What number item would you like to select? (1 - {TodoTitles.Count}) ");
            int listNo = int.Parse(Console.ReadLine());

            if (TodoCompleted[listNo - 1] == true) {
                TodoCompleted[listNo - 1] = false;
            }
            else if (TodoCompleted[listNo - 1] == false) {
                TodoCompleted[listNo - 1] = true;
            }
            
        }

        static void ReadRemoveTodo()
        {
            Console.WriteLine("Remove Todo: ");
            //This thing gave me so much grief, why is it here :(
                //RemoveTodo(1);
            // Remove craptasic todos here
            Console.Write($"Which Todo would you like to remove? (1 - {TodoTitles.Count}) ");
            int listNo = int.Parse(Console.ReadLine());
            Console.WriteLine($"You are about to delete '{TodoTitles[listNo - 1]}'. Continue? (Y/N) ");
            string yesNo = Console.ReadLine().ToUpper();
            if (yesNo == "Y") {
                RemoveTodo(listNo - 1);
                Console.WriteLine("The item will be removed");
                Console.ReadKey();
            }
            else if (yesNo == "N") {
                Console.WriteLine("The item won't be removed");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Todo Application");

            // Add a few example Todos
            AddTodo("Get the shopping from the store because you a lazy dude and had to pre order it", false);
            AddTodo("Kiss a tree because climate", false);
            AddTodo("Finish this task because you are a model student", false);
            AddTodo("Go to Intro Class this arvo", true);
            AddTodo("Attended Hormone treatment", false);


            while (true)
            {
                Console.Clear();
                DisplayAllTodos();
                Console.WriteLine("Pick an option:");
                Console.WriteLine(" (1) -> Create Todo");
                Console.WriteLine(" (2) -> Toggle Completed");
                Console.WriteLine(" (3) -> Remove Todo");
                Console.WriteLine(" (4) -> Exit");


                var key = Console.ReadKey(true);

                if(key.Key == ConsoleKey.D1)
                {
                    ReadNewTodo();
                }
                else if(key.Key == ConsoleKey.D2)
                {
                    ReadToggleExistingTodo();
                }
                else if(key.Key == ConsoleKey.D3)
                {
                    ReadRemoveTodo();
                }
                else if(key.Key == ConsoleKey.D4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nah you dumb, give me a valid answer please. Press any key to stop me raging at you....");
                    Console.ReadKey(true);
                }                

            }

        }
        //Creating a class which represents one item in the list
        public class Todo {
            public string itemName;
            public bool complete;

            public Todo(string name, bool comp) {
                itemName = name;
                complete = comp;
            }

            public void NewJob(string job) {
                itemName = Console.ReadLine();
            }
        }

    }
}
