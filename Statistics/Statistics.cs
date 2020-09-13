using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
            //Implement statistics here
           Stats stasObject= new Stats();
           if(numbers.Count>0)
           {
            stasObject.max=numbers.Max<double>();
            stasObject.min=numbers.Min<double>();
            stasObject.average=numbers.Average();
           }
           else
           {
               stasObject.max=double.NaN;
               stasObject.min=double.NaN;
               stasObject.average=double.NaN;
           }

           
           return stasObject;
            
        }
    }
}
