namespace Client1
{
	partial class Form1
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
			if(disposing && (components != null))
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
			this.txtOntvangen = new System.Windows.Forms.TextBox();
			this.txtServerAdres = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnInloggen = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtGebruiker = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtWachtwoord = new System.Windows.Forms.TextBox();
			this.btnRegistreren = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnUitloggen = new System.Windows.Forms.Button();
			this.btnVerbind = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnStartChat = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtOntvangen
			// 
			this.txtOntvangen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOntvangen.BackColor = System.Drawing.SystemColors.Window;
			this.txtOntvangen.Location = new System.Drawing.Point(12, 158);
			this.txtOntvangen.Multiline = true;
			this.txtOntvangen.Name = "txtOntvangen";
			this.txtOntvangen.ReadOnly = true;
			this.txtOntvangen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOntvangen.Size = new System.Drawing.Size(373, 141);
			this.txtOntvangen.TabIndex = 0;
			this.txtOntvangen.WordWrap = false;
			// 
			// txtServerAdres
			// 
			this.txtServerAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtServerAdres.Enabled = false;
			this.txtServerAdres.Location = new System.Drawing.Point(105, 12);
			this.txtServerAdres.Name = "txtServerAdres";
			this.txtServerAdres.Size = new System.Drawing.Size(280, 20);
			this.txtServerAdres.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Server adres: ";
			// 
			// btnInloggen
			// 
			this.btnInloggen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnInloggen.Enabled = false;
			this.btnInloggen.Location = new System.Drawing.Point(127, 3);
			this.btnInloggen.Name = "btnInloggen";
			this.btnInloggen.Size = new System.Drawing.Size(118, 25);
			this.btnInloggen.TabIndex = 3;
			this.btnInloggen.Text = "Inloggen";
			this.btnInloggen.UseVisualStyleBackColor = true;
			this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Gebruikersnaam:";
			// 
			// txtGebruiker
			// 
			this.txtGebruiker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGebruiker.Location = new System.Drawing.Point(105, 69);
			this.txtGebruiker.Name = "txtGebruiker";
			this.txtGebruiker.Size = new System.Drawing.Size(280, 20);
			this.txtGebruiker.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Wachtwoord:";
			// 
			// txtWachtwoord
			// 
			this.txtWachtwoord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtWachtwoord.Location = new System.Drawing.Point(105, 95);
			this.txtWachtwoord.Name = "txtWachtwoord";
			this.txtWachtwoord.Size = new System.Drawing.Size(280, 20);
			this.txtWachtwoord.TabIndex = 8;
			this.txtWachtwoord.UseSystemPasswordChar = true;
			// 
			// btnRegistreren
			// 
			this.btnRegistreren.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRegistreren.Enabled = false;
			this.btnRegistreren.Location = new System.Drawing.Point(3, 3);
			this.btnRegistreren.Name = "btnRegistreren";
			this.btnRegistreren.Size = new System.Drawing.Size(118, 25);
			this.btnRegistreren.TabIndex = 10;
			this.btnRegistreren.Text = "Registreren";
			this.btnRegistreren.UseVisualStyleBackColor = true;
			this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.btnUitloggen, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnRegistreren, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnInloggen, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 121);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 31);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// btnUitloggen
			// 
			this.btnUitloggen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUitloggen.Enabled = false;
			this.btnUitloggen.Location = new System.Drawing.Point(251, 3);
			this.btnUitloggen.Name = "btnUitloggen";
			this.btnUitloggen.Size = new System.Drawing.Size(119, 25);
			this.btnUitloggen.TabIndex = 11;
			this.btnUitloggen.Text = "Uitloggen";
			this.btnUitloggen.UseVisualStyleBackColor = true;
			this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
			// 
			// btnVerbind
			// 
			this.btnVerbind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnVerbind.Location = new System.Drawing.Point(105, 38);
			this.btnVerbind.Name = "btnVerbind";
			this.btnVerbind.Size = new System.Drawing.Size(280, 25);
			this.btnVerbind.TabIndex = 12;
			this.btnVerbind.Text = "Verbind";
			this.btnVerbind.UseVisualStyleBackColor = true;
			this.btnVerbind.Click += new System.EventHandler(this.btnVerbind_Click);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.Location = new System.Drawing.Point(392, 31);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(180, 239);
			this.listBox1.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(395, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Online gebruikers:";
			// 
			// btnStartChat
			// 
			this.btnStartChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStartChat.Location = new System.Drawing.Point(392, 276);
			this.btnStartChat.Name = "btnStartChat";
			this.btnStartChat.Size = new System.Drawing.Size(180, 23);
			this.btnStartChat.TabIndex = 15;
			this.btnStartChat.Text = "Start chat";
			this.btnStartChat.UseVisualStyleBackColor = true;
			this.btnStartChat.Click += new System.EventHandler(this.btnStartChat_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 311);
			this.Controls.Add(this.btnStartChat);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.btnVerbind);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtWachtwoord);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtGebruiker);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtServerAdres);
			this.Controls.Add(this.txtOntvangen);
			this.Location = new System.Drawing.Point(50, 400);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Client 1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtOntvangen;
		private System.Windows.Forms.TextBox txtServerAdres;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnInloggen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGebruiker;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtWachtwoord;
		private System.Windows.Forms.Button btnRegistreren;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnVerbind;
		private System.Windows.Forms.Button btnUitloggen;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnStartChat;
	}
}

