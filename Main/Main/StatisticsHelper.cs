using System;
using System.Collections.Generic;
using System.Text;

namespace Main
{
    internal class StatisticsHelper
    {
        public static Boolean IsValidInput(string input) {
            return !string.IsNullOrEmpty(input);
        }

        public static double CalculateAverage(int[] values) {
            if(values == null || values.Length == 0) return 0;
            return values.Average();
        }

        public static int CalculateMax(int[] values) {
            if (values == null || values.Length == 0) return 0;
            return values.Max();
        }
    }
}
