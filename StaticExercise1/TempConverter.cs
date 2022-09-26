using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise1
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double degreesF)
        {
            return (degreesF - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double degreesC)
        {
            return (degreesC * 9) / 5 + 32;
        }


    }
}
