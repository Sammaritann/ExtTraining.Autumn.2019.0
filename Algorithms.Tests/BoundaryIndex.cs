using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Tests
{
    class BoundaryIndex : IIndexCounter
    { int leftBoundary, rightBoundary;
        public BoundaryIndex(int leftIndex,int rightIndex)
        {
            leftBoundary = leftIndex;
            rightBoundary = rightIndex;
        }
        

        public int Count(int masLength)
        {
            return masLength - (rightBoundary - leftBoundary);
        }

        public int Next(int index)
        {
            return index + leftBoundary;
        }
    }
}
