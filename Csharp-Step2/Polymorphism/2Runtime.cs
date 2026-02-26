using System;
using System.Security.Cryptography;
namespace Runtime
{
    //abstract class cannot be instatiated
    //Runtime Polymorphism or Dynamic Polymorphism or Late binding
    abstract class Vehicle
    {
        public abstract void start();
    }
    class Bike : Vehicle
    {
        public Bike() { }
        public override void start()
        {
            Console.WriteLine("Bike");
        }
    }
    class Car : Vehicle
    {
        public Car() { }
        public override void start()
        {
            Console.WriteLine("Car");
        }
    }

    class RuntimeMain
    {
        static void Main(string[] args) {
            Vehicle c1 = new Bike();
            c1.start();
            Vehicle c2 = new Car();
            c2.start();
        }
    }
}