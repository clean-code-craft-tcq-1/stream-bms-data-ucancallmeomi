using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sender_BMS
{
    public class BatteryDataReadings
    {
        private readonly IInputStreamer batteryStreamingInput;
        public BatteryDataReadings(IInputStreamer _streamingInput)
        {
            batteryStreamingInput = _streamingInput;
        }
        public BatteryParameters GetBatteryReadings()
        {
            BatteryParameters batteryParameters = new BatteryParameters(batteryStreamingInput.StreamTemperatureReadings(), batteryStreamingInput.StreamSOCReadings());
            return batteryParameters;
        }

        
    }
}