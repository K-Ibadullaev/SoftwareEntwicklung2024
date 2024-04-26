using System;

namespace TemperatureCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit, celsius;
            celsius = 0;
            fahrenheit = 9 / 5 * celsius + 32;
            WriteLine("{0} Celsius entspricht {1} Fahrenheit", celsius, fahrenheit);
            WriteLine("Celsius: ");
            celsius = float.Parse(ReadLine());
            fahrenheit = 9 / 5 * celsius + 32;
            WriteLine("Fahrenheit: {0}", fahrenheit);
        }
    }
}
