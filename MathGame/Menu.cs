namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}.");

            bool isGameOn = true;
            do
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("What game would you like to play today?\n" +
                                    "Choose from the options below:\n\n" +
                                    "V - View Previous Games\n" +
                                    "A - Addition\n" +
                                    "S - Subtraction\n" +
                                    "M - Multiplication\n" +
                                    "D - Division\n" +
                                    "Q - Quit the program\n");
                Console.WriteLine("--------------------------------------");

                string gameSelected = Console.ReadLine().Trim().ToLower();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame();
                        break;
                    case "s":
                        gameEngine.SubtractionGame();
                        break;
                    case "m":
                        gameEngine.MultiplicationGame();
                        break;
                    case "d":
                        gameEngine.DivisionGame();
                        break;
                    case "q":
                        Console.WriteLine("Goodbye.");
                        isGameOn = false;
                        break;
                    case "x":
                        gameEngine.runGame(Models.GameType.Addition);
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while (isGameOn);

        }

    }
}
