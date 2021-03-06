﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class will have both weather and forecast.
//The difference between the two will be a slight change in Temp. and weather type(sunny, cloudly, partly-cloudy, rainy) if any.
namespace Lemonade
{
    public class Weather
    {
        public int realTemp;
        public int degrees;
        int type;
        public string skyType;
        List<string> sky = new List<string>(new string[] {"sunny", "cloudy", "partly-cloudy", "rainy"});
        Random num = new Random();

        public int Temperature()//Randomize temp in degrees
        {
            degrees = num.Next(50, 100);
            return degrees;
        }

        public string WeatherType()//Randomize weather type
        {
            type = num.Next(0, 3); //>= 0 and < 3. 
            skyType = sky[type]; //weatherType to match with customer's preference.
            return skyType;
        }

        public string Forecast()//Sets weather type and temperature.
        {
            int predictTemp = Temperature();
            string predictType = WeatherType();
            string forecast = "The Forecast for today is: " + predictType + " and " + predictTemp + " degrees\n";
            Console.WriteLine(forecast);
            string realWeather = ActualWeather();
            return realWeather;
        }

        public string ActualWeather()//Takes Forecast and changes results by a few degrees or between one of the weatherTypesS
        {
            string realWeather;
            //Change temp by -5 to +5 degrees
            int difference = num.Next(-5,5);
            realTemp = degrees + difference;
            //Change type randomly again if actual degrees is -5/+5 different from forecast predicted Temperature.
            if (realTemp % degrees == 5)
            {
                WeatherType();
                realWeather = "The Actual Weather for today is: " + skyType + " and " + realTemp + " degrees\n";
            }
            else
            {
                realWeather = "The Actual Weather for today is: " + skyType + " and " + realTemp + " degrees\n";
            }
            return realWeather;
        }
    }
}
