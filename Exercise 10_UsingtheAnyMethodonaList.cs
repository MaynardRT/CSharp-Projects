
using System;
using System.Collections.Generic;
using System.Linq;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void CheckAny()
        {
            // TODO
            List<int> numbers = new List<int> {1,3,5,7,10,11};
            bool isGreaterThanFive = numbers.Any(x => x > 5);
            Console.WriteLine(isGreaterThanFive);
            
        }
    }
}