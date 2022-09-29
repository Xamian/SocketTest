// See https://aka.ms/new-console-template for more information
using Common;
using Spectre.Console;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Game game = new(DebugHelper);

        static void DebugHelper(string text)
        {
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
                AnsiConsole.MarkupLine($"{text}");
            }
            AnsiConsole.MarkupLine("");
        }
        var userMode = AnsiConsole.Prompt<string>(new SelectionPrompt<string>()
            .Title("Choose Mode:")
            .HighlightStyle(Style.Parse("orange1"))
            .AddChoices("Host", "Client"));
        if (userMode == "Host")
        {
            _ = game.StartServerAsync();
        }
        else
        {
            _ = game.StartClientAsync();
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