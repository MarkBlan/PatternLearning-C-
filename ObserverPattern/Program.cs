using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentCondotionBroadcast b = new CurrentCondotionBroadcast(weatherData);

            weatherData.SetMeasurements(1.00f, 2.00f, 4.23f);


            Console.ReadKey();

        }
    }
}
