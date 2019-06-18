using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Program
    {
        static List<IRentable> Inventory = new List<IRentable>();
        static void Main(string[] args)
        {
            Car blueCar = new Car("Blue Car");
            Inventory.Add(blueCar);
            House redHouse = new House("Red House");
            Inventory.Add(redHouse);
            Boat greenBoat = new Boat("Green Boat");
            Inventory.Add(greenBoat);

            foreach (var item in Inventory)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Type: " + item.WhatType());
                Console.WriteLine("Description: " + item.GetDescription());
                Console.WriteLine("Rate: $" + item.GetDailyRate());
                Console.WriteLine("____________________________");

            }
            Console.Read();
        }

        private interface IRentable
        {
            decimal GetDailyRate();

            string GetDescription();

            string WhatType();
        }

        private class Car : IRentable
        {
            public decimal DailyRate = 200;

            public string Type = "Car";
            public string Description { get; set; }

            public Car(string description)
            {
                Description = description;
            }

            public decimal GetDailyRate()
            {
                return DailyRate;
            }

            public string GetDescription()
            {
                return Description;
            }
            public string WhatType()
            {
                return Type;
            }
        }

        private class House : IRentable
        {
            public decimal WeeklyRate = 2100;
            public string Type = "House";
            public string Description { get; set; }

            public House(string description)
            {
                Description = description;
            }

            public decimal GetDailyRate()
            {
                return Decimal.Round(WeeklyRate / 7, 2);
            }

            public string GetDescription()
            {
                return Description;
            }
            public string WhatType()
            {
                return Type;
            }
        }

        private class Boat : IRentable
        {
            public decimal hourlyRate = 12;
            public string Type = "Boat";
            public string Description { get; set; }

            public Boat(string description)
            {
                Description = description;
            }

            public decimal GetDailyRate()
            {
                return Decimal.Round(hourlyRate * 24, 2);
            }

            public string GetDescription()
            {
                return Description;
            }
            public string WhatType()
            {
                return Type;
            }
        }
    }
}