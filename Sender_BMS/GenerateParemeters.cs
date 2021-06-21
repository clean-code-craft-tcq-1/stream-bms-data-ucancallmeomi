using System;


namespace Sender_BMS
{
    public class GenerateParemeters: IInputStreamer
    { 

        public double StreamTemperatureReadings()
        {
            return GenerateRandomNumber(BatteryParameterLimits.minimumTemperature, BatteryParameterLimits.maximumTemperature);
        }
        public double StreamSOCReadings()
        {
            return GenerateRandomNumber(BatteryParameterLimits.minimumChargeRate, BatteryParameterLimits.maximumChargeRate);
        }
        
        public double GenerateRandomNumber(double minValue, double maxValue)
        {
            Random random = new Random();
            double RandomValue = Math.Round((random.NextDouble() * (maxValue - minValue) + minValue), 2);
            return RandomValue;
        }
		
    }

}
