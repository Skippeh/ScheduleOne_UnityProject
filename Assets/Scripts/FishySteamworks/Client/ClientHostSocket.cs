using System;
using System.Collections.Generic;
using FishNet.Transporting;
using FishySteamworks.Server;

namespace FishySteamworks.Client
{
	public class ClientHostSocket : CommonSocket
	{
		private ServerSocket _server;

		private Queue<LocalPacket> _incoming;

		internal void CheckSetStarted()
		{
		}

		internal bool StartConnection(ServerSocket serverSocket)
		{
			return false;
		}

		protected override void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
		}

		internal bool StopConnection()
		{
			return false;
		}

		internal void IterateIncoming()
		{
		}

		internal void ReceivedFromLocalServer(LocalPacket packet)
		{
		}

		internal void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
		}
	}
}
