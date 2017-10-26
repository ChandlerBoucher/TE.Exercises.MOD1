using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicleInterface
    {
        private int numberOfAxels;
        private string vehicleType;

        public Truck (int numberOfAxels)
        {
            this.numberOfAxels = numberOfAxels;
            vehicleType = "Truck";
        }

        public string VehicleType
        {
            get
            {
                return vehicleType;
            }
        }
        
        public int NumberOfAxels
        {
            get
            {
                return numberOfAxels;
            }
        }

        public double CalculateToll(int distance)
        {
            double toll = 0.045 * distance;

            if (numberOfAxels >= 8)
            {
                toll = 0.048 * distance;
            }

            if (numberOfAxels <= 5)
            {
                toll = 0.040 * distance;
            }

            return toll;
        }
    }
}
