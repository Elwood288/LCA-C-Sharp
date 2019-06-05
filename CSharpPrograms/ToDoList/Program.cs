using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static string addMore = " ";
        static List<ToDoItem> toDoList = new List<ToDoItem>();

        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to add a new item? Y/N");
            addMore = Console.ReadLine().ToUpper();
            while (addMore != "n"){
                Console.Clear();
                // Ask user for information
                Console.WriteLine("Enter a description for your item.");
               string description = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the due date for your item.");
                string dueDate = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the item's priority. Low, Medium or High.");
                string priority = Console.ReadLine();
                Console.Clear();
                // Add information to class
                ToDoItem item = new ToDoItem(description, dueDate, priority);
                // Add new object to list
                
                toDoList.Add(item);
                // Ask if user wants to quit
                Console.WriteLine("Do you want to add a new item? Y/N");
                addMore = Console.ReadLine().ToLower();
                Console.Clear();
            }

            Console.WriteLine(" To Do List ");
            Console.WriteLine("____________");
            foreach (var item in toDoList)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Task: " + item.Description);
                Console.WriteLine("Due Date: " + item.DueDate);
                Console.WriteLine("Priority: " + item.Priority);
                Console.WriteLine(" ");
                Console.WriteLine("________________________________");
            }
            Console.Read();
        }

        class ToDoItem{

            public string Description { get; set; }
            public string DueDate { get; set; }
            public string Priority { get; set; }

            public ToDoItem(string description, string dueDate, string priority)
            {
                Description = description;
                DueDate = dueDate;
                Priority = priority;
            }
        }

    }
}
