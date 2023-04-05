using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit) {
            double convertedTemp = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} Fahrenheit is {convertedTemp} Celcius");
            return convertedTemp;
        }

        public static double CelciusToFahrenheit(double celcius)
        {
            double convertedTemp = celcius * 9 / 5 + 32;
            Console.WriteLine($"{celcius} Celcius is {convertedTemp} Fahrenheit");
            return convertedTemp;
        }
    }
}
