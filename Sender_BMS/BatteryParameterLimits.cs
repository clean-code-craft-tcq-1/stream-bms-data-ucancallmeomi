using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender_BMS
{
    public static class BatteryParameterLimits
    {
        public static double minimumTemperature = 40;
        public static double maximumTemperature = 0;
        public static double minimumChargeRate = 80;
        public static double maximumChargeRate = 20;
    }
}
