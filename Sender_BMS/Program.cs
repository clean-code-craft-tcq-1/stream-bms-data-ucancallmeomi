using System;
using System.Threading;

namespace Sender_BMS
{
    public class Program
    {
        private static bool cancelStream = false;

        public static void Main(string[] args)
        {
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
