using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    internal class Program
    {
        static string choice;
        private static void Main(string[] args)
        {
            Dictionary<string, string> GradeBookDictionary =
            new Dictionary<string, string>();
            while (choice != "quit" || choice != "Quit")
            {
                Console.WriteLine("Enter a student's name or type quit");
                choice = Console.ReadLine();
                if (choice == "quit" || choice == "Quit")
                {
                    break;
                }
                Console.Clear();
                //get student's grades
                Console.WriteLine("Enter " + choice + "'s grades with a space between each grade.");
                string grades = Console.ReadLine();
                //add student's name and grades to dictionary
                GradeBookDictionary.Add(choice, grades);
                Console.Clear();
            }
            Console.Clear();
            //print out all student names and their grades
            foreach (var choice in GradeBookDictionary.Keys)
            {
                //Split grades into an array
                string[] gradesArray = GradeBookDictionary[choice].Split(' ');
                //convert gradesArray to int
                int[] gradeInts = Array.ConvertAll(gradesArray, int.Parse);
                //find high grade
                int highGrade = gradeInts.Max();
                //find low grade
                int lowGrade = gradeInts.Min();
                //find average grade
                //double d = Convert.ToDouble(gradeInts);
                double averageGrade = gradeInts.Average();
                //Write out students information
                Console.WriteLine("Student: " + choice);
                Console.WriteLine("Highest Grade: " + highGrade);
                Console.WriteLine("Low Grade: " + lowGrade);
                Console.WriteLine("Average Grade: " + averageGrade);
                Console.WriteLine("_________________________________________");
                Console.WriteLine("");
            }

            Console.Read();
        }
    }
}