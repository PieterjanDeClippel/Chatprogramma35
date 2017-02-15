namespace Server
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
			this.btnStartServer = new System.Windows.Forms.Button();
			this.txtServerAdres = new System.Windows.Forms.TextBox();
			this.txtOntvangen = new System.Windows.Forms.TextBox();
			this.lstGebruikers = new System.Windows.Forms.ListBox();
			this.ChatDatabase = new System.Data.DataSet();
			this.tblGebruikers = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.clmGebruikersnaam = new System.Data.DataColumn();
			this.clmWachtwoord = new System.Data.DataColumn();
			this.tblBerichten = new System.Data.DataTable();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
			this.dataColumn4 = new System.Data.DataColumn();
			this.dataColumn5 = new System.Data.DataColumn();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnStopServer = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ChatDatabase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblGebruikers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblBerichten)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStartServer
			// 
			this.btnStartServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStartServer.Location = new System.Drawing.Point(12, 35);
			this.btnStartServer.Name = "btnStartServer";
			this.btnStartServer.Size = new System.Drawing.Size(560, 25);
			this.btnStartServer.TabIndex = 11;
			this.btnStartServer.Text = "Start de server";
			this.btnStartServer.UseVisualStyleBackColor = true;
			this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
			// 
			// txtServerAdres
			// 
			this.txtServerAdres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtServerAdres.Location = new System.Drawing.Point(12, 9);
			this.txtServerAdres.Name = "txtServerAdres";
			this.txtServerAdres.Size = new System.Drawing.Size(560, 20);
			this.txtServerAdres.TabIndex = 9;
			// 
			// txtOntvangen
			// 
			this.txtOntvangen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOntvangen.BackColor = System.Drawing.SystemColors.Window;
			this.txtOntvangen.Location = new System.Drawing.Point(283, 3);
			this.txtOntvangen.Multiline = true;
			this.txtOntvangen.Name = "txtOntvangen";
			this.txtOntvangen.ReadOnly = true;
			this.txtOntvangen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOntvangen.Size = new System.Drawing.Size(274, 95);
			this.txtOntvangen.TabIndex = 8;
			this.txtOntvangen.WordWrap = false;
			// 
			// lstGebruikers
			// 
			this.lstGebruikers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstGebruikers.FormattingEnabled = true;
			this.lstGebruikers.IntegralHeight = false;
			this.lstGebruikers.Location = new System.Drawing.Point(3, 3);
			this.lstGebruikers.Name = "lstGebruikers";
			this.lstGebruikers.Size = new System.Drawing.Size(274, 95);
			this.lstGebruikers.TabIndex = 0;
			// 
			// ChatDatabase
			// 
			this.ChatDatabase.DataSetName = "ChatDatabase";
			this.ChatDatabase.Tables.AddRange(new System.Data.DataTable[] {
            this.tblGebruikers,
            this.tblBerichten});
			// 
			// tblGebruikers
			// 
			this.tblGebruikers.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.clmGebruikersnaam,
            this.clmWachtwoord});
			this.tblGebruikers.Locale = new System.Globalization.CultureInfo("nl-BE");
			this.tblGebruikers.TableName = "Gebruikers";
			// 
			// dataColumn1
			// 
			this.dataColumn1.AutoIncrement = true;
			this.dataColumn1.ColumnName = "id";
			this.dataColumn1.DataType = typeof(int);
			// 
			// clmGebruikersnaam
			// 
			this.clmGebruikersnaam.ColumnName = "gebruikersnaam";
			// 
			// clmWachtwoord
			// 
			this.clmWachtwoord.ColumnName = "wachtwoord";
			// 
			// tblBerichten
			// 
			this.tblBerichten.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
			this.tblBerichten.TableName = "Berichten";
			// 
			// dataColumn2
			// 
			this.dataColumn2.AutoIncrement = true;
			this.dataColumn2.ColumnName = "id";
			this.dataColumn2.DataType = typeof(int);
			// 
			// dataColumn3
			// 
			this.dataColumn3.ColumnName = "from_id";
			this.dataColumn3.DataType = typeof(int);
			// 
			// dataColumn4
			// 
			this.dataColumn4.ColumnName = "to_id";
			this.dataColumn4.DataType = typeof(int);
			// 
			// dataColumn5
			// 
			this.dataColumn5.ColumnName = "message";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 104);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(274, 95);
			this.dataGridView1.TabIndex = 13;
			// 
			// dataGridView2
			// 
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(283, 104);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(274, 95);
			this.dataGridView2.TabIndex = 14;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.txtOntvangen, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lstGebruikers, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 97);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(560, 202);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// btnStopServer
			// 
			this.btnStopServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStopServer.Enabled = false;
			this.btnStopServer.Location = new System.Drawing.Point(12, 66);
			this.btnStopServer.Name = "btnStopServer";
			this.btnStopServer.Size = new System.Drawing.Size(560, 25);
			this.btnStopServer.TabIndex = 16;
			this.btnStopServer.Text = "Stop de server";
			this.btnStopServer.UseVisualStyleBackColor = true;
			this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 311);
			this.Controls.Add(this.btnStopServer);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnStartServer);
			this.Controls.Add(this.txtServerAdres);
			this.Location = new System.Drawing.Point(50, 50);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Server (Non-Blocking)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.ChatDatabase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblGebruikers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblBerichten)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnStartServer;
		private System.Windows.Forms.TextBox txtServerAdres;
		private System.Windows.Forms.TextBox txtOntvangen;
		private System.Windows.Forms.ListBox lstGebruikers;
		private System.Data.DataSet ChatDatabase;
		private System.Data.DataTable tblGebruikers;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn clmGebruikersnaam;
		private System.Data.DataColumn clmWachtwoord;
		private System.Data.DataTable tblBerichten;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnStopServer;
	}
}

