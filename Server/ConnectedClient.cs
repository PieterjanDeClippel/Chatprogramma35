using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Server
{
	public class ConnectedClient
	{
		public ConnectedClient(Socket socket)
		{
			msocket = socket;
			stream = new NetworkStream(socket);
		}
		private Socket msocket;
		public Socket m_Socket
		{
			get { return msocket; }
		}

		private NetworkStream stream;

		const int maxPakketLengte = 1024;
		byte[] receivedData = new byte[maxPakketLengte];
		public void BeginRead()
		{
			stream.BeginRead(receivedData, 0, maxPakketLengte, new AsyncCallback(NetworkStreamReadCallback), stream);
		}

		public delegate void DataOntvangenEventHandler(ConnectedClient connClient, string data);
		public event DataOntvangenEventHandler DataOntvangen;
		void OnDataOntvangen(string data)
		{
			if(DataOntvangen != null)
				DataOntvangen(this, data);
		}

		private void NetworkStreamReadCallback(IAsyncResult ar)
		{
			try
			{
				NetworkStream myNetworkStream = (NetworkStream)ar.AsyncState;
				int berichtlengte = myNetworkStream.EndRead(ar);
				string bericht = new UTF8Encoding().GetString(receivedData, 0, berichtlengte);

				OnDataOntvangen(bericht);
				Array.Clear(receivedData, 0, maxPakketLengte);

				// lezen opnieuw starten
				if(myNetworkStream.CanRead)
					myNetworkStream.BeginRead(receivedData, 0, receivedData.Length, new AsyncCallback(NetworkStreamReadCallback), myNetworkStream);
			}
			catch(Exception)
			{
			}
		}

		public void StopListening()
		{
			if(stream != null) stream.Close();
			//if(msocket != null) msocket.Shutdown(SocketShutdown.Both);
		}

		public void Write(string tekst)
		{
			stream.Write(new UTF8Encoding().GetBytes(tekst), 0, tekst.Length);
		}
		public bool CanWrite
		{
			get { return stream.CanWrite; }
		}

		private int user_id = -1;
		public int User_ID
		{
			get { return user_id; }
			set { user_id = value; }
		}
	}
}
