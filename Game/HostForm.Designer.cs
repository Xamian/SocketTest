namespace WinGame
{
  partial class HostForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.DimGray;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.textBox1.ForeColor = System.Drawing.Color.Orange;
      this.textBox1.Location = new System.Drawing.Point(5, 58);
      this.textBox1.Margin = new System.Windows.Forms.Padding(0);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(512, 31);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
      // 
      // label2
      // 
      this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(5, 9);
      this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(512, 44);
      this.label2.TabIndex = 4;
      this.label2.Text = "Your Name";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // HostForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(522, 98);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label2);
      this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "HostForm";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Host";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private TextBox textBox1;
        private Label label2;
    }
}