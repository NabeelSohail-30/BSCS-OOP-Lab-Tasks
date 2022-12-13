using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("2010","red","gtx",4);
            v.printinfo();
            Car c = new Car();
            c.CalculateSpeed();
            Bike b = new Bike();
            b.CalculateSpeed();
            Console.Read();
        }
    }

    class Vehicle
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string model, string color, string engine, int doors)
        {
            this.Model = model;
            this.Color = color;
            this.Engine = engine;
            this.Doors = doors;
        }

        public void Start()
        {
            Console.WriteLine("Vehicle Started");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }

        public void Run()
        {
            Console.WriteLine("Vehicle is Running");
        }

        public virtual void CalculateSpeed()
        {

        }

        public void printinfo()
        {
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Engine: {this.Engine}");
            Console.WriteLine($"Doors: {this.Doors}");
            this.Start();
            this.Stop();
            this.Run();
        }

    }

    class Car:Vehicle
    {
        public override void CalculateSpeed()
        {
            Console.WriteLine("Speed of Car is 180 km/h");
        }
    }

    class Bike : Vehicle
    {
        public override void CalculateSpeed()
        {
            Console.WriteLine("Speed of Car is 80 km/h");
        }
    }
}
