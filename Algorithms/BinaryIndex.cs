using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
  public  class BinaryIndex : IIndexCounter
    {
        public int Next(int index)
        {
            return 2*index;
        }
    }
}
