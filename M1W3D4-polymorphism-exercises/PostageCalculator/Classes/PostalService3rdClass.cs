using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class PostalService3rdClass : IDeliveryDriver
    {
        public string Name
        {
            get
            {
                return "Postal Service (3rd Class)";
            }
        }

        public double CalculateRate(int distance, double weight)
        {
            double total = 0;

            if (weight >= 144)
            {
                total = distance * 0.0170;
            }
            else if (54 <= weight && weight <= 143)
            {
                total = distance * 0.0160;
            }
            else if (16 <= weight && weight <= 53)
            {
                total = distance * 0.0150;
            }
            else if (9 <= weight && weight <= 15)
            {
                total = distance * 0.0024;
            }
            else if (3 <= weight && weight <= 8)
            {
                total = distance * 0.0022;
            }
            else if (0 <= weight && weight <= 2)
            {
                total = distance * 0.0020;
            }

            return total;
        }
    }
}
