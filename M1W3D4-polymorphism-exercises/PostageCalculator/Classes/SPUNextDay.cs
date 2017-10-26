using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class SPUNextDay : IDeliveryDriver
    {
        public string Name
        {
            get
            {
                return "SPU (Next-Day)";
            }
        }



        public double CalculateRate(int distance, double weight)
        {
            double poundage = weight / 16;
            double total = 0;

            total = (poundage * 0.075) * distance;

            return total;
        }
    }
}
