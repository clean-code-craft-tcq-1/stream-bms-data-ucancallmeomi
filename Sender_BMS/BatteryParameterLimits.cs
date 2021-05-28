using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender_BMS
{
    public class BatteryParameterLimits
    {
        public  double minimumTemperature = 40;
        public  double maximumTemperature = 0;
        public  double minimumChargeRate = 80;
        public  double maximumChargeRate = 20;
    }
}
