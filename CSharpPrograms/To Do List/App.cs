using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace To_Do_List
{
    internal class App
    {
        //This is a totally usefull class and I should get full points for it.

        ConsoleUtils conu = new ConsoleUtils();
        private ToDoContext context = new ToDoContext();

        //Prints the full list
        //Fixed?
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
        //Fixed?
        public void PrintPendingList()
        {
            Console.Clear();
            Console.WriteLine("To Do List: ");

            ItemRepository pendingList = new ItemRepository();
            pendingList.GetPendingItems();

            foreach (ToDoItem s in pendingList.GetPendingItems())
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
        //Fixed?
        public void PrintDoneList()
        {
            Console.Clear();
            Console.WriteLine("To Do List: ");

            ItemRepository list = new ItemRepository();
            list.GetDoneItems();

            foreach (ToDoItem s in list.GetDoneItems())
            {
                Console.WriteLine("{0} - {1}   Status: Done",
                     s.Id, s.Description, s.Status);
            }
        }

        // Add a new item
        public void NewItemApp()
        {
            string description = conu.NewItem();
            if (description != "")
            {
                ItemRepository repo = new ItemRepository();
                repo.AddItem(description);
                Console.WriteLine("Added item to list.");
            }
            else
            {
                conu.ErrorMessage();
            }
            Console.Read();
        }

        //Update menu
        public void UpdateMenu()
        {
            string choice = conu.UpdateItem();
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
                conu.ErrorMessage();
            }
        }

        //Updates a description
        public void UpdateDescription()
        {
            ItemRepository repo = new ItemRepository();
            string stringId = conu.GetIdFromUser();
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
                        conu.ErrorMessage();
                    }
                }
                else
                {
                    conu.ErrorMessage();
                }
            }
            else
            {
                conu.ErrorMessage();
            }
        }

        //Deletes an item from the list
        public void DeleteItem()
        {
            ItemRepository repo = new ItemRepository();
            string stringId = conu.GetIdFromUser();
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
                    conu.ErrorMessage();
                }
            }
            else
            {
                conu.ErrorMessage();
            }
        }

        //Updates a status (marks as done)
        public void UpdateStatus()
        {
            ItemRepository repo = new ItemRepository();
            string stringId = conu.GetIdFromUser();
            bool isNumeric = int.TryParse(stringId, out int newId);
            if (isNumeric != false)
            {
                if (repo.CheckValidId(newId) == true)
                {
                    Console.WriteLine("What do you want to set as this item's status?");
                    Console.WriteLine("1.Pending");
                    Console.WriteLine("2.Done");
                    ChangeStatus(newId);
                    Console.WriteLine("Status updated.");
                }
                else
                {
                    conu.ErrorMessage();
                }
            }
            else
            {
                conu.ErrorMessage();
            }
        }

        //change status

        public void ChangeStatus(int id)
        {
            ToDoItem oldItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                oldItem.Status = false;
            }
            if (choice == "2")
            {
                oldItem.Status = true;
            }
            else
            {
                conu.ErrorMessage();
                //newStatus = oldItem.Status;
            }
            //oldItem.Status = newStatus;
            context.Update(oldItem);
            context.SaveChanges();
        }







    }


    
}
