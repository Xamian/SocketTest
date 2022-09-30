using System.Net;

namespace WinGame
{
  public partial class ClientForm : Form
  {
    public IPAddress ip;
    public string ClientName;
    public ClientForm()
    {
      InitializeComponent();
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Enter)
      {
        e.Handled = false;
        if (e.KeyChar == (char)Keys.Enter)
        {
          if(!IPAddress.TryParse(textBox1.Text, out ip))
          {
            var msgresult = MessageBox.Show("Invalid IP Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (msgresult == DialogResult.OK)
            {
              textBox1.SelectAll();
              textBox1.Focus();
            }
          }
          else
          {
            ClientName = textBox2.Text;
            this.DialogResult = DialogResult.OK;
            Close();
          }
        }
      }
      else
      {
        e.Handled = true;
      }
    }

    private void textBox2_KeyDown(object sender, KeyEventArgs e)
    {
      if(e.KeyCode == Keys.Enter)
      {
        e.Handled = true;
        if(textBox2.TextLength == 0)
        {
          var result = MessageBox.Show("Please enter a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          if(result == DialogResult.OK)
          {
            textBox2.Focus();
          }
        }
        else
        {
          textBox1.Focus();
        }
      }
      else
      {
        e.Handled = false;
      }
    }
  }
}
