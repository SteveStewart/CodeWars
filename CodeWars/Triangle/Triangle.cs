using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            //we don't want negative values.
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }

            //ensure side length is greater than the third in every combination.
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }

            return false;
        }
    }
}
