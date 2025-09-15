﻿using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 20;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        {
            // Set the field and register itself with the weatherdata subject
            this.weatherData = weatherData;
        }
        public void Update(float temp, float humidity, float pressure)
        {
            // Set the correct fields with the relevant parameters

            this.temperature = temp;
            countUpdated++;
            sumTemperature += temp;

            // Eerste update: zet min en max gelijk aan temp
             countUpdated++;
            sumTemperature += temp;

            if (temp > maxTemp) maxTemp = temp;
            if (temp < minTemp) minTemp = temp;

            Display();
        }

        public void Display()
        {
            float average = sumTemperature / countUpdated;

            // Print the average, maximum and minimum temperature. Use appropriate fields
            Console.WriteLine($"min: {minTemp} average: {average} max: {maxTemp}");
        }
    }
}
