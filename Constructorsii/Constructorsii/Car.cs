using System;

namespace Constructorsii
{
    public class Car : Vehicle
    {
        public Car( string registrationNumber) //This is the base class. Always executed first & is not inherited
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    } 
}
