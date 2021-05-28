using System;
using System.Collections.Generic;
using System.Text;

namespace Sender_BMS
{
    public interface IInputStreamer
    {
        public int StreamTemperatureReadings();
        public double StreamSOCReadings();
    }
}