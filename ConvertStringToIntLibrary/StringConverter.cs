
using System;

namespace ConvertStringToIntLibrary
{
    public class StringConverter
    {
        //0 in ASCII code
        private const int zeroSymbolCode = 48;
        //9 in ASCII code
        private const int nineSymbolCode = 57;

        public int ConvertStringToInt(string str)
        {
            if (str == null || str == "")
                throw new ArgumentNullException("Parameter cannot be null");

            if (!IsValidSymbol(str))
                throw new InvalidNumberFormatException("The format is not valid.");

            bool isNegativ = false;
            var startIndex = 0;
            if (str[0] == '-')
            {
                startIndex++;
                isNegativ = true;
            }

            int result = 0;
            for (int i = startIndex; i < str.Length; i++)
            {
                result = result * 10 + str[i] - zeroSymbolCode;
            }
            return result = isNegativ ? - result : result;
        }

        private bool IsValidSymbol(string str)
        {
            var startIndex = 0;
            if (str[0] == '-' & str.Length > 1)
            {
                startIndex++;
            }

            for (int i = startIndex; i < str.Length; i++)
            {
                if (str[i] < zeroSymbolCode || str[i] > nineSymbolCode)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
