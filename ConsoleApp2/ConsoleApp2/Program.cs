using OHCE;
using OHCE.Console;
using OHCE.ConsoleApp;

var ohce = new Ohce(new SystemLangProxy(), SystemTimePériodeJournéeAdapter.PériodeActuelle);

Console.WriteLine(ohce.Saluer());

Console.WriteLine(ohce.Inviter());

Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));