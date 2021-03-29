using System;

namespace Inheritance
{
    public class Vehicle
    {
        private readonly long _registrationNumber;

        public Vehicle(long registrationNumber)
        {
            registrationNumber = _registrationNumber;
            Console.WriteLine("Vehicle is being initialized.");
        }
    }

    public class Car : Vehicle
    {
        public Car (long registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
        }
    }
}
