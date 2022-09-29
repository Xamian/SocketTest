namespace Game
{
  internal enum MessageType
  {
    Text,
    PlayedTurn,
    Result
  }
  internal enum Result
  {
    Tied,
    HostWins,
    ClientWins,
  }
  internal class MessageObject
  {
    public MessageObject() { }
    public MessageObject(string message)
    {
      Message = message;
    }

    public MessageType MessageType { get; set; }
    public string? Message { get; set; }
    public Weapon SelectedWeapon { get; set; }
    public Result Result { get; set; }
  }
}
