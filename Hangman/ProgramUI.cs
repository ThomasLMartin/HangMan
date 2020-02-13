using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class ProgramUI
    {
        public void Run()
        {
            bool gameIsRunning = true;
            while (gameIsRunning == true)
            {
                RunMenu();
                Console.Clear();
            }
        }
        private void RunMenu()
        {
            Console.WriteLine("Greetings! Welcome to HangMan!");


            string[] word = new string[5];
            word[0] = "earth";
            word[1] = "fire";
            word[2] = "water";
            word[3] = "wind";
            word[4] = "planet";

            Console.WriteLine("Choose a number, and we'll pick a word to guess");
            string wordChoice = " ";
            char[] guess = new char[0];`
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    wordChoice = word[0];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    Console.WriteLine(guess);
                    break;
                case "1":
                    wordChoice = word[1];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    Console.WriteLine(guess);
                    break;
                case "2":
                    wordChoice = word[2];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    Console.WriteLine(guess);
                    break;
                case "3":
                    wordChoice = word[3];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    Console.WriteLine(guess);
                    break;
                case "4":
                    wordChoice = word[4];
                    guess = new char[wordChoice.Length];
                    for (int p = 0; p < wordChoice.Length; p++)
                        guess[p] = '*';
                    Console.WriteLine(guess);
                    Console.WriteLine("Now guess your letters!");
                    Console.WriteLine(guess);
                    break;
            }
            while (new string (guess) != wordChoice)
            {
                string userLetter = Console.ReadLine();
                bool letterGuessCorrect = wordChoice.Contains(userLetter);

                if (letterGuessCorrect)
                {
                    Console.WriteLine("Great! Keep Going!");

                    for (int i = 0; i < wordChoice.Length; i++)
                    {
                        if (wordChoice[i].ToString() == userLetter)
                        {
                            char[] newArray = userLetter.ToCharArray();
                            guess[i] = userLetter[0];
                            Console.WriteLine(guess);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong! Try Again!");
                }
            }
            char[] wordChoiceArray = wordChoice.ToCharArray();

        }
    }
}
