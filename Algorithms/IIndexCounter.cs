using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
  public interface IIndexCounter
    {
        int P { get; }
        int Next(int index);
    }
}
