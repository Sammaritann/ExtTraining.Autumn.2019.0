using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
  public interface IIndexCounter
    {
        int Count(int masLength);
      int Next(int index);
    }
}
