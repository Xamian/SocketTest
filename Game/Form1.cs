using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Common;

namespace SocketTest
{
  public partial class Form1 : Form
  {
    private Game game;
    private void DebugHelper(string text)
    {
      Console.WriteLine(text);
      textBox1.AppendText(text + Environment.NewLine);
    }
    public Form1()
    {
      InitializeComponent();
      game = new(DebugHelper);
    }

    private void btnHost_Click(object sender, EventArgs e)
    {
      _ = StartServerAsync();
    }
    private void btnClient_Click(object sender, EventArgs e)
    {
      _ = StartClientAsync();
    }

    private async Task StartServerAsync()
    {
      btnHost.Enabled = false;
      btnClient.Enabled = false;
      await game.StartServerAsync();
      btnHost.Enabled = true;
      btnClient.Enabled = true;
    }
    private async Task StartClientAsync()
    {
      btnHost.Enabled = false;
      btnClient.Enabled = false;
      await game.StartClientAsync();
      btnHost.Enabled = true;
      btnClient.Enabled = true;
    }

    private void btnStone_Click(object sender, EventArgs e)
    {
      game.PlayerSelected(Weapon.Stone);
    }

    private void btnScissors_Click(object sender, EventArgs e)
    {
      game.PlayerSelected(Weapon.Scissors);
    }

    private void btnPaper_Click(object sender, EventArgs e)
    {
      game.PlayerSelected(Weapon.Paper);
    }
  }
}