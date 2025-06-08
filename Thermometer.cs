using System;

class Thermometer
{
    static void Main()
    {
        Console.WriteLine("=== Digital Thermometer ===");
        
        Console.Write("Enter temperature in Celsius: ");
        string input = Console.ReadLine();
        double celsius;

        if (double.TryParse(input, out celsius))
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            double kelvin = celsius + 273.15;

            Console.WriteLine($"\nTemperature in Celsius: {celsius}°C");
            Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}°F");
            Console.WriteLine($"Temperature in Kelvin: {kelvin}K");

            // Temperature Category
            if (celsius < 10)
            {
                Console.WriteLine("Condition: Cold ❄️");
            }
            else if (celsius <= 30)
            {
                Console.WriteLine("Condition: Normal 🌤️");
            }
            else
            {
                Console.WriteLine("Condition: Hot 🔥");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
