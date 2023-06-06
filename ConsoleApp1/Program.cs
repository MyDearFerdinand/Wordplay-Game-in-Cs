using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();

        List<string> words = new List<string>() { "apple", "banana", "cherry", "watermelon", "orange" };

        Random rand = new Random();
        string chosenWord = words[rand.Next(0, words.Count)];

        Console.WriteLine("Welcome to Word Guess Game!");
        Console.WriteLine("I have chosen a fruit name. It has " + chosenWord.Length + " letters. Can you guess it?");

        string guessedWord = new string('_', chosenWord.Length);
        while (guessedWord.Contains('_'))
        {
            Console.WriteLine(guessedWord);
            Console.WriteLine("Enter a letter:");
            char letter = Convert.ToChar(Console.ReadLine());
            if (char.IsLetter(letter))
            {
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (chosenWord[i] == letter)
                    {
                        guessedWord = guessedWord.Remove(i, 1);
                        guessedWord = guessedWord.Insert(i, letter.ToString());
                    }
                }

                if (!chosenWord.Contains(letter))
                {
                    Console.WriteLine("No, the word doesn't contain the letter " + letter);
                }
                }
            else { Console.WriteLine("Type only one letter per move"); }
        }

        Console.WriteLine(guessedWord);
        Console.WriteLine("Congratulations! You've guessed the word!");
    }
}