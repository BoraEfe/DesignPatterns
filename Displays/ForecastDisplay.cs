using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display()
        {
            // Print a forecast message based on the current temperature and humidity
            if (temperature > 80 && humidity < 50)
            {
                Console.WriteLine("Forecast: It's going to be a hot and dry day!");
            }
            else if (temperature < 50 && humidity > 70)
            {
                Console.WriteLine("Forecast: It's going to be a cold and wet day!");
            }
            else
            {
                Console.WriteLine("Forecast: The weather is moderate today.");
            }
        }
    }
}
