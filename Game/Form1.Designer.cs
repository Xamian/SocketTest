namespace SocketTest
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnHost = new System.Windows.Forms.Button();
      this.btnClient = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnPaper = new System.Windows.Forms.Button();
      this.btnScissors = new System.Windows.Forms.Button();
      this.btnStone = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnHost
      // 
      this.btnHost.Location = new System.Drawing.Point(12, 12);
      this.btnHost.Name = "btnHost";
      this.btnHost.Size = new System.Drawing.Size(75, 23);
      this.btnHost.TabIndex = 0;
      this.btnHost.Text = "Host";
      this.btnHost.UseVisualStyleBackColor = true;
      this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
      // 
      // btnClient
      // 
      this.btnClient.Location = new System.Drawing.Point(93, 12);
      this.btnClient.Name = "btnClient";
      this.btnClient.Size = new System.Drawing.Size(75, 23);
      this.btnClient.TabIndex = 1;
      this.btnClient.Text = "Client";
      this.btnClient.UseVisualStyleBackColor = true;
      this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 244);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(776, 194);
      this.textBox1.TabIndex = 2;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnPaper);
      this.groupBox1.Controls.Add(this.btnScissors);
      this.groupBox1.Controls.Add(this.btnStone);
      this.groupBox1.Location = new System.Drawing.Point(12, 66);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(249, 59);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // btnPaper
      // 
      this.btnPaper.Location = new System.Drawing.Point(168, 22);
      this.btnPaper.Name = "btnPaper";
      this.btnPaper.Size = new System.Drawing.Size(75, 23);
      this.btnPaper.TabIndex = 8;
      this.btnPaper.Text = "Paper";
      this.btnPaper.UseVisualStyleBackColor = true;
      this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
      // 
      // btnScissors
      // 
      this.btnScissors.Location = new System.Drawing.Point(87, 22);
      this.btnScissors.Name = "btnScissors";
      this.btnScissors.Size = new System.Drawing.Size(75, 23);
      this.btnScissors.TabIndex = 7;
      this.btnScissors.Text = "Scissors";
      this.btnScissors.UseVisualStyleBackColor = true;
      this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
      // 
      // btnStone
      // 
      this.btnStone.Location = new System.Drawing.Point(6, 22);
      this.btnStone.Name = "btnStone";
      this.btnStone.Size = new System.Drawing.Size(75, 23);
      this.btnStone.TabIndex = 6;
      this.btnStone.Text = "Sten";
      this.btnStone.UseVisualStyleBackColor = true;
      this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btnClient);
      this.Controls.Add(this.btnHost);
      this.Name = "Form1";
      this.Text = "Form1";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private Button btnHost;
        private Button btnClient;
    private TextBox textBox1;
        private GroupBox groupBox1;
        private Button btnPaper;
        private Button btnScissors;
        private Button btnStone;
    }
}