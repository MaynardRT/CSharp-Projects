// A. LOOPS
// 1. Sum of first N program

// Console.Write("Enter a number: ");
// int userInput = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// if (userInput.GetType() == typeof(int) && userInput > 0) {
//     for (int i = 1; i <= userInput; i++)
//     {
//         sum += i;
//     }

//     Console.WriteLine($"The sum of first {userInput} numbers is: {sum}");

// } else
// {
//     Console.WriteLine("Please enter a valid positive integer.");
//     return;
// }

// 2. Multiplication Table
// Console.Write("Enter a number: ");
// int userInput = Convert.ToInt32(Console.ReadLine());
// int product = 0;

// if (userInput.GetType() == typeof(int) && userInput > 0)
// {
//     for (int i = 1; i <= 10; i++)
//     {
//         product = userInput * i;
//         Console.WriteLine($"{userInput} x {i} = {product}");
//     }
// } else
// {
//     Console.WriteLine("Please enter a valid positive integer.");
//     return;
// }

// 3. Factorial
// Console.Write("Enter a number: ");
// int userInput = Convert.ToInt32(Console.ReadLine());
// int factorial = 1;

// for (int i = 1; i <= userInput; i++)
// {
//     factorial *= i;
// }
// Console.WriteLine($"The factorial of number {userInput} = {factorial}");

// 4. Count Digits
// Console.Write("Enter a number: ");
// int userInput = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// while (userInput != 0 || userInput.Equals(null))
// {
//     userInput /= 10;
//     count++;
// }
// Console.WriteLine($"The number of digits is: {count}");

// 5. Reverse a Number
// Console.Write("Enter a number: ");
// int userInput = Convert.ToInt32(Console.ReadLine());
// int reversed = 0;
// int originalInput = userInput;

// while (userInput != 0)
// {
//     reversed = (reversed * 10) + userInput % 10;
//     userInput /= 10;
// }

// Console.WriteLine($"The reversed number of {originalInput} is: {reversed}");


// B. ARRAYS
// 1. Print largest number
// int[] numbers = Array.Empty<int>();
// const int maxSize = 5;

// for (int i = 0; i < maxSize; i++)
// {
//     Console.Write($"Enter number {i + 1}: ");
//     int userInput = Convert.ToInt32(Console.ReadLine());
//     Array.Resize(ref numbers, numbers.Length + 1);
//     numbers[i] = userInput;
// }

// Console.WriteLine("The elements in the array are: ");
// for (int i = 0; i < maxSize; i++)
// {
//     Console.Write($"{numbers[i]}, ");
// }

// Console.WriteLine($"Largest number in the array is : {numbers.Max()}");

// 2. Find Average
// int[] numbers = Array.Empty<int>();
// const int maxSize = 5;
// int sum = 0;

// for (int i = 0; i < maxSize; i++)
// {
//     Console.Write($"Enter number {i + 1}: ");
//     int userInput = Convert.ToInt32(Console.ReadLine());
//     Array.Resize(ref numbers, numbers.Length + 1);
//     numbers[i] = userInput;
//     sum += userInput;
// }

// Console.WriteLine("The elements in the array are: ");
// for (int i = 0; i < maxSize; i++)
// {
//     Console.Write($"{numbers[i]}, ");
// }

// Console.WriteLine($"\nThe average of the array is: {sum / maxSize}");


// 3. Count Even and Odd Number
// int[] arrayInt = { 24, 51, 63, 74, 324, 63, 52 };
// int evenCount = 0;
// int oddCount = 0;

// for (int i = 0; i < arrayInt.Length; i++)
// {
//     if (arrayInt[i] % 2 == 0)
//     {
//         evenCount++;
//     }
//     else
//     {
//         oddCount++;
//     }
// }

// Console.WriteLine($"Even number: {evenCount}");
// Console.WriteLine($"Odd number: {oddCount}");

// 4. Reverse Array
// var rvrseArray = new[] { 1, 2, 3, 4, 5, 6, 7 };
// var originalArray = (int[])rvrseArray.Clone();
// int start = 0;
// int end = rvrseArray.Length - 1;

// Console.Write("Original Array Elements: ");
// Console.WriteLine(string.Join(", ", originalArray));

