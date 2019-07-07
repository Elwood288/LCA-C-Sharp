using System;
using System.Collections.Generic;
using System.Linq;

namespace To_Do_List
{
    internal class ItemRepository
    {
        private ToDoContext context = new ToDoContext();
        
        public ItemRepository()
        {
            context = new ToDoContext();
            context.Database.EnsureCreated();
        }

        //List all my ToDo Items

        public List<ToDoItem> GetToDoItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems;
            return list.ToList();
        }

        //List all pending items
        public List<ToDoItem> GetPendingItems()
        {
            IEnumerable<ToDoItem> pendingList = context.ToDoItems.Where(x => x.Status == false);
            return pendingList.ToList();
        }

        //List all done items
        public List<ToDoItem> GetDoneItems()
        {
            IEnumerable<ToDoItem> list = context.ToDoItems.Where(item => item.Status == true);
            return list.ToList();
        }

        //add item
        public void AddItem(string description)
        {
            ToDoItem item = new ToDoItem(description);
            context.ToDoItems.Add(item);
            context.SaveChanges();
        }

        //update item
        public void UpdateItem(int id, string newDescription)
        {
            ToDoItem oldItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            oldItem.Description = newDescription;
            context.Update(oldItem);
            context.SaveChanges();
        }

        //delete item

        public void DeleteItem(int id)
        {
            ToDoItem deleteItem = context.ToDoItems.Where(item => item.Id == id).FirstOrDefault();
            context.ToDoItems.Remove(deleteItem);
            context.SaveChanges();
        }

    

        //check if an Id exists in the database
        public bool CheckValidId(int itemId)
        {
            if (!context.ToDoItems.Any(a => a.Id == itemId))
            {
                return false;
            }
            else
            {
                return true;
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
    }


}