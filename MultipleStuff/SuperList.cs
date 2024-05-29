using System;
using System.Collections.Generic;

namespace CustomListExample
{
    // SuperList class that extends List<double>
    public class SuperList : List<double>
    {
        // Constructor to initialize SuperList
        public SuperList() : base()
        {
        }

        // Method to get min and max using out parameters (Version 1)
        public void GetMinMax1(out double min, out double max)
        {
            if (this.Count == 0)
                throw new InvalidOperationException("The list is empty.");

            min = double.MaxValue;
            max = double.MinValue;

            foreach (var item in this)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
        }

        // Internal struct to hold min and max (Version 2)
        public struct MinMax
        {
            public double Min;
            public double Max;
        }

        // Method to get min and max using an internal struct (Version 2)
        public MinMax GetMinMax2()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("The list is empty.");

            MinMax result = new MinMax
            {
                Min = double.MaxValue,
                Max = double.MinValue
            };

            foreach (var item in this)
            {
                if (item < result.Min) result.Min = item;
                if (item > result.Max) result.Max = item;
            }

            return result;
        }

        // Method to get min and max using tuples by reference (Version 3)
        public (double Min, double Max) GetMinMax3()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("The list is empty.");

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var item in this)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }

            return (min, max);
        }

        // Method to get min and max using tuples with named fields (Version 4)
        public (double Minimum, double Maximum) GetMinMax4()
        {
            if (this.Count == 0)
                throw new InvalidOperationException("The list is empty.");

            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var item in this)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }

            return (Minimum: min, Maximum: max);
        }
    }

}
