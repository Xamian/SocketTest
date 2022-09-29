// See https://aka.ms/new-console-template for more information
using Common;

Game game = new(DebugHelper);

static void DebugHelper(string text)
{
  Console.WriteLine(text + Environment.NewLine);
}

Console.Write("(H)ost or (c)lient? ");
var k = Console.ReadKey();
bool isHost = k.KeyChar.ToString().ToUpper() == "H";
if (isHost)
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
    Console.WriteLine("Choose one:");
    Console.WriteLine("(S)tone, S(c)issors, (P)aper?");
    var key = Console.ReadKey().KeyChar.ToString().ToLower();
    switch (key)
    {
      case "s": playerSelected = Weapon.Stone; break;
      case "c": playerSelected = Weapon.Scissors; break;
      case "p": playerSelected = Weapon.Paper; break;
    }
  }
  game.PlayerSelected(playerSelected);
  var OpponentSelected = await game.GetOpponentSelectionAsync();
}
