using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
    interface IVehicleInterface
    {
        string VehicleType { get; }
        double CalculateToll(int distance);
    }
}
