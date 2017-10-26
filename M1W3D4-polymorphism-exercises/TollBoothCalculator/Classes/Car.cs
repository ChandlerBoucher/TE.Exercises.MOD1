using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicleInterface
    {
        private bool hasTrailer;
        private string vehicleType;

        public Car(bool hasTrailer)
        {
            this.hasTrailer = hasTrailer;
            vehicleType = "Car";
        }

        public string VehicleType
        {
            get
            {
                return vehicleType;
            }
        }

        public bool HasTrailer
        {
            get
            {
                return hasTrailer;
            }
        }

        public double CalculateToll(int distance)
        {
            double toll = distance * 0.020;

            if(hasTrailer)
            {
                toll = toll + 1;
            }

            return toll;
        }
    }
}
