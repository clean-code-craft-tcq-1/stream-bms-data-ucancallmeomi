using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender_BMS
{
    public class Program
    {
        public static void Main(string[] args)
        {
			public static bool cancelStream = false;
            
            Console.WriteLine("Battery parameters streaming has started. Press Ctrl-C to stop streaming");
            Console.CancelKeyPress += (sender, eventArgs) =>
            {
                Console.WriteLine("Stopping the battery data streaming...");
                cancelStream = true;
                eventArgs.Cancel = true;
            };

            StreamBatteryParameters();
        }
		
		public static void StreamBatteryParameters()
        {
            IInputStreamer streamInput = new GenerateParemeters();
            BatteryDataReadings batteryDataReadings = new BatteryDataReadings(streamInput);
            while (!cancelStream)
            {
                Console.WriteLine(batteryDataReadings.GetBatteryReadings());
                Thread.Sleep(1000);
            }
        }
    }
}
