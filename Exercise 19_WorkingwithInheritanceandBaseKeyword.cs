using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void SimpleCalculator()
        {
            double num_1, num_2, sum, difference, product, quotient = 0;

Console.Write("Enter first number: ");
if (double.TryParse(Console.ReadLine(), out num_1))
{
    Console.Write("Enter second number: ");
    if (double.TryParse(Console.ReadLine(), out num_2))
    {
        Console.WriteLine();

        bool isCorrect = false;

        while (!isCorrect)
        {
            Console.WriteLine("Please select an operation: 1.Addition, 2.Subtraction, 3.Multiplication, 4.Division");
            if (int.TryParse(Console.ReadLine(), out int operation))
            {
                switch (operation)
                {
                    case 1:
                        sum = num_1 + num_2;
                        Console.WriteLine($"The sum of {num_1} + {num_2} = {sum}");
                        isCorrect = true;
                        break;
                    case 2:
                        difference = num_1 - num_2;
                        Console.WriteLine($"The difference of {num_1} - {num_2} = {difference}");
                        isCorrect = true;
                        break;
                    case 3:
                        product = num_1 * num_2;
                        Console.WriteLine($"The product of {num_1} * {num_2} = {product}");
                        isCorrect = true;
                        break;
                    case 4:
                        if (num_2 != 0)
                        {
                            quotient = num_1 / num_2;
                            Console.WriteLine($"The quotient of {num_1} / {num_2} = {quotient}");
                            isCorrect = true;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Please choose a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the operation.");
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid input for the second number.");
    }
}
else
{
    Console.WriteLine("Invalid input for the first number.");
}

Console.ReadKey();
        }
    }
}
