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

        //Asks the user if they want to view a filtered list or the whole list\
        //Fixed
        public string WhatList()
        {
            Console.WriteLine("What list would you like to view?");
            Console.WriteLine("1. Full list");
            Console.WriteLine("2. Only pending items");
            Console.WriteLine("3. Only done items");
            string choice = Console.ReadLine();
            return choice;
          
        }

       

        //Adds a new item to the list
        //Fixed
        public string NewItem()
        {
            Console.Clear();
            Console.WriteLine("Enter item description.");
            String description = Console.ReadLine();
            return description;
        }

        //Asks the user if they want to update a description or a status
        //Fixed
        public string UpdateItem()
        {
            Console.WriteLine("What would you like to update");
            Console.WriteLine("1. Update a description.");
            Console.WriteLine("2. Update a status.");
            string choice = Console.ReadLine();
            return choice;
        }

        //Update description menu
        public string GetIdFromUser()
        {
            Console.WriteLine("Enter the id for the item you want to edit");
            string stringId = Console.ReadLine();
            return stringId;
        }
        //Error message for invalid inputs
        public void ErrorMessage()
        {
            Console.WriteLine("Invalid input.");
        }
    }
}