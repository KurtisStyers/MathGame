using MathGame;

Console.WriteLine("Please type your name");
string name = Console.ReadLine();

DateTime date = DateTime.UtcNow;

Menu menu = new Menu();
menu.ShowMenu(name, date);