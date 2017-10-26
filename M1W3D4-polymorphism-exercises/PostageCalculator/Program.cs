using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeliveryDriver> deliveryOptions = new List<IDeliveryDriver>();

            Console.Write("Please enter the weight of the package: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Is that (P)ounds or (O)unces? ");
            string PoundOrOunce = Console.ReadLine();
            Console.Write("What distance will it be traveling (miles): ");
            int distance = int.Parse(Console.ReadLine());

            PoundOrOunce = PoundOrOunce.ToUpper();
            
            if (PoundOrOunce.Contains("P"))
            {
                weight *= 16;
            }


            deliveryOptions.Add(new PostalService1stClass());
            deliveryOptions.Add(new PostalService2ndClass());
            deliveryOptions.Add(new PostalService3rdClass());
            deliveryOptions.Add(new FexEd());
            deliveryOptions.Add(new SPU4Day());
            deliveryOptions.Add(new SPU2Day());
            deliveryOptions.Add(new SPUNextDay());

            Console.WriteLine("{0,-40 }{1}", "Delivery Method", "$ Cost");
            Console.WriteLine("".PadRight(50, '-'));
            foreach(IDeliveryDriver shipOption in deliveryOptions)
            {
                Console.WriteLine("{0, -40}{1: 0.00}", shipOption.Name, shipOption.CalculateRate(distance, weight));
            }

        }
    }
}
