namespace FishySteamworks.Server
{
	public class ServerSocket : global::FishySteamworks.CommonSocket
	{
		public struct ConnectionChange
		{
			public int ConnectionId;

			public global::Steamworks.HSteamNetConnection SteamConnection;

			public global::Steamworks.CSteamID SteamId;

			public bool IsConnect => false;

			public ConnectionChange(int id)
			{
				ConnectionId = 0;
				SteamConnection = default(global::Steamworks.HSteamNetConnection);
				SteamId = default(global::Steamworks.CSteamID);
			}

			public ConnectionChange(int id, global::Steamworks.HSteamNetConnection steamConnection, global::Steamworks.CSteamID steamId)
			{
				ConnectionId = 0;
				SteamConnection = default(global::Steamworks.HSteamNetConnection);
				SteamId = default(global::Steamworks.CSteamID);
			}
		}

		private global::FishySteamworks.BidirectionalDictionary<global::Steamworks.HSteamNetConnection, int> _steamConnections;

		private global::FishySteamworks.BidirectionalDictionary<global::Steamworks.CSteamID, int> _steamIds;

		private int _maximumClients;

		private int _nextConnectionId;

		private global::Steamworks.HSteamListenSocket _socket;

		private global::System.Collections.Generic.Queue<global::FishySteamworks.LocalPacket> _clientHostIncoming;

		private bool _clientHostStarted;

		private global::Steamworks.Callback<global::Steamworks.SteamNetConnectionStatusChangedCallback_t> _onRemoteConnectionStateCallback;

		private global::System.Collections.Generic.Queue<int> _cachedConnectionIds;

		private global::FishySteamworks.Client.ClientHostSocket _clientHost;

		private bool _iteratingConnections;

		private global::System.Collections.Generic.List<global::FishySteamworks.Server.ServerSocket.ConnectionChange> _pendingConnectionChanges;

		internal global::FishNet.Transporting.RemoteConnectionState GetConnectionState(int connectionId)
		{
			return default(global::FishNet.Transporting.RemoteConnectionState);
		}

		internal void ResetInvalidSocket()
		{
		}

		internal bool StartConnection(string address, ushort port, int maximumClients, bool peerToPeer)
		{
			return false;
		}

		internal bool StopConnection()
		{
			return false;
		}

		internal bool StopConnection(int connectionId)
		{
			return false;
		}

		private bool StopConnection(int connectionId, global::Steamworks.HSteamNetConnection socket)
		{
			return false;
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		private void OnRemoteConnectionState(global::Steamworks.SteamNetConnectionStatusChangedCallback_t args)
		{
		}

		private void AddConnection(int connectionId, global::Steamworks.HSteamNetConnection steamConnection, global::Steamworks.CSteamID steamId)
		{
		}

		private void RemoveConnection(int connectionId)
		{
		}

		internal void IterateOutgoing()
		{
		}

		internal void IterateIncoming()
		{
		}

		private void ProcessPendingConnectionChanges()
		{
		}

		internal void SendToClient(byte channelId, global::System.ArraySegment<byte> segment, int connectionId)
		{
		}

		internal string GetConnectionAddress(int connectionId)
		{
			return null;
		}

		internal void SetMaximumClients(int value)
		{
		}

		internal int GetMaximumClients()
		{
			return 0;
		}

		internal void SetClientHostSocket(global::FishySteamworks.Client.ClientHostSocket socket)
		{
		}

		internal void OnClientHostState(bool started)
		{
		}

		internal void ReceivedFromClientHost(global::FishySteamworks.LocalPacket packet)
		{
		}
	}
}
