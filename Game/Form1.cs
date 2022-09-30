using Common;
using System.Net;
using WinGame;

namespace SocketTest
{
  public partial class Form1 : Form
  {
    private Game game;

    int hostCounter = 0;
    int clientCounter = 0;

    private void DebugHelper(string text)
    {
      if (text.Contains("Trying to connect") || text.Contains("Waiting for connection from client"))
      {
        SetActionLabelTextAndColor(Color.White, text);
      }
      else if (text == "Failed to connect!" || text == "No connection could be made because the target machine actively refused it.")
      {
        ShowHostConBtns();
        EnableDisableButtons();
        SetActionLabelTextAndColor(Color.Red, text);
      }
      else if (text == "Connected to Host" || text == " connected...")
      {
        HideHostConBtns();
        EnableDisableButtons(true);
        SetActionLabelTextAndColor(Color.Green, text);
      }
      else if (text == "tied, try again." || text == "We tied, try again.")
      {
        SetActionLabelTextAndColor(Color.Wheat, "DRAW");
      }
      else if (text == $"{game.ClientName} lose!" || text == $"{game.HostName} lose!")
      {
        if(text == $"{game.ClientName} lose!")
        {
          hostCounter++;
        }
        if (text == $"{game.HostName} lose!")
        {
          clientCounter++;
        }
        HostPoint.Text = hostCounter.ToString();
        ClientPoint.Text = clientCounter.ToString();
        SetActionLabelTextAndColor(Color.Red, "LOSER");
      }
      else if (text == $"{game.ClientName} win!" || text == $"{game.HostName} win!")
      {
        if (text == $"{game.ClientName} win!")
        {
          clientCounter++;
        }
        if (text == $"{game.HostName} win!")
        {
          hostCounter++;
        }
        HostPoint.Text = hostCounter.ToString();
        ClientPoint.Text = clientCounter.ToString();
        SetActionLabelTextAndColor(Color.Green, "WINNER WINNER CHICKEN DINNER");
      }
      else
      {
        Console.WriteLine(text);
      }
      textBox1.AppendText(text + Environment.NewLine);
    }

    public Form1()
    {
      InitializeComponent();
      game = new(DebugHelper);
    }

    private void btnHost_Click(object sender, EventArgs e)
    {
      HostForm hostForm = new HostForm();
      var result = hostForm.ShowDialog();
      if(result == DialogResult.OK)
      {
        game.HostName = hostForm.HostName;
        HostLabel.Text = game.HostName;
        _ = StartServerAsync();
      }
    }

    private void btnClient_Click(object sender, EventArgs e)
    {
      ClientForm clientForm = new ClientForm();
      var result = clientForm.ShowDialog();
      if (result == DialogResult.OK)
      {
        game.ClientName = clientForm.ClientName;
        ClientLabel.Text = game.ClientName;
        _ = StartClientAsync(clientForm.ip);
      }
    }

    private async Task StartServerAsync()
    {
      HideHostConBtns();
      await game.StartServerAsync();
      ShowHostConBtns();
    }

    private async Task StartClientAsync(IPAddress ip)
    {
      HideHostConBtns();
      await game.StartClientAsync(ip);
      ShowHostConBtns();
    }

    private void btnStone_Click(object sender, EventArgs e)
    {
      HostLabel.Text = game.HostName;
      ClientLabel.Text = game.ClientName;
      game.PlayerSelected(Weapon.Stone);
    }

    private void btnScissors_Click(object sender, EventArgs e)
    {
      HostLabel.Text = game.HostName;
      ClientLabel.Text = game.ClientName;
      game.PlayerSelected(Weapon.Scissors);
    }

    private void btnPaper_Click(object sender, EventArgs e)
    {
      HostLabel.Text = game.HostName;
      ClientLabel.Text = game.ClientName;
      game.PlayerSelected(Weapon.Paper);
    }

    private void EnableDisableButtons(bool enable = false)
    {
      btnStone.Enabled = enable;
      btnScissors.Enabled = enable;
      btnPaper.Enabled = enable;
    }

    private void HideHostConBtns()
    {
      btnHost.Visible = false;
      btnClient.Visible = false;
      HostLabel.Visible = true;
      HostPoint.Visible = true;
      ClientLabel.Visible = true;
      ClientPoint.Visible = true;
      if (textBox1.Visible)
      {
        actionLabel.Visible = false;
        this.Size = new Size(930, 606);
      }
      else
      {
        actionLabel.Visible = true;
        this.Size = new Size(930, 433);
      }
    }

    private void ShowHostConBtns()
    {
      btnHost.Visible = true;
      btnClient.Visible = true;
      HostLabel.Visible = false;
      HostPoint.Visible = false;
      ClientLabel.Visible = false;
      ClientPoint.Visible = false;
      if (textBox1.Visible)
      {
        actionLabel.Visible = false;
        this.Size = new Size(930, 606);
      }
      else
      {
        actionLabel.Visible = true;
        this.Size = new Size(930, 433);
      }
    }

    private void showlogmenuitem_Click(object sender, EventArgs e)
    {
      textBox1.Location = new Point(5, 286);
      textBox1.Size = new Size(904, 276);
      groupBox1.Location = new Point(5, 81);
      this.Size = new Size(930, 606);
      actionLabel.Visible = false;
      textBox1.Visible = true;
      showlogmenuitem.Visible = false;
      hidelogmenuitem.Visible = true;
    }

    private void hidelogmenuitem_Click(object sender, EventArgs e)
    {
      textBox1.Location = new Point(5, 286);
      textBox1.Size = new Size(904, 276);
      this.Size = new Size(930, 433);
      groupBox1.Location = new Point(5, 81);
      actionLabel.Location = new Point(5, 286);
      actionLabel.Visible = true;
      textBox1.Visible = false;
      showlogmenuitem.Visible = true;
      hidelogmenuitem.Visible = false;
    }

    private void SetActionLabelTextAndColor(Color color, string text)
    {
      actionLabel.ForeColor = color;
      actionLabel.Text = text;
    }
  }
}