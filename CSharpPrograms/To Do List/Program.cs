using System;

namespace To_Do_List
{
    internal class Program
    {
        private ToDoContext context = new ToDoContext();
        private static App app = new App();
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
                    string choice = conu.WhatList();
                    if (choice == "1")
                    {
                        app.PrintFullList();
                    }
                    if (choice == "2")
                    {
                        app.PrintPendingList();
                    }
                    if (choice == "3")
                    {
                        app.PrintDoneList();
                    }
                    else
                    {
                        conu.ErrorMessage();
                    }
                    Console.Read();
                }
                //Add item
                if (choice == "2")
                {
                    app.NewItemApp();
                }
                //Edit item
                if (choice == "3")
                {
                    app.PrintFullList();
                    app.UpdateMenu();
                    Console.Read();
                }
                //Delete item
                if (choice == "4")
                {
                    app.PrintFullList();
                    app.DeleteItem();
                    Console.Read();
                }
            }
        }
    }
}