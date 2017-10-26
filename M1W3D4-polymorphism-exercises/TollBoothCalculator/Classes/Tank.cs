using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    public class Tank : IVehicleInterface
    {
        private string vehicleType;
        public Tank()
        {
            vehicleType = "Tank";
        }

        public string VehicleType
        {
            get
            {
                return vehicleType;
            }
        }

        public double CalculateToll(int distance)
        {
            return 0;
        }
    }
}
