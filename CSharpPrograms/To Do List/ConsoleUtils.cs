using System;

namespace To_Do_List
{
    internal class ConsoleUtils
    {
        private ToDoContext context = new ToDoContext();

        //Prints the main menu
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. View To Do List");
            Console.WriteLine("2. Add an item");
            Console.WriteLine("3. Edit an item");
            Console.WriteLine("4. Delete an item");
            Console.WriteLine("0. Quit");
        }

        //Asks the user if they want to view a filtered list or the whole list
        public void WhatList()
        {
            Console.WriteLine("What list would you like to view?");
            Console.WriteLine("1. Full list");
            Console.WriteLine("2. Only pending items");
            Console.WriteLine("3. Only done items");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                PrintFullList();
            }
            if (choice == "2")
            {
                PrintPendingList();
            }
            if (choice == "3")
            {
                PrintDoneList();
            }
            else
            {
                ErrorMessage();
            }
        }

        //Prints the full list
        public void PrintFullList()
        {
            Console.Clear();
            Console.WriteLine("To Do List: ");

            ItemRepository list = new ItemRepository();
            list.GetToDoItems();
            foreach (ToDoItem s in list.GetToDoItems())
            {
                string textStatus = "Pending";
                if (s.Status == false)
                {
                    textStatus = "Pending";
                }
                if (s.Status == true)
                {
                    textStatus = "Done";
                }
                Console.WriteLine("{0} - {1}   Status:" + textStatus,
                     s.Id, s.Description, s.Status);
            }
        }

        //Prints only pending items
        public void PrintPendingList()
        {
            Console.Clear();
            Console.WriteLine("To Do List: ");

            ItemRepository list = new ItemRepository();
            list.GetPendingItems();

            foreach (ToDoItem s in list.GetPendingItems())
            {
                string textStatus = "Pending";
                if (s.Status == false)
                {
                    textStatus = "Pending";
                }
                if (s.Status == true)
                {
                    textStatus = "Done";
                }
                Console.WriteLine("{0} - {1}   Status:" + textStatus,
                     s.Id, s.Description, s.Status);
            }
        }

        //Prints only done items
        public void PrintDoneList()
        {
            Console.Clear();
            Console.WriteLine("To Do List: ");

            ItemRepository list = new ItemRepository();
            list.GetDoneItems();

            foreach (ToDoItem s in list.GetPendingItems())
            {
                Console.WriteLine("{0} - {1}   Status: Done",
                     s.Id, s.Description, s.Status);
            }
        }

        //Adds a new item to the list
        public void NewItem()
        {
            Console.Clear();
            Console.WriteLine("Enter item description.");
            String description = Console.ReadLine();
            if (description != "")
            {
                ItemRepository repo = new ItemRepository();
                repo.AddItem(description);
                Console.WriteLine("Added item to list.");
            }
            else
            {
                ErrorMessage();
            }
        }

        //Asks the user if they want to update a description or a status
        public void UpdateItem()
        {
            Console.WriteLine("What would you like to update");
            Console.WriteLine("1. Update a description.");
            Console.WriteLine("2. Update a status.");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                UpdateDescription();
            }
            if (choice == "2")
            {
                UpdateStatus();
            }
            else
            {
                ErrorMessage();
            }
        }

        //Updates a description
        public void UpdateDescription()
        {
            ItemRepository repo = new ItemRepository();
            Console.WriteLine("Enter the id for the item you want to edit");
            string stringId = Console.ReadLine();
            bool isNumeric = int.TryParse(stringId, out int newId);
            if (isNumeric != false)
            {
                if (repo.CheckValidId(newId) == true)
                {
                    Console.WriteLine("Enter a new description.");
                    string newDescription = Console.ReadLine();
                    if (newDescription != "")
                    {
                        repo.UpdateItem(newId, newDescription);
                        Console.WriteLine("Item updated.");
                    }
                    else
                    {
                        ErrorMessage();
                    }
                }
                else
                {
                    ErrorMessage();
                }
            }
            else
            {
                ErrorMessage();
            }
        }

        //Deletes an item from the list
        public void DeleteItem()
        {
            ItemRepository repo = new ItemRepository();
            Console.WriteLine("Enter the id for the item you want to delete");
            string stringId = Console.ReadLine();
            bool isNumeric = int.TryParse(stringId, out int newId);

            if (isNumeric != false)
            {
                if (repo.CheckValidId(newId) == true)
                {
                    repo.DeleteItem(newId);
                    Console.WriteLine("Item deleted from list.");
                }
                else
                {
                    ErrorMessage();
                }
            }
            else
            {
                ErrorMessage();
            }
        }

        //Updates a status (marks as done)
        public void UpdateStatus()
        {
            ItemRepository repo = new ItemRepository();
            Console.WriteLine("Enter the id for the item who's status you want to change.");
            string stringId = Console.ReadLine();
            bool isNumeric = int.TryParse(stringId, out int newId);
            if (isNumeric != false)
            {
                if (repo.CheckValidId(newId) == true)
                {
                    Console.WriteLine("What do you want to set as this item's status?");
                    Console.WriteLine("1.Pending");
                    Console.WriteLine("2.Done");
                    repo.ChangeStatus(newId);
                    Console.WriteLine("Status updated.");
                }
                else
                {
                    ErrorMessage();
                }
            }
            else
            {
                ErrorMessage();
            }
        }

        //Error message for invalid inputs
        public void ErrorMessage()
        {
            Console.WriteLine("Invalid input.");
        }
    }
}