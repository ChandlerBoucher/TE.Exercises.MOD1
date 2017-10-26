using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Classes;


namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random myRandom = new Random();
            List<IVehicleInterface> Vehicles = new List<IVehicleInterface>();

            Vehicles.Add(new Car(true));
            Vehicles.Add(new Car(false));
            Vehicles.Add(new Truck(4));
            Vehicles.Add(new Truck(6));
            Vehicles.Add(new Truck(8));
            Vehicles.Add(new Tank());

            int myDistance;
            double totalDist = 0;
            double totoll = 0;

            Console.WriteLine("{0,-20}{1,-30}{2}", "Vehicle", "Distance Traveled", "Toll $");
            Console.WriteLine("".PadRight(56, '-'));
            
            foreach(IVehicleInterface Vehicle in Vehicles)
            {
                myDistance = myRandom.Next(10, 240);
                double toll = Vehicle.CalculateToll(myDistance);
                totalDist = totalDist + myDistance;
                totoll = totoll + toll;
                Console.WriteLine("{0, -20}{1,-30}{2:0.00}", Vehicle.VehicleType, myDistance, toll);
            }

            Console.WriteLine($"\nTotal Miles Traveled: {totalDist / 100}");
            Console.WriteLine($"Total Tollbootch Revenue : ${totoll:0.00}");
        }
    }
}
