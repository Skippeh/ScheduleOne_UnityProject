namespace FishySteamworks
{
	public class FishySteamworks : global::FishNet.Transporting.Transport
	{
		[global::System.NonSerialized]
		public ulong LocalUserSteamID;

		[global::UnityEngine.Tooltip("Address server should bind to.")]
		[global::UnityEngine.SerializeField]
		private string _serverBindAddress;

		[global::UnityEngine.Tooltip("Port to use.")]
		[global::UnityEngine.SerializeField]
		private ushort _port;

		[global::UnityEngine.Tooltip("Maximum number of players which may be connected at once.")]
		[global::UnityEngine.Range(1f, 65535f)]
		[global::UnityEngine.SerializeField]
		private ushort _maximumClients;

		[global::UnityEngine.Tooltip("True if using peer to peer socket.")]
		[global::UnityEngine.SerializeField]
		private bool _peerToPeer;

		[global::UnityEngine.Tooltip("Address client should connect to.")]
		[global::UnityEngine.SerializeField]
		private string _clientAddress;

		private int[] _mtus;

		private global::FishySteamworks.Client.ClientSocket _client;

		private global::FishySteamworks.Client.ClientHostSocket _clientHost;

		private global::FishySteamworks.Server.ServerSocket _server;

		private bool _shutdownCalled;

		internal const int CLIENT_HOST_ID = 32767;

		public override event global::System.Action<global::FishNet.Transporting.ClientConnectionStateArgs> OnClientConnectionState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		public override event global::System.Action<global::FishNet.Transporting.ServerConnectionStateArgs> OnServerConnectionState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		public override event global::System.Action<global::FishNet.Transporting.RemoteConnectionStateArgs> OnRemoteConnectionState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		public override event global::System.Action<global::FishNet.Transporting.ClientReceivedDataArgs> OnClientReceivedData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		public override event global::System.Action<global::FishNet.Transporting.ServerReceivedDataArgs> OnServerReceivedData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		~FishySteamworks()
		{
		}

		public override void Initialize(global::FishNet.Managing.NetworkManager networkManager, int transportIndex)
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

		public override global::FishNet.Transporting.LocalConnectionState GetConnectionState(bool server)
		{
			return default(global::FishNet.Transporting.LocalConnectionState);
		}

		public override global::FishNet.Transporting.RemoteConnectionState GetConnectionState(int connectionId)
		{
			return default(global::FishNet.Transporting.RemoteConnectionState);
		}

		public override void HandleClientConnectionState(global::FishNet.Transporting.ClientConnectionStateArgs connectionStateArgs)
		{
		}

		public override void HandleServerConnectionState(global::FishNet.Transporting.ServerConnectionStateArgs connectionStateArgs)
		{
		}

		public override void HandleRemoteConnectionState(global::FishNet.Transporting.RemoteConnectionStateArgs connectionStateArgs)
		{
		}

		public override void IterateIncoming(bool server)
		{
		}

		public override void IterateOutgoing(bool server)
		{
		}

		public override void HandleClientReceivedDataArgs(global::FishNet.Transporting.ClientReceivedDataArgs receivedDataArgs)
		{
		}

		public override void HandleServerReceivedDataArgs(global::FishNet.Transporting.ServerReceivedDataArgs receivedDataArgs)
		{
		}

		public override void SendToServer(byte channelId, global::System.ArraySegment<byte> segment)
		{
		}

		public override void SendToClient(byte channelId, global::System.ArraySegment<byte> segment, int connectionId)
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

		public override void SetServerBindAddress(string address, global::FishNet.Transporting.IPAddressType addressType)
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
