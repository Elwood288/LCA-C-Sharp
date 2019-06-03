using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {   // example
            //Car mycar = new Car();
            //mycar.Model = "Ford";
            //mycar.Year = 2015;
            //mycar.Make = "Ford";
            //mycar.NumberOfDoors = 4;

            //Console.WriteLine(mycar.getcardetails());

            //Car yourcar = new Car();

            DriversLicense myLicense = new DriversLicense("John", "Cherry", "Male", 12345);
            Console.WriteLine(myLicense.GetDriversLicenseDetails());
            Console.Read();

        }
    }

    //class Car
    //{
    //    public string Make { get; set; }
    //    public string Model { get; set; }
    //    public int Year { get; set; }
    //    public int NumberOfDoors { get; set; }

    //    //constructor
    //    public Car()
    //    {
    //        //default value
    //        Make = "unknown";
    //        Model = "unknown";
    //        Year = 2019;

    //    }
    //    //another way to do constructor
    //    public Car(string Make, string model, int year, int numberofdoors)
    //    {
           
    //    }

    //    public string getcardetails()
    //    {
    //        return (Model + Make + Year + NumberOfDoors);
    //    }

    //}
     class DriversLicense
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int LicenseNumber { get; set; }


        //constructor

        //public DriversLicense()
        //{
        //    FirstName = "John";
        //    LastName = "Smith";
        //    Gender = "Male";
        //    LicenseNumber = 12345;
        //}
        public DriversLicense(string FirstName, string LastName, string Gender, int LicenseNumber)
        {
            FirstName = "John";
            LastName = "Smith";
            Gender = "Male";
            LicenseNumber = 12345;
        }
        
        public string GetFullName()
        {
            string Fullname = FirstName + LastName;
            return Fullname;
        }
        public string GetDriversLicenseDetails()
        {
            return (GetFullName() + Gender + LicenseNumber);
        }

    }

    class Book
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public int Pages { get; set; }
        public string SKU { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }


        //constructor
        public Book(string Title, string[] Authors, int Pages, string SKU, string Publisher, double Price)
        {

        }

        public string GetBookDetails()
        {
            return (Title + Authors + Pages + SKU + Publisher + Price);
        }
    }
class Airplane
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Variant { get; set; }
        public int Capacity { get; set; }
        public int Engines { get; set; }
        


        //constructor
        public Airplane()
        {
            Manufacturer = "unknown";
            Model = "unknown";
            Variant = "unknown";
            Capacity = 0;
            Engines = 0;
        }

        public string GetAirplaneDetails()
        {
            return (Manufacturer + Model + Variant + Capacity + Engines);
        }
    }
}

