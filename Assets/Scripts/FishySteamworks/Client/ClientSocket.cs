using System;
using System.Threading;
using Steamworks;

namespace FishySteamworks.Client
{
	public class ClientSocket : CommonSocket
	{
		private Callback<SteamNetConnectionStatusChangedCallback_t> _onLocalConnectionStateCallback;

		private CSteamID _hostSteamID;

		private HSteamNetConnection _socket;

		private Thread _timeoutThread;

		private float _connectTimeout;

		private const float CONNECT_TIMEOUT_DURATION = 8000f;

		private void CheckTimeout()
		{
		}

		internal bool StartConnection(string address, ushort port, bool peerToPeer)
		{
			return false;
		}

		private void OnLocalConnectionState(SteamNetConnectionStatusChangedCallback_t args)
		{
		}

		internal bool StopConnection()
		{
			return false;
		}

		internal void IterateIncoming()
		{
		}

		internal void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
		}

		internal void IterateOutgoing()
		{
		}
	}
}
