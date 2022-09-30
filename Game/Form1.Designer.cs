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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btnHost = new System.Windows.Forms.Button();
      this.btnClient = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnPaper = new System.Windows.Forms.Button();
      this.btnScissors = new System.Windows.Forms.Button();
      this.btnStone = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.showlogmenuitem = new System.Windows.Forms.ToolStripMenuItem();
      this.hidelogmenuitem = new System.Windows.Forms.ToolStripMenuItem();
      this.actionLabel = new System.Windows.Forms.Label();
      this.HostLabel = new System.Windows.Forms.Label();
      this.HostPoint = new System.Windows.Forms.Label();
      this.ClientPoint = new System.Windows.Forms.Label();
      this.ClientLabel = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnHost
      // 
      this.btnHost.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnHost.FlatAppearance.BorderColor = System.Drawing.Color.Red;
      this.btnHost.FlatAppearance.BorderSize = 2;
      this.btnHost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
      this.btnHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnHost.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnHost.ForeColor = System.Drawing.Color.White;
      this.btnHost.Location = new System.Drawing.Point(5, 29);
      this.btnHost.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
      this.btnHost.Name = "btnHost";
      this.btnHost.Size = new System.Drawing.Size(425, 47);
      this.btnHost.TabIndex = 0;
      this.btnHost.Text = "Host";
      this.btnHost.UseVisualStyleBackColor = true;
      this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
      // 
      // btnClient
      // 
      this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClient.FlatAppearance.BorderColor = System.Drawing.Color.Green;
      this.btnClient.FlatAppearance.BorderSize = 2;
      this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
      this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClient.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.btnClient.ForeColor = System.Drawing.Color.White;
      this.btnClient.Location = new System.Drawing.Point(435, 29);
      this.btnClient.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
      this.btnClient.Name = "btnClient";
      this.btnClient.Size = new System.Drawing.Size(474, 47);
      this.btnClient.TabIndex = 1;
      this.btnClient.Text = "Client";
      this.btnClient.UseVisualStyleBackColor = true;
      this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.Black;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.ForeColor = System.Drawing.Color.DarkOrange;
      this.textBox1.Location = new System.Drawing.Point(5, 286);
      this.textBox1.Margin = new System.Windows.Forms.Padding(0);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(904, 276);
      this.textBox1.TabIndex = 2;
      this.textBox1.Visible = false;
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.Transparent;
      this.groupBox1.Controls.Add(this.btnPaper);
      this.groupBox1.Controls.Add(this.btnScissors);
      this.groupBox1.Controls.Add(this.btnStone);
      this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
      this.groupBox1.Location = new System.Drawing.Point(5, 81);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
      this.groupBox1.Size = new System.Drawing.Size(904, 200);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Actions";
      // 
      // btnPaper
      // 
      this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPaper.Enabled = false;
      this.btnPaper.FlatAppearance.BorderSize = 0;
      this.btnPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPaper.Image = global::WinGame.Properties.Resources.document_icon;
      this.btnPaper.Location = new System.Drawing.Point(308, 25);
      this.btnPaper.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
      this.btnPaper.Name = "btnPaper";
      this.btnPaper.Size = new System.Drawing.Size(293, 165);
      this.btnPaper.TabIndex = 8;
      this.btnPaper.UseVisualStyleBackColor = true;
      this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
      // 
      // btnScissors
      // 
      this.btnScissors.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnScissors.Enabled = false;
      this.btnScissors.FlatAppearance.BorderSize = 0;
      this.btnScissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnScissors.Image = global::WinGame.Properties.Resources.Scissors_icon;
      this.btnScissors.Location = new System.Drawing.Point(606, 25);
      this.btnScissors.Margin = new System.Windows.Forms.Padding(0);
      this.btnScissors.Name = "btnScissors";
      this.btnScissors.Size = new System.Drawing.Size(293, 165);
      this.btnScissors.TabIndex = 7;
      this.btnScissors.UseVisualStyleBackColor = true;
      this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
      // 
      // btnStone
      // 
      this.btnStone.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnStone.Enabled = false;
      this.btnStone.FlatAppearance.BorderSize = 0;
      this.btnStone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.btnStone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStone.Image = global::WinGame.Properties.Resources.Philosophers_Stone_2_icon;
      this.btnStone.Location = new System.Drawing.Point(5, 25);
      this.btnStone.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
      this.btnStone.Name = "btnStone";
      this.btnStone.Size = new System.Drawing.Size(298, 165);
      this.btnStone.TabIndex = 6;
      this.btnStone.UseVisualStyleBackColor = true;
      this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showlogmenuitem,
            this.hidelogmenuitem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(914, 24);
      this.menuStrip1.TabIndex = 7;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // showlogmenuitem
      // 
      this.showlogmenuitem.ForeColor = System.Drawing.Color.Black;
      this.showlogmenuitem.Name = "showlogmenuitem";
      this.showlogmenuitem.Size = new System.Drawing.Size(71, 20);
      this.showlogmenuitem.Text = "Show Log";
      this.showlogmenuitem.Click += new System.EventHandler(this.showlogmenuitem_Click);
      // 
      // hidelogmenuitem
      // 
      this.hidelogmenuitem.ForeColor = System.Drawing.Color.Black;
      this.hidelogmenuitem.Name = "hidelogmenuitem";
      this.hidelogmenuitem.Size = new System.Drawing.Size(67, 20);
      this.hidelogmenuitem.Text = "Hide Log";
      this.hidelogmenuitem.Visible = false;
      this.hidelogmenuitem.Click += new System.EventHandler(this.hidelogmenuitem_Click);
      // 
      // actionLabel
      // 
      this.actionLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.actionLabel.ForeColor = System.Drawing.Color.White;
      this.actionLabel.Location = new System.Drawing.Point(5, 286);
      this.actionLabel.Margin = new System.Windows.Forms.Padding(0);
      this.actionLabel.Name = "actionLabel";
      this.actionLabel.Size = new System.Drawing.Size(904, 100);
      this.actionLabel.TabIndex = 8;
      this.actionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // HostLabel
      // 
      this.HostLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.HostLabel.Location = new System.Drawing.Point(5, 29);
      this.HostLabel.Margin = new System.Windows.Forms.Padding(0);
      this.HostLabel.Name = "HostLabel";
      this.HostLabel.Size = new System.Drawing.Size(425, 23);
      this.HostLabel.TabIndex = 9;
      this.HostLabel.Text = "Host";
      this.HostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.HostLabel.Visible = false;
      // 
      // HostPoint
      // 
      this.HostPoint.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.HostPoint.ForeColor = System.Drawing.Color.Red;
      this.HostPoint.Location = new System.Drawing.Point(5, 52);
      this.HostPoint.Margin = new System.Windows.Forms.Padding(0);
      this.HostPoint.Name = "HostPoint";
      this.HostPoint.Size = new System.Drawing.Size(425, 24);
      this.HostPoint.TabIndex = 10;
      this.HostPoint.Text = "0";
      this.HostPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.HostPoint.Visible = false;
      // 
      // ClientPoint
      // 
      this.ClientPoint.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.ClientPoint.ForeColor = System.Drawing.Color.Green;
      this.ClientPoint.Location = new System.Drawing.Point(435, 52);
      this.ClientPoint.Margin = new System.Windows.Forms.Padding(0);
      this.ClientPoint.Name = "ClientPoint";
      this.ClientPoint.Size = new System.Drawing.Size(474, 24);
      this.ClientPoint.TabIndex = 12;
      this.ClientPoint.Text = "0";
      this.ClientPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.ClientPoint.Visible = false;
      // 
      // ClientLabel
      // 
      this.ClientLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.ClientLabel.Location = new System.Drawing.Point(435, 29);
      this.ClientLabel.Margin = new System.Windows.Forms.Padding(0);
      this.ClientLabel.Name = "ClientLabel";
      this.ClientLabel.Size = new System.Drawing.Size(474, 23);
      this.ClientLabel.TabIndex = 11;
      this.ClientLabel.Text = "Client";
      this.ClientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.ClientLabel.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(914, 394);
      this.Controls.Add(this.ClientPoint);
      this.Controls.Add(this.ClientLabel);
      this.Controls.Add(this.HostPoint);
      this.Controls.Add(this.HostLabel);
      this.Controls.Add(this.actionLabel);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btnClient);
      this.Controls.Add(this.btnHost);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RPS 1.0";
      this.groupBox1.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem showlogmenuitem;
        private Label actionLabel;
        private ToolStripMenuItem hidelogmenuitem;
        private Label HostLabel;
        private Label HostPoint;
        private Label ClientPoint;
        private Label ClientLabel;
    }
}