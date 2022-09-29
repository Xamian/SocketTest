namespace Common
{
  public enum MessageType
  {
    Text,
    PlayedTurn,
    Result
  }
  public enum Result
  {
    Tied,
    HostWins,
    ClientWins,
  }
  public class MessageObject
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
