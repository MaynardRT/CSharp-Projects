using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void PrintNumbers()
        {
            // Initialize array and print each number using a foreach loop
            int[] arrayIntegers = {
                1, 2, 3, 4, 5
            };
            foreach (int i in arrayIntegers) {
                Console.WriteLine(i);
            }
        }
    }
}
