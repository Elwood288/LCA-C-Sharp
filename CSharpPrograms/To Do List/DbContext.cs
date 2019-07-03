using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace To_Do_List
{
    internal class ToDoContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(ProjectBase.FullName, "ToDoList.db");

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}