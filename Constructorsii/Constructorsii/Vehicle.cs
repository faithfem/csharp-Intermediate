using System;

namespace Constructorsii
{
    public class Vehicle //This is the base constructor. It will be executed first. Base constructor is not initialized.
    {
        private readonly string _registrationNumber; //Created via initialize registrationNumber

        /*public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized.");
        }*/

        public Vehicle (string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}
