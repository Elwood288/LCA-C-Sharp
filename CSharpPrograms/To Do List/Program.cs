using System;

namespace To_Do_List
{
    internal class Program
    {
        private ToDoContext context = new ToDoContext();
        public static string choice = " ";

        private static void Main(string[] args)
        {
            while (choice != "0")
            {
                ConsoleUtils conu = new ConsoleUtils();
                conu.MainMenu();
                choice = Console.ReadLine();

                //View list
                if (choice == "1")
                {
                    conu.WhatList();
                    Console.Read();
                }
                //Add item
                if (choice == "2")
                {
                    conu.NewItem();
                    Console.Read();
                }
                //Edit item
                if (choice == "3")
                {
                    conu.PrintFullList();
                    conu.UpdateItem();
                    Console.Read();
                }
                //Delete item
                if (choice == "4")
                {
                    conu.PrintFullList();
                    conu.DeleteItem();
                    Console.Read();
                }
            }
        }
    }
}