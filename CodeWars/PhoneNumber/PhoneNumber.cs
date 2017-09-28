using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class PhoneNumber
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            if (numbers.Length < 10) return "";
            if (numbers.Any(x => x > 9)) return "";

            var result = "(";
            result += numbers[0];
            result += numbers[1];
            result += numbers[2];
            result += ") ";

            result += numbers[3];
            result += numbers[4];
            result += numbers[5];
            result += "-";

            result += numbers[6];
            result += numbers[7];
            result += numbers[8];
            result += numbers[9];

            return result;
        }
    }
}
