using System;
using System.Collections.Generic;
using System.Text;

namespace Sender_BMS
{
    public interface IInputStreamer
    {
         double StreamTemperatureReadings();
         double StreamSOCReadings();
    }
}