using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GunbinNA.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = (a + 372 == b) ^ (c == d);
            result[1] = result[0];
            result[2] = (b > a) | (c > d);
            result[3] = (c - d > b) & (a - c > b);
            result[4] = (a + b + c <= d);
            result[5] = (a + 372 != b) && (a == c + 71);

            return result;
        }
    }
}
