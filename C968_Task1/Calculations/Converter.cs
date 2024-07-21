using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Task1.Calculations
{
    public static class Converter
    {
        public static bool ConvertToFloat(this string value, out float sourceFloat)
        {
            return float.TryParse(value, out sourceFloat);
        }

        public static bool ConvertToInt(this string value, out int sourceInt)
        {
            return int.TryParse(value, out sourceInt);
        }
    }
}
