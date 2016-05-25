using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentCondotionBroadcast : Observer, DisplayFormat
    {

        private float temperature_;
        private float humidity_;
        private float pressure_;

        private WeatherData weatherData_;
        public void Display()
        {
            Console.WriteLine("The Current temperature is {0}\nThe Current humidity is {1}\nThe current pressure is {2}",temperature_,humidity_,pressure_);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            temperature_ = temperature;
            humidity_ = humidity;
            pressure_ = pressure;
            Display();
        }

        public CurrentCondotionBroadcast(WeatherData weatherData)
        {
            weatherData_ = weatherData;
            weatherData.Register(this);
        }
    }
}
