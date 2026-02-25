using System;

namespace AbstractionVehicle
{
    abstract class Vehicle
    {
        public Vehicle(int v, string fuel)
        {
            Capacity = v;
            FuelType = fuel;
        }
        public Vehicle() { }

        public string FuelType { get; set; }
        public int Capacity { get; set; }
        

        public abstract void start();
        public abstract void Engine();
        public void ShowDetails()
        {
            Console.WriteLine($"Fuel type   : {FuelType}");
            Console.WriteLine($"Capacity is : {Capacity}");
        }
    }
    class Car : Vehicle
    {
        

        public Car(int v, string f) : base(v,f)
        {
            
        }

        public override void start()
        {
            Console.WriteLine("Car started.");
        }
        public override void Engine()
        {
            Console.WriteLine("4 Cylinder Engine");
        }
    }
    class Bike : Vehicle
    {
        public override void Engine()
        {
            Console.WriteLine("2 stroke engine");
        }

        public override void start()
        {
            Console.WriteLine("Bike started.");
        }
    }
    class AbstractProgram
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car(8,"Diesel");
            //v.FuelType = "Diesel";
            //v.Capacity = 5;
            v.start();
            v.Engine();
            v.ShowDetails();

            Console.WriteLine("-----------------------------");
            Vehicle dio = new Bike();
            dio.FuelType = "Petrol";
            dio.Capacity = 2;
            dio.start();
            dio.Engine();
            dio.ShowDetails();

        }
    }

}