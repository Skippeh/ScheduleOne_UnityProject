using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Transporting;
using FishySteamworks.Client;
using Steamworks;

namespace FishySteamworks.Server
{
	public class ServerSocket : CommonSocket
	{
		public struct ConnectionChange
		{
			public int ConnectionId;

			public HSteamNetConnection SteamConnection;

			public CSteamID SteamId;

			public bool IsConnect => false;

			public ConnectionChange(int id)
			{
				ConnectionId = id;
				SteamId = CSteamID.Nil;
				SteamConnection = default(HSteamNetConnection);
			}

			public ConnectionChange(int id, HSteamNetConnection steamConnection, CSteamID steamId)
			{
				ConnectionId = id;
				SteamConnection = steamConnection;
				SteamId = steamId;
			}
		}

		private BidirectionalDictionary<HSteamNetConnection, int> _steamConnections;

		private BidirectionalDictionary<CSteamID, int> _steamIds;

		private int _maximumClients;

		private int _nextConnectionId;

		private HSteamListenSocket _socket;

		private Queue<LocalPacket> _clientHostIncoming;

		private bool _clientHostStarted;

		private Callback<SteamNetConnectionStatusChangedCallback_t> _onRemoteConnectionStateCallback;

		private Queue<int> _cachedConnectionIds;

		private ClientHostSocket _clientHost;

		private bool _iteratingConnections;

		private List<ConnectionChange> _pendingConnectionChanges;

		internal RemoteConnectionState GetConnectionState(int connectionId)
		{
			return default(RemoteConnectionState);
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

		private bool StopConnection(int connectionId, HSteamNetConnection socket)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void OnRemoteConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
		}

		private void AddConnection(int connectionId, HSteamNetConnection steamConnection, CSteamID steamId)
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

		internal void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
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

		internal void SetClientHostSocket(ClientHostSocket socket)
		{
		}

		internal void OnClientHostState(bool started)
		{
		}

		internal void ReceivedFromClientHost(LocalPacket packet)
		{
		}
	}
}
