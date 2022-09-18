namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
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
                        gameEngine.runGame(Models.GameType.Addition);
                        break;
                    case "s":
                        gameEngine.runGame(Models.GameType.Subtraction);
                        break;
                    case "m":
                        gameEngine.runGame(Models.GameType.Multiplication);
                        break;
                    case "d":
                        gameEngine.runGame(Models.GameType.Division);
                        break;
                    case "q":
                        Console.WriteLine("Goodbye.");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            } while (isGameOn);

        }

    }
}
