using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new();

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-----------------------");
            foreach (Game data in games)
            {
                Console.WriteLine($"{data.Date} - {data.Type}: {data.Score}pts");
            }

            Console.WriteLine("-----------------------\n");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
            Console.Clear();
        }

        internal static int[] GetDivisionNumbers()
        {
            Random random = new Random();
            int firstNum = random.Next(0, 99);
            int secondNum = random.Next(1, 99);

            int[] result = new int[2];

            while (firstNum % secondNum != 0)
            {
                firstNum = random.Next(0, 99);
                secondNum = random.Next(1, 99);
            }

            result[0] = firstNum;
            result[1] = secondNum;

            return result;
        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

        internal static string? ValidateResults(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }

            return result;
        }
    }
}
