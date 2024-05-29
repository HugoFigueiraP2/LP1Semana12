using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MultipleStuff
{
    public class SuperList : List<Double>
    {
        public void GetMinMax1(out double min, out double max)
        {
            min = double.MinValue;
            max = double.MaxValue;

            if (this.Count == 0)
            throw new InvalidOperationException("The list is empty.");

        }
        public int GetMinMax2()
        {
            if (this.Count == 0)
            throw new InvalidOperationException("The list is empty.");

            MinMax1 result = new MinMax
            {
                Min = double.MaxValue,
                MaxLengthAttribute = double.MinValue


            };

        }
        public int GetMinMax3()
        {

        }
        public int GetMinMax4()
        {

        }

    }
}