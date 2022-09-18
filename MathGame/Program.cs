using MathGame;

string name = Helpers.getName();

DateTime date = DateTime.UtcNow;

Menu menu = new Menu();
menu.ShowMenu(name, date);