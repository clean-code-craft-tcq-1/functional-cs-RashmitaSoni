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
        static float minimumChargeRate_CRate = 0.3f;
        static float maximumChargeRate_CRate = 0.8f;
        public static bool CheckChargingTemperature(float chargingTemperature_Celsius)
        {
           return (BatteryAbnormalConditions.CheckBreachingPoint("Charging Temperature", chargingTemperature_Celsius, minimumChargingTemprature_Celsius, maximumChargingTemprature_Celsius));
        }
        public static bool CheckChargeRate(float chargeRate_CRate)
        {
            return(BatteryAbnormalConditions.CheckBreachingPoint("Charge Rate", chargeRate_CRate, minimumChargeRate_CRate, maximumChargeRate_CRate));
        }
        public static bool CheckStateOfCharge(float stateOfCharge_percentage)
        {
            return(BatteryAbnormalConditions.CheckBreachingPoint("State of Charge", stateOfCharge_percentage, minimumStateOfCharge_Percentage, maximumStateOfCharge_Percentage));
        }
    }
}
