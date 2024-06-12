using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumbers()
        {
            // TODO
            List<int> integersList = new List<int> {1,2,3};
            
            foreach (int i in integersList) {
                Console.Write($"{i} ");
            }
        }
    }
}