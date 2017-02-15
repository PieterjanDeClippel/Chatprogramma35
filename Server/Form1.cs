using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server
{
	public partial class Form1 : Form
	{
		bool listening = false;
		TcpListener myTcpListener;

		string db_file = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ChatDatabase.xml";
        public Form1()
		{
			InitializeComponent();
			if(File.Exists(db_file))
				ChatDatabase.ReadXml(db_file);
			txtServerAdres.Text = getIPaddress();
			DataOntvangenDel += new DataOntvangenDelegate(DataOntvangenVanClient);
			dataGridView1.DataSource = ChatDatabase.Tables[0];
			dataGridView2.DataSource = ChatDatabase.Tables[1];
		}

		private void btnStartServer_Click(object sender, EventArgs e)
		{
			/*try
			{*/
				IPAddress ipAd = IPAddress.Parse(txtServerAdres.Text);
				listening = true;
				myTcpListener = new TcpListener(ipAd, 8001);
				myTcpListener.Start();
				btnStartServer.Enabled = false;
				btnStopServer.Enabled = true;
				myTcpListener.BeginAcceptSocket(new AsyncCallback(AcceptSocketCallback), myTcpListener); //ASYNCHRONE FUNCTIE AANROEPEN (op andere thread)
																										 /*}
																										 catch(Exception ex)
																										 {
																											 txtOntvangen.AppendText(ex.Message + Environment.NewLine);
																										 }*/
		}

		private void btnStopServer_Click(object sender, EventArgs e)
		{
			listening = false;
			foreach(ConnectedClient cl in Clients)
				cl.m_Socket.Close();
			myTcpListener.Stop();
			Clients.Clear();
			lstGebruikers.Items.Clear();
			btnStartServer.Enabled = true;
			btnStopServer.Enabled = false;
		}

		List<ConnectedClient> Clients = new List<ConnectedClient>();
		private void AcceptSocketCallback(IAsyncResult ar)
		{
			try
			{
				if(!listening) return;
				TcpListener myTcpListener = (TcpListener)ar.AsyncState;
				Socket s = myTcpListener.EndAcceptSocket(ar);
			
				ConnectedClient nieuweClient = new ConnectedClient(s);
				nieuweClient.DataOntvangen += Client_DataOntvangen;
				Clients.Add(nieuweClient);
				nieuweClient.BeginRead();
				nieuweClient.Write("Verbonden");

				myTcpListener.BeginAcceptSocket(new AsyncCallback(AcceptSocketCallback), myTcpListener);
			}
			catch(Exception ex)
			{
				txtOntvangen.AppendText(ex.Message + Environment.NewLine);
			}
		}

		private void Client_DataOntvangen(ConnectedClient connClient, string data)
		{
			if(connClient.m_Socket.Connected)
				Invoke(DataOntvangenDel, connClient, data);
		}
		delegate void DataOntvangenDelegate(ConnectedClient client,string data);
		DataOntvangenDelegate DataOntvangenDel;

		private void DataOntvangenVanClient(ConnectedClient client, string data)
		{
			txtOntvangen.Text += data + Environment.NewLine;
			string[] data2 = data.Split(';');
			switch(data2[0])
			{
				case "Login":
					DataRow[] rijen = ChatDatabase.Tables[0].Select("gebruikersnaam='" + data2[1] + "'", "id ASC");
					if(rijen.Length == 0)
					{
						client.Write("Gebruiker bestaat niet");
					}
					else if(rijen.First().Field<string>(2) == data2[2])
					{
						lstGebruikers.Items.Add(data2[1]);
						
						client.User_ID = rijen.First().Field<int>(0);
						client.Write("Ingelogd;" + client.User_ID.ToString() + "," + data2[1]);
						foreach(ConnectedClient cl in Clients)
							if(cl.CanWrite & (cl.User_ID != -1))
								cl.Write(string.Join(";", (new string[] { "Online users" }).Union(Clients
									.Except(new ConnectedClient[] { cl })
									.Where(T => T.User_ID != -1)
									.Select(T => T.User_ID + "," + ChatDatabase.Tables[0].Select("id=" + T.User_ID.ToString(),"id ASC").First().Field<string>(1))
									).ToArray()));
					}
					else
					{
						client.Write("Foutief wachtwoord");
					}
					break;
				case "Logout":
					client.Write("Uitgelogd");
					lstGebruikers.Items.Remove(ChatDatabase.Tables[0].Select("id=" + client.User_ID.ToString()).First().Field<string>(1));
					client.User_ID = -1;
					foreach(ConnectedClient cl in Clients.Except(new ConnectedClient[] { client }))
						if(cl.CanWrite & (cl.User_ID != -1))
							cl.Write(string.Join(";", (new string[] { "Online users" }).Union(Clients
								.Except(new ConnectedClient[] { cl })
								.Where(T => T.User_ID != -1)
								.Select(T => T.User_ID + "," + ChatDatabase.Tables[0].Select("id=" + T.User_ID.ToString(), "id ASC").First().Field<string>(1))
								).ToArray()));
					client.DataOntvangen -= Client_DataOntvangen;
					client.StopListening();
					break;
				case "Registreer":
					DataRow[] rijen2 = ChatDatabase.Tables[0].Select("gebruikersnaam='" + data2[1] + "'","id ASC");
					if(data2[1].Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("\t", "") == "")
					{
						client.Write("Geef een gebruikersnaam op");
					}
					else if(data2[2].Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("\t", "") == "")
					{
						client.Write("Geef een wachtwoord op");
					}
					else if(rijen2.Length == 0)
					{
						DataRow nieuw = ChatDatabase.Tables[0].NewRow();
						nieuw.SetField<string>(1, data2[1]);
						nieuw.SetField<string>(2, data2[2]);
						ChatDatabase.Tables[0].Rows.Add(nieuw);
						client.Write("Gebruiker aangemaakt");
						ChatDatabase.WriteXml(db_file);
					}
					else
					{
						client.Write("Gebruikersnaam niet meer beschikbaar");
					}
					break;
				case "Bericht":
					// Bericht;ik.id;ik.user;dest.id;bericht
					ConnectedClient[] dest = Clients.Where(T => T.User_ID == Convert.ToInt32(data2[3])).ToArray();
					if(dest.Length == 1)
					{
						dest[0].Write(data);
					}
					DataRow nieuw2 = ChatDatabase.Tables[1].NewRow();
					nieuw2.SetField<int>(1, Convert.ToInt32(data2[1]));
					nieuw2.SetField<int>(2, Convert.ToInt32(data2[3]));
					nieuw2.SetField<string>(3, data2[4]);
					//nieuw2.SetField<bool>(4, dest.Length == 1);
					//nieuw2.SetField<bool>(5, false);
					ChatDatabase.Tables[1].Rows.Add(nieuw2);
					ChatDatabase.WriteXml(db_file);
					break;
			}
		}
		
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach(ConnectedClient cl in Clients)
				cl.StopListening();
		}

		static string getIPaddress()
		{
			IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
			foreach(IPAddress ip in host.AddressList)
				if(ip.AddressFamily == AddressFamily.InterNetwork)
					return ip.ToString();
			return "?";
		}
	}
}
