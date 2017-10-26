using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SPU4Day : IDeliveryDriver
    {
        public string Name
        {
            get
            {
                return "SPU (4-Day Ground)";
            }
        }

        public double CalculateRate(int distance, double weight)
        {
            double poundage = weight / 16;
            double total = 0;

            total = (poundage * 0.0050) * distance;

            return total;
        }
    }
}
