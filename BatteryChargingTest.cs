using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingTest
    {
       static bool IsBatteryFaulty;
       public static void BatteryChargingTestFactors(float chargingTemperature_Celsius, float stateOfCharge_percentage, float chargeRate_CRate)
        {
            IsBatteryFaulty =
                BatteryAbnormalConditions.CheckChargingFactors(BatteryChargingFactors.ChargingTemperature, chargingTemperature_Celsius, BatteryChargingFactors.minimumChargingTemprature_Celsius, BatteryChargingFactors.maximumChargingTemprature_Celsius)
                | BatteryAbnormalConditions.CheckChargingFactors(BatteryChargingFactors.StateOfCharge, stateOfCharge_percentage, BatteryChargingFactors.minimumStateOfCharge_Percentage, BatteryChargingFactors.maximumStateOfCharge_Percentage)
                | BatteryAbnormalConditions.CheckChargingFactors(BatteryChargingFactors.ChargeRate, chargeRate_CRate, BatteryChargingFactors.minimumChargeRate_CRate, BatteryChargingFactors.maximumChargeRate_CRate);
            DisplayBatteryStatus();
        }
       public static void DisplayBatteryStatus()
        {
            string BatteryStatus = (IsBatteryFaulty == true) ? "Battery is faulty" : "Battery is OK";
            Console.WriteLine(BatteryStatus);
        }
    }
}
