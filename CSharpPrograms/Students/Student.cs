using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Students
{
    class Student
    {
        // notice the private set on the id
        public int Id { get; private set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Student(String FirstName, String LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
