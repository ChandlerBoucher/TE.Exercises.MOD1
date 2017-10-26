using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalService2ndClass : IDeliveryDriver
    {
        public string Name
        {
            get
            {
                return "Postal Service (2nd Class)";
            }
        }

        public double CalculateRate(int distance, double weight)
        {
            double total = 0;

            if (weight >= 144)
            {
                total = distance * 0.05;
            }
            else if (54 <= weight && weight <= 143)
            {
                total = distance * 0.045;
            }
            else if (16 <= weight && weight <= 53)
            {
                total = distance * 0.0195;
            }
            else if (9 <= weight && weight <= 15)
            {
                total = distance * 0.0047;
            }
            else if (3 <= weight && weight <= 8)
            {
                total = distance * 0.0040;
            }
            else if (0 <= weight && weight <= 2)
            {
                total = distance * 0.0035;
            }

            return total;

        }
    }
}
