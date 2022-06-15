using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStaticExercise
{
    public static class TempConverter
    //The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter and return a double,
    //the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.
    {
        public static double FarenheitToCelsius(double far)
        {
         //   Console.WriteLine($"far - 32.0={far - 32.0}");
            return (far-32.0)*0.5556;
        }
        public static double CelsiusToFarenheit(double cel)
        {
            return (cel/ 0.5556)+32;
        }
    }
}
