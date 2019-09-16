using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
  public  class BinaryIndex : IIndexCounter
    {
        public int Count(int masLength)
        {
         return    masLength % 2 > 0 ? masLength / 2 : masLength /2 - 1;
        }

        public int Next(int index)
        {
            return 2*index;
        }
    }
}
