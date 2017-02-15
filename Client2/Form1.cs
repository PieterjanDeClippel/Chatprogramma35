using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client2
{
	public partial class Form1 : Form
	{
		const int maxPakketlengte = 1024;
		TcpClient myTcpClient;
		Socket mySocket;
		NetworkStream myNetworkStream;
		byte[] receivedData = new byte[maxPakketlengte];

		delegate void UpdateTextBoxDelegate(string tekst);

		public Form1()
		{
			InitializeComponent();
			txtServerAdres.Text = getIPaddress();
		}

		private void btnVerbind_Click(object sender, EventArgs e)
		{
			/*try
			{*/
				myTcpClient = new TcpClient();
				myTcpClient.BeginConnect(IPAddress.Parse(txtServerAdres.Text), 8001, new AsyncCallback(GetConnectedToServerCallback), myTcpClient);

				btnVerbind.Enabled = false;
				btnInloggen.Enabled = true;
				btnRegistreren.Enabled = true;
				this.AcceptButton = btnInloggen;
			/*}
			catch(Exception ex)
			{
				txtOntvangen.AppendText(ex.Message + Environment.NewLine);
			}*/
		}
		private void GetConnectedToServerCallback(IAsyncResult ar)
		{
			TcpClient myTcpClient = (TcpClient)ar.AsyncState;
			if(myTcpClient.Connected)
			{
				myTcpClient.EndConnect(ar);

				mySocket = myTcpClient.Client;
				myNetworkStream = new NetworkStream(mySocket);
				myNetworkStream.BeginRead(receivedData, 0, maxPakketlengte, new AsyncCallback(ReceivedDataFromServerCallback), myNetworkStream);
			}
			else
			{
				Invoke(new ResetButtonsDelegate(DisableButtons));
			}
		}
		delegate void ResetButtonsDelegate();
		void DisableButtons()
		{
			btnVerbind.Enabled = true;
			btnInloggen.Enabled = false;
			btnRegistreren.Enabled = false;
			btnUitloggen.Enabled = false;
			listBox1.Items.Clear();
			this.AcceptButton = btnVerbind;
			txtOntvangen.AppendText("Kan niet verbinden met server" + Environment.NewLine);
		}
		private void ReceivedDataFromServerCallback(IAsyncResult ar)
		{
			NetworkStream myNetworkStream = (NetworkStream)ar.AsyncState;
			try
			{

				int berichtlengte = myNetworkStream.EndRead(ar);

				//tekst in tekstvak op andere (hoofd-) thread aanpassen
				Invoke(new UpdateTextBoxDelegate(UpdateTextBox), new UTF8Encoding().GetString(receivedData, 0, berichtlengte));
				Array.Clear(receivedData, 0, maxPakketlengte);

				if(myNetworkStream.CanRead)
					myNetworkStream.BeginRead(receivedData, 0, receivedData.Length, new AsyncCallback(ReceivedDataFromServerCallback), myNetworkStream);
			}
			catch(Exception)
			{
				Invoke(new ResetButtonsDelegate(DisableButtons));
			}
		}

		private void UpdateTextBox(string tekst)
		{
			if(tekst == "") return;
			string[] data = tekst.Split(';');
			switch(data[0])
			{
				case "Ingelogd":
					btnInloggen.Enabled = false;
					btnRegistreren.Enabled = false;
					btnUitloggen.Enabled = true;
					IK = new User(data[1]);
					break;
				case "Uitgelogd":
					btnInloggen.Enabled = false;
					btnRegistreren.Enabled = false;
					btnUitloggen.Enabled = false;
					btnVerbind.Enabled = true;
					listBox1.Items.Clear();
					myNetworkStream.Close();
					mySocket.Shutdown(SocketShutdown.Both);
					break;
				case "Online users":
					listBox1.Items.Clear();
					OnlineUsers.Clear();
					for(int i = 1; i < data.Length; i++)
					{
						listBox1.Items.Add(data[i].Split(',')[1]);
						OnlineUsers.Add(new User(data[i]));
					}
					break;
				case "Bericht":
					// Bericht;zender.id;zender.user;ik.id;bericht
					ChatSessie[] it = Sessies.Where(T => T.Ontvanger.ID == Convert.ToInt32(data[1])).ToArray();
					if(it.Length == 1)
					{
						it[0].OntvangBericht(data[2], data[4]);
						it[0].BringToFront();
						it[0].Activate();
					}
					else
					{
						ChatSessie nieuw = new ChatSessie(this, OnlineUsers.Where(T => T.ID == Convert.ToInt32(data[1])).ElementAt(0));
						nieuw.FormClosed += delegate { Sessies.Remove(nieuw); };
						Sessies.Add(nieuw);
						nieuw.Owner = this;
						nieuw.Show();
						nieuw.OntvangBericht(data[2], data[4]);
					}
					break;
				default:
					Application.DoEvents();
					break;
			}
			txtOntvangen.AppendText(tekst + Environment.NewLine);
		}

		User IK;
		public string getUserName()
		{
			return IK.Username;
		}
		List<User> OnlineUsers = new List<User>();
		List<ChatSessie> Sessies = new List<ChatSessie>();

		static string getIPaddress()
		{
			IPHostEntry host;
			host = Dns.GetHostEntry(Dns.GetHostName());
			foreach(IPAddress ip in host.AddressList)
			{
				if(ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip.ToString();
				}
			}
			return "?";
		}

		private void btnInloggen_Click(object sender, EventArgs e)
		{
			byte[] sendData = new UTF8Encoding().GetBytes("Login;" + txtGebruiker.Text + ";" + txtWachtwoord.Text);
			myNetworkStream.Write(sendData, 0, sendData.Length);
		}

		private void btnRegistreren_Click(object sender, EventArgs e)
		{
			byte[] sendData = new UTF8Encoding().GetBytes("Registreer;" + txtGebruiker.Text + ";" + txtWachtwoord.Text);
			myNetworkStream.Write(sendData, 0, sendData.Length);
		}

		private void btnUitloggen_Click(object sender, EventArgs e)
		{
			byte[] sendData = new UTF8Encoding().GetBytes("Logout");
			myNetworkStream.Write(sendData, 0, sendData.Length);
		}

		private void btnStartChat_Click(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex == -1) return;
			ChatSessie[] cs = Sessies.Where(T => T.Ontvanger == OnlineUsers[listBox1.SelectedIndex]).ToArray();
			if(cs.Length == 0)
			{
				ChatSessie nieuw = new ChatSessie(this, OnlineUsers[listBox1.SelectedIndex]);
				nieuw.FormClosed += delegate { Sessies.Remove(nieuw); };
				Sessies.Add(nieuw);
				nieuw.Owner = this;
				nieuw.Show();
			}
			else
			{
				cs.First().BringToFront();
				cs.First().Activate();
			}
		}

		public void StuurBericht(User bestemming, string bericht)
		{
			byte[] sendData = new UTF8Encoding().GetBytes("Bericht;" + IK.ID + ";" + IK.Username + ";" + bestemming.ID + ";" + bericht);
			myNetworkStream.Write(sendData, 0, sendData.Length);
		}
	}

	public class User
	{
		public int ID { get; set; }
		public string Username { get; set; }
		public User(string uservalue)
		{
			string[] val = uservalue.Split(',');
			ID = Convert.ToInt32(val[0]);
			Username = val[1];
		}
	}
}
