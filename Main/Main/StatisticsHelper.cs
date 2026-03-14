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
    }
}
