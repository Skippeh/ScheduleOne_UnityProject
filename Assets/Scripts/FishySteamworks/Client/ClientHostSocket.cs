namespace FishySteamworks.Client
{
	public class ClientHostSocket : global::FishySteamworks.CommonSocket
	{
		private global::FishySteamworks.Server.ServerSocket _server;

		private global::System.Collections.Generic.Queue<global::FishySteamworks.LocalPacket> _incoming;

		internal void CheckSetStarted()
		{
		}

		internal bool StartConnection(global::FishySteamworks.Server.ServerSocket serverSocket)
		{
			return false;
		}

		protected override void SetLocalConnectionState(global::FishNet.Transporting.LocalConnectionState connectionState, bool server)
		{
		}

		internal bool StopConnection()
		{
			return false;
		}

		internal void IterateIncoming()
		{
		}

		internal void ReceivedFromLocalServer(global::FishySteamworks.LocalPacket packet)
		{
		}

		internal void SendToServer(byte channelId, global::System.ArraySegment<byte> segment)
		{
		}
	}
}
