// See https://aka.ms/new-console-template for more information
using Common;

Game game = new(DebugHelper);

static void DebugHelper(string text)
{
  Console.WriteLine(text + Environment.NewLine);
}


Console.WriteLine("Hello, World!");

Console.Write("(H)ost or (c)lient? ");
var k = Console.ReadKey();
bool isHost = k.KeyChar.ToString().ToUpper() == "H";
if (isHost)
{
  await game.StartServerAsync();
}
else
{
  await game.StartClientAsync();
}