// while (start < end)
// {
//     int tmp = rvrseArray[start];
//     rvrseArray[start] = rvrseArray[end];
//     rvrseArray[end] = tmp;
//     start++;
//     end--;
// }

// Console.Write("Reversed Array Elements: ");
// Console.WriteLine(string.Join(", ", rvrseArray));

// 5. Search Element
// int[] arrayList = Array.Empty<int>();
// const int maxSize = 5;
// for (int i = 0; i < maxSize; i++)
// {
//     Console.Write($"Enter number {i + 1}: ");
//     int userInput = Convert.ToInt32(Console.ReadLine());
//     Array.Resize(ref arrayList, arrayList.Length + 1);
//     arrayList[i] = userInput;
// }
// Console.Write("Enter the element to search: ");
// int searchElement = Convert.ToInt32(Console.ReadLine());
// bool isFound = false;

// foreach (var item in arrayList)
// {
//     if (item == searchElement)
//     {
//         isFound = true;
//         Console.WriteLine($"Element {searchElement} found in the array at {Array.IndexOf(arrayList, item + 1)}.");
//         break;
//     }
//     else
//     {
//         isFound = false;
//         Console.WriteLine("Element not found in the array.");
//     }
// }

// C. CONDITIONALS
// 1. Odd or Even
// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.WriteLine($"The number {number} is Even.");
// }
// else
// {
//     Console.WriteLine($"The number {number} is Odd.");
// }

// 2. Largest of Three Numbers
// int[] numbers = Array.Empty<int>();
// int ctr = 0;
// const int maxCtr = 3;
// int number = 0;
// while (ctr < maxCtr)
// {
//     Console.Write($"Enter {ctr + 1} number: ");
//     number = Convert.ToInt32(Console.ReadLine());
//     Array.Resize(ref numbers, numbers.Length + 1);
//     numbers[ctr] = number;
//     ctr++;
// }
// Console.WriteLine($"The largest number among {string.Join(", ", numbers)} is: {numbers.Max()}");

// 3. Grade Evaluation
// double math, science, english, history, art = 0;
// double average = 0;

// for (int i = 1; i <= 5; i++)
// {
//     Console.Write($"Enter marks for subject {i}: ");
//     double marks = Convert.ToDouble(Console.ReadLine());
//     average += marks;
// }

// Console.WriteLine($"The average marks is: {average / 5}");

// if (average < 0 || average > 100)
// {
//     Console.WriteLine("Please enter valid marks between 0 and 100 for each subject.");
// }
// else if (average / 5 >= 90)
// {
//     Console.WriteLine("Grade: A");
// }
// else if (average / 5 >= 80)
// {
//     Console.WriteLine("Grade: B");
// }
// else if (average / 5 >= 70)
// {
//     Console.WriteLine("Grade: C");
// }
// else if (average / 5 >= 60)
// {
//     Console.WriteLine("Grade: D");
// }
// else
// {
//     Console.WriteLine("Grade: F");
// }

// 4. Leap Year
// int year = 0;
// Console.Write("Enter a year: ");
// year = Convert.ToInt32(Console.ReadLine());
// if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
// {
//     Console.WriteLine($"{year} is a leap year.");
// }
// else
// {
//     Console.WriteLine($"{year} is not a leap year.");
// }

// 5. Simple Calculator
// double num1, num2, total = 0;
// char operation;
// Console.Write("Enter first number: ");
// num1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Enter second number: ");
// num2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter an operator (+, -, *, /): ");
// operation = Console.ReadLine()[0];

// switch (operation)
// {
//     case '+':
//         total = num1 + num2;
//         Console.WriteLine($"{num1} + {num2} = {total}");
//         break;
//     case '-':
//         total = num1 - num2;
//         Console.WriteLine($"{num1} - {num2} = {total}");
//         break;
//     case '*':
//         total = num1 * num2;
//         Console.WriteLine($"{num1} * {num2} = {total}");
//         break;
//     case '/':
//         if (num2 != 0)
//         {
//             total = num1 / num2;
//             Console.WriteLine($"{num1} / {num2} = {total}");
//         }
//         else
//         {
//             Console.WriteLine("Error: Division by zero is not allowed.");
//         }
//         break;
//     default:
//         Console.WriteLine("Invalid operator. Please use one of the following: +, -, *, /");
//         break;
// }