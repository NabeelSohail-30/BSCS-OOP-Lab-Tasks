using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> VehicleList = new List<Vehicle>();
            Vehicle vehicle;
            int i;

            Console.Write("Enter Number of Vehicles: ");
            int NumOfVehicles = int.Parse(Console.ReadLine());
            VehicleList.Capacity = NumOfVehicles;

            Console.WriteLine();

            for(i = 0; i < NumOfVehicles; i++)
            {
                vehicle = new Vehicle();
                Console.WriteLine($"Enter Details for Vehicle {i+1}");
                Console.Write("Name: ");
                vehicle.Name = Console.ReadLine();
                Console.Write("Model: ");
                vehicle.Model = Console.ReadLine();
                Console.Write("Color: ");
                vehicle.Color = Console.ReadLine();
                VehicleList.Add(vehicle);
                Console.WriteLine();
            }

            Console.WriteLine();
            i = 0;

            foreach(Vehicle vehicleItem in VehicleList)
            {
                Console.WriteLine($"Vehicle no. {i+1}");
                Console.WriteLine($"Name: {vehicleItem.Name}");
                Console.WriteLine($"Model: {vehicleItem.Model}");
                Console.WriteLine($"Color: {vehicleItem.Color}");
                i++;
                Console.WriteLine();
            }

            Console.Read();
        }
    }

    class Vehicle
    {
        private string _Name;
        private string _Model;
        private string _Color;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }
    }
}
