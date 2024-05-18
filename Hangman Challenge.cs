using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace M_Project101
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int errorCtr = 0;
            int livesCtr = 3;
            bool gameOver = false;

            string[] words = {"Japan", "China", "Indonesia", "Vietnam",
                              "UK", "USA", "Philippines", "Israel"};

            Random rand = new Random();
            int randIndex = rand.Next(0, words.Length);
            string selectedWord = words[randIndex];
            string hiddenWord = new string('*', selectedWord.Length);

            Console.WriteLine("===> Hangman Challenge <===");
            Console.WriteLine($"Hidden word: {hiddenWord}");

            while (!gameOver && errorCtr < livesCtr)
            {
                Console.Write("Guess a letter >>> ");
                char letter = char.Parse(Console.ReadLine());

                if (selectedWord.Contains(letter))
                {
                    // Update hiddenWord with correctly guessed letters
                    for (int i = 0; i < selectedWord.Length; i++)
                    {
                        if (selectedWord[i] == letter)
                            hiddenWord = hiddenWord.Remove(i, 1).Insert(i, letter.ToString());
                        
                    }
                    Console.WriteLine($"Updated word: {hiddenWord}");
                }
                else
                {
                    errorCtr++;
                }

                // Check if the word is fully revealed
                if (hiddenWord == selectedWord)
                {
                    Console.WriteLine($"Congratulations! You guessed the word: {selectedWord}");
                    gameOver = true;
                }
            }

            if (!gameOver)
            {
                Console.WriteLine($"Game over! The word was: {selectedWord}");
            }
        }
    }
}