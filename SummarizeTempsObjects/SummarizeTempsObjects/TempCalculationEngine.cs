using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            // add logic to calculate the average
            int totaltemp = 0;
            foreach(int temp in _temperatures)
            {
                totaltemp += temp;
            }
            return totaltemp / _temperatures.Count; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int aboveCount = 0;

            foreach (int temp in _temperatures)
            {


                if (temp > threshold)
                {
                    aboveCount += 1;
                }
            }
            return aboveCount; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
            int belowCount = 0;

            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    belowCount += 1;
                }
            }
            return belowCount; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int atThreshold = 0;
            foreach (int temp in _temperatures)
            {
                if (temp == threshold)
                {
                    atThreshold += 1;

                }
            }
            return atThreshold ; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
