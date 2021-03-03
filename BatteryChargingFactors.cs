using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingFactors
    {
        static float minimumChargingTemprature_Celsius = 0;
        static float maximumChargingTemprature_Celsius = 45;
        static float minimumStateOfCharge_Percentage = 20;
        static float maximumStateOfCharge_Percentage = 80;
        static float minimumChargeRate = 0.3f;
        static float maximumChargeRate = 0.8f;
        public static void CheckChargingTemperature(float chargingTemperature_Celsius)
        {
            BatteryAbnormalConditions.CheckBreachingPoint("Charging Temperature", chargingTemperature_Celsius, minimumChargingTemprature_Celsius, maximumChargingTemprature_Celsius);
        }
        public static void CheckChargeRate(float chargeRate)
        {
            BatteryAbnormalConditions.CheckBreachingPoint("Charge Rate", chargeRate, minimumChargeRate, maximumChargeRate);
        }
        public static void CheckStateOfCharge(float stateOfCharge_percentage)
        {
            BatteryAbnormalConditions.CheckBreachingPoint("State of Charge", stateOfCharge_percentage, minimumStateOfCharge_Percentage, maximumStateOfCharge_Percentage);
        }
    }
}
