﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace NewToDo
{
    class ToDoListContext : DbContext
    {

        // This property corresponds to the table in our database
        public DbSet<ToDo> toDoList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the directory the code is being executed from
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            // get the base directory for the project
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            // add 'books.db' to the project directory
            String DatabaseFile = Path.Combine(ProjectBase.FullName, "books.db");

            // to check what the path of the file is, uncomment the file below
            //Console.WriteLine("using database file :"+DatabaseFile);

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}
