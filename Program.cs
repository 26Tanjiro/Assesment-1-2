using System;
using System.Linq;

namespace Asses_2;

internal static class Program
{
	static void Main(string[] args)
	{

        Console.WriteLine("Time Converter");
        Console.WriteLine("-------------------");
        Console.WriteLine("Enter the time value:");
        double timeValue;
        while (!double.TryParse(Console.ReadLine(), out timeValue) || timeValue < 0)
        {
            Console.WriteLine("Please enter a valid positive number:");
        }

        Console.WriteLine("Enter the unit of time (seconds, minutes, hours, days, weeks, months, years):");
        string fromUnit = Console.ReadLine().ToLower();
        while (!IsValidUnit(fromUnit))
        {
            Console.WriteLine("Please enter a valid unit:");
            fromUnit = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Enter the unit to convert to (seconds, minutes, hours, days, weeks, months, years):");
        string toUnit = Console.ReadLine().ToLower();
        while (!IsValidUnit(toUnit))
        {
            Console.WriteLine("Please enter a valid unit:");
            toUnit = Console.ReadLine().ToLower();
        }

        double convertedTime = ConvertTime(timeValue, fromUnit, toUnit);
        Console.WriteLine($"{timeValue} {fromUnit} is equal to {convertedTime} {toUnit}.");
    }

    static double ConvertTime(double value, string fromUnit, string toUnit)
    {
        // Conversion rates relative to seconds
        var conversionRates = new Dictionary<string, double>;
        {
            { "seconds", 1 },
            { "minutes", 60 },
            { "hours", 3600 },
            { "days", 86400 },
            { "weeks", 604800 },
            { "months", 2629800 }, // Average month length in seconds
            { "years", 31557600 } // Average year length in seconds
        };

        // Convert value to seconds
        double seconds = value * conversionRates[fromUnit];

        // Convert seconds to the desired unit
        return seconds / conversionRates[toUnit];
    }

    static bool IsValidUnit(string unit)
    {
        var validUnits = new List<string> { "seconds", "minutes", "hours", "days", "weeks", "months", "years" };
        return validUnits.Contains(unit.ToLower());
    
}

	}
}
