using System;
using System.Collections;

namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        public void Notify()
        {
            foreach(Object o in observerArrayList)
            {
                ((Observer)o).Update(temperature_,humidity_,pressure_);
            }
        }

        public void Register(Observer o)
        {
            if(!observerArrayList.Contains(o))
            {
                observerArrayList.Add(o);
            }           
        }

        public void Remove(Observer o)
        {
            if(observerArrayList.Contains(o))
            {
                observerArrayList.Remove(o);
            }            
        }

        private ArrayList observerArrayList;

        private float temperature_;

        private float humidity_;

        private float pressure_;

        public void GetTemperature(float temperature)
        {
            temperature_ = temperature;
        }

        public void GetHumidity(float humidity)
        {
            humidity_ = humidity;
        }

        public void GetPressure(float pressure)
        {
            pressure_ = pressure;
        }

        public void MeasurementsChanged()
        {
            Notify();
        }
        
        public WeatherData()
        {
            observerArrayList = new ArrayList();
        }

        public void SetMeasurements(float temperature,float humidity,float pressure)
        {
            temperature_ = temperature;
            humidity_ = humidity;
            pressure_ = pressure;
            MeasurementsChanged();
        }
    }
}
