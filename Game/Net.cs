using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{


  internal class Net
  {
    public NetworkStream Stream { get; }
    readonly byte[] buffer = new byte[4096];

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
