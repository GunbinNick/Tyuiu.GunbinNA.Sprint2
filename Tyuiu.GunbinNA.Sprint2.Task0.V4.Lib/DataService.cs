using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GunbinNA.Sprint2.Task0.V4.Lib
{
    public class DataService : ISprint2Task0V4
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 100;
            res[1] = x != y + 100;
            res[2] = x > (y + 1000);
            res[3] = x < (y + 1000);
            res[4] = x >= (y + 1000);
            res[5] = x <= (y + 1000);

            return res;
        }
    }
}
