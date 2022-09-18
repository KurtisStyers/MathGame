using MathGame.Models;
using System;

namespace MathGame
{
    internal class GameEngine
    {
        internal void runGame(GameType type)
        {
            Random random = new Random();
            int[] numbers = new int[2];
            string result = "";
            int score = 0;
            char[] operators = { '+', '-', '*', '/' };

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine($"{type} game\n");

                if ((int)(type) < 3)
                {
                    numbers[0] = random.Next(1, 9);
                    numbers[1] = random.Next(1, 9);

                    Console.WriteLine($"{numbers[0]} {operators[(int)type]} {numbers[1]} = ?");
                    result = Console.ReadLine();
                    result = Helpers.ValidateResults(result);
                }
                
            }            
        }

        internal void AdditionGame()
        {
            Random random = new Random();
            int firstNum = 0;
            int secondNum = 0;
            string result = "";
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Addition game selected.");
                Console.Clear();
                firstNum = random.Next(1, 9);
                secondNum = random.Next(1, 9);

                Console.WriteLine($"{firstNum} + {secondNum} = ?");
                result = Console.ReadLine();
                result = Helpers.ValidateResults(result);

                if (int.Parse(result) == firstNum + secondNum)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("You have failed! Type any key for the next question");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }

        internal void SubtractionGame()
        {
            Random random = new Random();
            int firstNum = 0;
            int secondNum = 0;
            string result = "";
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subtraction game");
                Console.Clear();
                firstNum = random.Next(1, 9);
                secondNum = random.Next(1, 9);

                Console.WriteLine($"{firstNum} - {secondNum}");
                result = Console.ReadLine();
                result = Helpers.ValidateResults(result);

                if (int.Parse(result) == firstNum - secondNum)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("You have failed! Type any key for the next question");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }

        internal void MultiplicationGame()
        {
            Random random = new Random();
            int firstNum = 0;
            int secondNum = 0;
            string result = "";
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Multiplication game");
                Console.Clear();
                firstNum = random.Next(1, 9);
                secondNum = random.Next(1, 9);

                Console.WriteLine($"{firstNum} * {secondNum}");
                result = Console.ReadLine();
                result = Helpers.ValidateResults(result);

                if (int.Parse(result) == firstNum * secondNum)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("You have failed! Type any key for the next question");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }

        internal void DivisionGame()
        {
            int[] divisionNumbers = new int[2];
            string result = "";
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Division game");
                Console.Clear();
                divisionNumbers = Helpers.GetDivisionNumbers();

                Console.WriteLine($"{divisionNumbers[0]} / {divisionNumbers[1]}");
                result = Console.ReadLine();
                result = Helpers.ValidateResults(result);

                if (int.Parse(result) == divisionNumbers[0] / divisionNumbers[1])
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("You have failed! Type any key for the next question");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Division);
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
