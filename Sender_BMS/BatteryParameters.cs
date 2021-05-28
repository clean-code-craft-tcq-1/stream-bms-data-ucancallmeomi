using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender_BMS
{
    public class BatteryParameters
    {
        public double Temperature;
        public double StateOfCharge;
        public BatteryParameters(double temperature, double SOC)
        {
            this.Temperature = temperature;
            this.StateOfCharge = SOC;
        }
    }

}
