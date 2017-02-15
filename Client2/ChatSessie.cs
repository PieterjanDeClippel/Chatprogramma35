using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client2
{
	public partial class ChatSessie : Form
	{
		public ChatSessie(Form1 mainform, User ontvanger)
		{
			InitializeComponent();
			MainForm = mainform;
			Ontvanger = ontvanger;
			Text = mainform.getUserName() + " → " + ontvanger.Username;
		}

		private Form1 MainForm;
		public User Ontvanger;

		private void button1_Click(object sender, EventArgs e)
		{
			MainForm.StuurBericht(Ontvanger, textBox1.Text);
			OntvangBericht("ik", textBox1.Text);
		}

		public void OntvangBericht(string zender_naam, string bericht)
		{
			textBox2.AppendText(zender_naam + ":" + Environment.NewLine + bericht + Environment.NewLine);
		}
	}
}
