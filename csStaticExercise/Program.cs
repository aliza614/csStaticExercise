using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csStaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var far1 = 98.8;
            var cel2 = 32.3;

            var far2=TempConverter.CelsiusToFarenheit(cel2);
            var cel1 = TempConverter.FarenheitToCelsius(far1);

            Console.WriteLine($"{far1:N2} F is { cel1:N2} C and {cel2:N2} C is {far2:N2} F" );
        }
    }
}
