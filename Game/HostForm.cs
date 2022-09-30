namespace WinGame
{
  public partial class HostForm : Form
  {
    public string HostName;
    public HostForm()
    {
      InitializeComponent();
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.Handled = true;
        if (textBox1.TextLength == 0)
        {
          var result = MessageBox.Show("Please enter a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          if (result == DialogResult.OK)
          {
            textBox1.SelectAll();
            textBox1.Focus();
          }
        }
        else
        {
          this.DialogResult = DialogResult.OK;
          HostName = textBox1.Text;
          Close();
        }
      }
      else
      {
        e.Handled = false;
      }
    }
  }
}