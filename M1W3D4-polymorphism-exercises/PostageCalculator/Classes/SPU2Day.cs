using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{

    public class SPU2Day : IDeliveryDriver
    {
    public string Name
    {
        get
        {
            return "SPU (2-Day Business)";
        }
    }

        public double CalculateRate(int distance, double weight)
        {
            double poundage = weight / 16;
            double total = 0;

            total = (poundage * 0.050) * distance;
            return total;
        }
    }
}
