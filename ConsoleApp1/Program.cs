// See https://aka.ms/new-console-template for more information
using Common;
using Spectre.Console;
using System.Net;

internal class Program
{
  private static async Task Main(string[] args)
  {
    Game game = new(DebugHelper);

    Console.Clear();

    static void DebugHelper(string text)
    {
      Console.WriteLine();
      if (text == "You lose!" || text == "We lose!")
      {
        AnsiConsole.MarkupLine($"[red1]{text}[/]");
      }
      else if (text == "You win!" || text == "We win!")
      {
        AnsiConsole.MarkupLine($"[green3]{text}[/]");
      }
      else
      {
        Console.WriteLine($"{text}");
      }
      Console.WriteLine();
    }
    var userMode = AnsiConsole.Prompt<string>(new SelectionPrompt<string>()
        .Title("Choose Mode:")
        .HighlightStyle(Style.Parse("orange1"))
        .AddChoices("Host", "Client"));
    Console.WriteLine();
    if (userMode == "Host")
    {
      _ = game.StartServerAsync();
    }
    else
    {
      IPAddress ip = IPAddress.Parse("127.0.0.1");
      _ = game.StartClientAsync(ip);
    }
    while (true)
    {
      Weapon playerSelected = Weapon.None;
      while (playerSelected == Weapon.None)
      {
        var userSelect = AnsiConsole.Prompt<string>(new SelectionPrompt<string>()
            .Title("Choose one:")
            .HighlightStyle(Style.Parse("orange1"))
            .AddChoices("Stone", "Scissors", "Paper"));
        switch (userSelect)
        {
          case "Stone": playerSelected = Weapon.Stone; break;
          case "Scissors": playerSelected = Weapon.Scissors; break;
          case "Paper": playerSelected = Weapon.Paper; break;
        }
      }
      game.PlayerSelected(playerSelected);
      var OpponentSelected = await game.GetOpponentSelectionAsync();
    }
  }
}