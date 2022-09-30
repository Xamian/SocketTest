using Newtonsoft.Json;
using System.Net.Sockets;
using System.Text;

namespace Common
{
  public class Net
  {
    public NetworkStream Stream { get; }
    private readonly byte[] buffer = new byte[4096];

    public Net(NetworkStream stream)
    {
      Stream = stream;
    }

    public async Task SendAsync(MessageObject mobj)
    {
      string json = JsonConvert.SerializeObject(mobj);
      var bytes = Encoding.UTF8.GetBytes(json);
      await Stream.WriteAsync(bytes);
    }

    public async Task<MessageObject> ReceiveAsync()
    {
      int received = await Stream.ReadAsync(buffer);
      string json = Encoding.UTF8.GetString(buffer, 0, received);
      if (string.IsNullOrEmpty(json))
        throw new Exception("Empty string received");
      return JsonConvert.DeserializeObject<MessageObject>(json)!;
    }
  }
}