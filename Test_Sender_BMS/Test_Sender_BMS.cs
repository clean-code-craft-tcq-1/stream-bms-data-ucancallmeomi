using System;
using Sender_BMS;
using Xunit;

namespace Test_Sender_BMS
{
    public class Test_Sender_BMS
    {

        [Fact]
        public void GetRandomNumber_WhenWithinGivenRange()
        {
            double randomNumber = new GenerateParemeters().GenerateRandomNumber(0, 45);
            Assert.True(randomNumber >= 0 && randomNumber <= 45);
        }
        [Fact]
        public void GetTemperature_WhenWithinGivenRange()
        {
            double temperature = new GenerateParemeters().StreamTemperatureReadings();
            Assert.True(temperature <= BatteryParameterLimits.maximumTemperature && temperature >= BatteryParameterLimits.minimumTemperature);
        }
        [Fact]
        public void GetChargeRate_WhenWithinGivenRange()
        {
            double ChargeRate = new GenerateParemeters().StreamSOCReadings();
            Assert.True(ChargeRate <= BatteryParameterLimits.maximumChargeRate && ChargeRate >= BatteryParameterLimits.minimumChargeRate);
        }
    }
}
