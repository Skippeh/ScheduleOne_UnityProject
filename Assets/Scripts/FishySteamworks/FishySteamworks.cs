using System;
using System.Runtime.CompilerServices;
using FishNet.Managing;
using FishNet.Transporting;
using FishySteamworks.Client;
using FishySteamworks.Server;
using UnityEngine;

namespace FishySteamworks
{
	public class FishySteamworks : Transport
	{
		[NonSerialized]
		public ulong LocalUserSteamID;

		[Tooltip("Address server should bind to.")]
		[SerializeField]
		private string _serverBindAddress;

		[Tooltip("Port to use.")]
		[SerializeField]
		private ushort _port;

		[Tooltip("Maximum number of players which may be connected at once.")]
		[Range(1f, 65535f)]
		[SerializeField]
		private ushort _maximumClients;

		[Tooltip("True if using peer to peer socket.")]
		[SerializeField]
		private bool _peerToPeer;

		[Tooltip("Address client should connect to.")]
		[SerializeField]
		private string _clientAddress;

		private int[] _mtus;

		private ClientSocket _client;

		private ClientHostSocket _clientHost;

		private ServerSocket _server;

		private bool _shutdownCalled;

		internal const int CLIENT_HOST_ID = 32767;

		public override event Action<ClientConnectionStateArgs> OnClientConnectionState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<ServerConnectionStateArgs> OnServerConnectionState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<RemoteConnectionStateArgs> OnRemoteConnectionState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<ClientReceivedDataArgs> OnClientReceivedData
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<ServerReceivedDataArgs> OnServerReceivedData
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		~FishySteamworks()
		{
		}

		public override void Initialize(NetworkManager networkManager, int transportIndex)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void CreateChannelData()
		{
		}

		private bool InitializeRelayNetworkAccess()
		{
			return false;
		}

		public bool IsNetworkAccessAvailable()
		{
			return false;
		}

		public override string GetConnectionAddress(int connectionId)
		{
			return null;
		}

		public override LocalConnectionState GetConnectionState(bool server)
		{
			return default(LocalConnectionState);
		}

		public override RemoteConnectionState GetConnectionState(int connectionId)
		{
			return default(RemoteConnectionState);
		}

		public override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs)
		{
		}

		public override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs)
		{
		}

		public override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs)
		{
		}

		public override void IterateIncoming(bool server)
		{
		}

		public override void IterateOutgoing(bool server)
		{
		}

		public override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs)
		{
		}

		public override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs)
		{
		}

		public override void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
		}

		public override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId)
		{
		}

		public override int GetMaximumClients()
		{
			return 0;
		}

		public override void SetMaximumClients(int value)
		{
		}

		public override void SetClientAddress(string address)
		{
		}

		public override void SetServerBindAddress(string address, IPAddressType addressType)
		{
		}

		public override void SetPort(ushort port)
		{
		}

		public override bool StartConnection(bool server)
		{
			return false;
		}

		public override bool StopConnection(bool server)
		{
			return false;
		}

		public override bool StopConnection(int connectionId, bool immediately)
		{
			return false;
		}

		public override void Shutdown()
		{
		}

		private bool StartServer()
		{
			return false;
		}

		private bool StopServer()
		{
			return false;
		}

		private bool StartClient(string address)
		{
			return false;
		}

		private bool StopClient()
		{
			return false;
		}

		private bool StopClient(int connectionId, bool immediately)
		{
			return false;
		}

		public override int GetMTU(byte channel)
		{
			return 0;
		}
	}
}
