using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public class Person //First create a public class named person
    {
        public string Name; //field name

        public void Introduce(string to) //This is a method. Declaring a method in class Person. When you have a class, go create a method for it. See below.
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        //Create a person object from a string, should create a parse mthd. Parse mtd should take a string & return a person objec
        public static Person Parse(string str) //takes a string
        {
            //create a person object, set the name field based on the str argument above & then return that
            var person = new Person();
            person.Name = str;

            return person;
        }
                
    }

    
    class Program //METHOD CREATION
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            var person = Person.Parse("Faith");
            //person.Name = "Faith";
            person.Introduce("Shiku");
            
        }
    }
}
