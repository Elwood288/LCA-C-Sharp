using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace To_Do_List
{
    class Program
    {
        ToDoContext context = new ToDoContext();
        static void Main(string[] args)
        {



            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. View To Do List");
            Console.WriteLine("2. Add an item");
            Console.WriteLine("3. Edit an item");
            Console.WriteLine("4. Delete an item");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("To Do List: ");

                ItemRepository list = new ItemRepository();
                list.GetToDoItems();
                foreach (ToDoItem s in list.GetToDoItems())
                {
                    Console.WriteLine("{0} - {1}   Status: {2}",
                         s.Id, s.Description, s.Status);
                }

            }

            if (choice == "2")
            {

                Console.WriteLine("Enter item description.");
                String description = Console.ReadLine();
                ItemRepository repo = new ItemRepository();
                repo.AddItem(description);
                Console.WriteLine("Added item to list.");
            }

            if (choice == "3")
            {
                Console.WriteLine("To Do List: ");

                ItemRepository repo = new ItemRepository();
                repo.GetToDoItems();
                foreach (ToDoItem s in repo.GetToDoItems())
                {
                    Console.WriteLine("{0} - {1}   Status: {2}",
                         s.Id, s.Description, s.Status);
                }

                Console.WriteLine("Enter the id for the item you want to edit");
                int newId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a new description.");
                string newDescription = Console.ReadLine();
                Console.WriteLine("Has the item been completed?");
                string newStatus = Console.ReadLine();
                repo.UpdateItem(newId, newDescription, newStatus);

            }

            if (choice == "4")
            {
                Console.WriteLine("To Do List: ");

                ItemRepository repo = new ItemRepository();
                repo.GetToDoItems();
                foreach (ToDoItem s in repo.GetToDoItems())
                {
                    Console.WriteLine("{0} - {1}   Status: {2}",
                         s.Id, s.Description, s.Status);
                }

                Console.WriteLine("Enter the id for the item you want to delete");
                int newId = Convert.ToInt32(Console.ReadLine());
                repo.DeleteItem(newId);
            }


        }
    }
}
