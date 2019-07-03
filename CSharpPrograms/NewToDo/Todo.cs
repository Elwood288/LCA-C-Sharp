using System;
using System.Collections.Generic;
using System.Text;

namespace NewToDo
{
    class ToDo
    {
        
        public int Id { get; private set; }
        public String Description { get; set; }
        public String Status { get; set; }
        public ToDo(String description)
        {
            this.Description = description;
            this.Status = "Pending";
        }
    }
}
