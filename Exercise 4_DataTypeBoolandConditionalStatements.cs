using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void CheckLogin()
        {
            bool isLoggedIn = false;

            // Assign a value to isLoggedIn based on user input or condition
            if (isLoggedIn != true) {
                isLoggedIn = true;
            }

            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }
        }
    }
}