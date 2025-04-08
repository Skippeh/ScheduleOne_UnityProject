namespace FishySteamworks
{
	public abstract class CommonSocket
	{
		private global::FishNet.Transporting.LocalConnectionState _connectionState;

		protected bool PeerToPeer;

		protected global::FishNet.Transporting.Transport Transport;

		protected global::System.IntPtr[] MessagePointers;

		protected byte[] InboundBuffer;

		protected const int MAX_MESSAGES = 256;

		internal global::FishNet.Transporting.LocalConnectionState GetLocalConnectionState()
		{
			return default(global::FishNet.Transporting.LocalConnectionState);
		}

		protected virtual void SetLocalConnectionState(global::FishNet.Transporting.LocalConnectionState connectionState, bool server)
		{
		}

		internal virtual void Initialize(global::FishNet.Transporting.Transport t)
		{
		}

		protected byte[] GetIPBytes(string address)
		{
			return null;
		}

		protected global::Steamworks.EResult Send(global::Steamworks.HSteamNetConnection steamConnection, global::System.ArraySegment<byte> segment, byte channelId)
		{
			return default(global::Steamworks.EResult);
		}

		internal void ClearQueue(global::System.Collections.Concurrent.ConcurrentQueue<global::FishySteamworks.LocalPacket> queue)
		{
		}

		internal void ClearQueue(global::System.Collections.Generic.Queue<global::FishySteamworks.LocalPacket> queue)
		{
		}

		protected void GetMessage(global::System.IntPtr ptr, byte[] buffer, out global::System.ArraySegment<byte> segment, out byte channel)
		{
			segment = default(global::System.ArraySegment<byte>);
			channel = default(byte);
		}
	}
}
