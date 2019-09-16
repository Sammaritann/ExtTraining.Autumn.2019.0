using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
  public  class PBinarySystem : IPSystem
    {   

       

        public int GetP(int number)
        {
            int count = 0;
            string str = Convert.ToString(number, 2);
            foreach (var a in str)
            {
                if (a == '1') count++;
            }

            return count;
        }
    }
}
