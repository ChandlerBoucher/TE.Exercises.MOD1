using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class FexEd : IDeliveryDriver
    {

        public double CalculateRate(int distance, double weight)
        {
            double total = 20.00;

            if(distance > 500)
            {
                total += 5.00;
            }
            if(weight > 48)
            {
                total += 3.00;
            }
            return total;
        }

        public string Name
        {
            get
            {
                return "FexEd";
            }
        }
    }
}
