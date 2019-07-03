using System;

namespace To_Do_List
{
    internal class ToDoItem
    {
        public int Id { get; private set; }
        public String Description { get; set; }
        public bool Status { get; set; }

        public ToDoItem(String description)
        {
            this.Description = description;
            this.Status = false;
        }
    }
}