using System;
using System.Diagnostics;
using BatteryCharging;

namespace BatteryCharging
{
    public class Checker
    {
       static bool IsBatteryCharging(float chargingTemperature_Celsius, float stateOfCharge_percentage, float chargeRate)
        {
            bool IstemperatureCorrect = BatteryChargingFactors.CheckChargingTemperature(chargingTemperature_Celsius);
            bool IsstateofChargeCorrect = BatteryChargingFactors.CheckStateOfCharge(stateOfCharge_percentage);
            bool IschargeRateCorrect = BatteryChargingFactors.CheckChargeRate(chargeRate);
            return (IstemperatureCorrect && IsstateofChargeCorrect && IschargeRateCorrect);
        }
       static void ExpectResult(bool expression, string expectresult)
        {
            switch (expectresult)
            {
                case "ExpectTrue":
                    if (!expression)
                    {
                        Console.WriteLine("Expected true, but got false");
                        Environment.Exit(1);
                    }
                    break;
                case "ExpectFalse":
                    if (expression)
                    {
                        Console.WriteLine("Expected false, but got true");
                        Environment.Exit(1);
                    }
                    break;
            }
        }
        public static int Main()
        {
            ExpectResult(IsBatteryCharging(25, 70, 0.7f), "ExpectTrue");
            ExpectResult(IsBatteryCharging(50, 85, 0.0f), "ExpectFalse");
            Console.WriteLine("All ok");
            return 0;
        }
    }
}
