using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kazimirik.TechnologiaProgramirovania.Classes
{
    public class Generator
    {
        private int Factorial(int numb)
        {
            int res = 1;
            for (int i = numb; i > 1; i--)
                res *= i;
            return res;
        }
        static public bool NewClient(int currentTick)
        {
            Random rnd = new Random(DateTime.Now.Second);
            var possible = rnd.Next(0, 100) / 100;
            if (possible > 0.75)
            {
                return true;
            }
            else
            {
                return false;
            }
          //  var isNow = (30 * Math.Exp(-30)) / Factorial(30);
            
        }

    }
}
     