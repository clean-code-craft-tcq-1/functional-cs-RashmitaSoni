using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryChargingFactors
    {
        /// <summary>
        /// This class contains the factors and conditions for lithium ion (Li-ion) battery charging.
        /// </summary>
        static float minimumChargingTemprature_Celsius = 0;
        static float maximumChargingTemprature_Celsius = 45;
        static float minimumStateOfCharge_Percentage = 20;
        static float maximumStateOfCharge_Percentage = 80;
        static float maximumChargeRate = 0.8f;
        public static bool CheckChargingTemperature(float chargingTemperature_Celsius)
        {
            if (chargingTemperature_Celsius < minimumChargingTemprature_Celsius || chargingTemperature_Celsius > maximumChargingTemprature_Celsius)
            {
                DisplayConditionOutcome("Charging Temperature");
                return false;
            }
            return true;
        }
        public static bool CheckStateOfCharge(float stateOfCharge_percentage)
        {
            if (stateOfCharge_percentage < minimumStateOfCharge_Percentage || stateOfCharge_percentage > maximumStateOfCharge_Percentage) 
            {
                DisplayConditionOutcome("State of Charge");
                return false;
            }
            return true;
        }
        public static bool CheckChargeRate(float chargeRate)
        {
            if (chargeRate > maximumChargeRate)
            {
                DisplayConditionOutcome("Charge Rate");
                return false;
            }
            return true;
        }
        public static void DisplayConditionOutcome(string factorName)
        {
            Console.WriteLine("{0} is out of range!",factorName);
        }
    }
}
