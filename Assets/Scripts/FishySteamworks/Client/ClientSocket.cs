namespace FishySteamworks.Client
{
	public class ClientSocket : global::FishySteamworks.CommonSocket
	{
		private global::Steamworks.Callback<global::Steamworks.SteamNetConnectionStatusChangedCallback_t> _onLocalConnectionStateCallback;

		private global::Steamworks.CSteamID _hostSteamID;

		private global::Steamworks.HSteamNetConnection _socket;

		private global::System.Threading.Thread _timeoutThread;

		private float _connectTimeout;

		private const float CONNECT_TIMEOUT_DURATION = 8000f;

		private void CheckTimeout()
		{
		}

		internal bool StartConnection(string address, ushort port, bool peerToPeer)
		{
			return false;
		}

		private void OnLocalConnectionState(global::Steamworks.SteamNetConnectionStatusChangedCallback_t args)
		{
		}

		internal bool StopConnection()
		{
			return false;
		}

		internal void IterateIncoming()
		{
		}

		internal void SendToServer(byte channelId, global::System.ArraySegment<byte> segment)
		{
		}

		internal void IterateOutgoing()
		{
		}
	}
}
