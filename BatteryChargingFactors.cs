using System;
using System.Diagnostics;

class BatteryChargingFactors
{
    /// <summary>
    /// This class contains the factors and conditions for lithium ion (Li-ion) battery charging.
    /// </summary>
    static bool IsBatteryCharging(float chargingTemperature_Celsius, float stateOfCharge_percentage, float chargeRate)
    {
        bool IstemperatureCorrect = CheckChargingTemperature(chargingTemperature_Celsius);
        bool IsstateofChargeCorrect = CheckStateOfCharge(stateOfCharge_percentage);
        bool IschargeRateCorrect = CheckChargeRate(chargeRate);
        return (IstemperatureCorrect && IsstateofChargeCorrect && IschargeRateCorrect);
    }
     static bool CheckChargingTemperature(float chargingTemperature_Celsius)
    {
        if (chargingTemperature_Celsius < 0 || chargingTemperature_Celsius > 45)
        {
            Console.WriteLine("Temperature is out of range!");
            return false;
        }
        return true;
    }
     static bool CheckStateOfCharge(float stateOfCharge_percentage)
    {
        if (stateOfCharge_percentage < 20 || stateOfCharge_percentage > 80)
        {
            Console.WriteLine("State of Charge is out of range!");
            return false;
        }
        return true;
    }
     static bool CheckChargeRate(float chargeRate)
    {
        if (chargeRate > 0.8)
        {
            Console.WriteLine("Charge Rate is out of range!");
            return false;
        }
        return true;
    }
    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(IsBatteryCharging(25, 70, 0.7f));
        ExpectFalse(IsBatteryCharging(50, 85, 0.0f));
        Console.WriteLine("All ok");
        return 0;
    }
}
