using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroes
{
    
    class Program
    {
        static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {
            Person Steve = new Person("Steve", "Killer");
            people.Add(Steve);
            SuperHero Wolverine = new SuperHero("Logan", "adamantium claws", "Wolverine", "nickname");
            people.Add(Wolverine);
            Villian Bane = new Villian("Batman", "Bane", "nickname");
            people.Add(Bane);

            foreach (var item in people)
            {
                Console.WriteLine(item.ToString() + ": " + item.printGreeting()); 
               
            }
                Console.Read();
        }

        class Person
        {

            public string Name { get; set; }
            public string Nickname { get; set; }
           

            public Person(string personName, string nickname )
            {
                Name = personName;
                Nickname = nickname;
            }

            public override string ToString()
            {
                return ( Name);
            }
           

            public virtual string printGreeting()
            {
                return("Hi my name is " + Name + " you can call me " + Nickname +".");
            }
        }


        class SuperHero : Person
        {

            public string RealName { get; set; }
            public string Superpower { get; set; }


            public SuperHero(string realName, string superpower, string personName, string nickname) : base(personName, nickname)
            {
                RealName = realName;
                Superpower = superpower;



            }



            public override string printGreeting()
            {
                return("I am " + RealName +". When I am " + Name + ", my super power is " + Superpower + ".");
            }
        }

        class Villian : Person
        {

            public string Nemesis { get; set; }
            


            public Villian(string nemesis, string personName, string nickname) : base(personName, nickname)
            {
                Nemesis = nemesis;
            }



            public override string printGreeting()
            {
                return("I am " + Name + ". Have you seen " + Nemesis + "?");
            }
        }

    }
}
