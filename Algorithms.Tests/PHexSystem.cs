using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class PHexSystem : IPSystem
    {
        public int P => 16;
        public int GetP(int number)
        {
            int count = 0;
            string str = Convert.ToString(number, 16);
            foreach (var a in str)
            {
                if (a == 'a') count++;
            }

            return count;
        }
    }
}
