﻿using System;

namespace Algorithms
{
    public static class ArrayExtension
    {




       public static void BubbleSort( this int[] mas,IPSystem pSystem,IIndexCounter indexCounter)
        {
            int counter = mas.Length % indexCounter.P > 0 ? mas.Length / indexCounter.P : mas.Length / indexCounter.P-1;
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
               for(int j=0;j<counter;j++)
                {
                    if(pSystem.GetP(mas[indexCounter.Next(j+1)])>pSystem.GetP(mas[indexCounter.Next(j)]))
                    {
                        temp = mas[indexCounter.Next(j + 1)];
                        mas[indexCounter.Next(j + 1)] = mas[indexCounter.Next(j)];
                        mas[indexCounter.Next(j)] = temp;
                    }
                }
            }
           
        }

    }
}
