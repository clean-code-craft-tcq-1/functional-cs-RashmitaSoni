using System;
using System.Diagnostics;

namespace BatteryCharging
{
    public class BatteryAbnormalConditions
    {
        public static bool CheckChargingFactors(string factorName, float factorValue, float minFactorLimit, float maxFactorLimit)
        {
            if(IsLowBreahingPoint(factorValue, minFactorLimit) || IsHighBreahingPoint(factorValue, maxFactorLimit))
            {
                DisplayAbnormalConditions(factorName);
                return true;
            }
            return false;
        }
        public static bool IsLowBreahingPoint(float factorValue, float FactorLimit)
        {
            if (factorValue < FactorLimit)
            {
                return true;
            }
            return false;
        }
        public static bool IsHighBreahingPoint(float factorValue, float FactorLimit)
        {
            if (factorValue > FactorLimit)
            {
                return true;
            }
            return false;
        }
        public static void DisplayAbnormalConditions(string factorName)
        {
            Console.WriteLine("{0} is out of range!",factorName);
        }
    }
}
