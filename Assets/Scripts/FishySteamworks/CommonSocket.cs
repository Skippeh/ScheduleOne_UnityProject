using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using FishNet.Transporting;
using Steamworks;

namespace FishySteamworks
{
	public abstract class CommonSocket
	{
		private LocalConnectionState _connectionState;

		protected bool PeerToPeer;

		protected Transport Transport;

		protected IntPtr[] MessagePointers;

		protected byte[] InboundBuffer;

		protected const int MAX_MESSAGES = 256;

		internal LocalConnectionState GetLocalConnectionState()
		{
			return default(LocalConnectionState);
		}

		protected virtual void SetLocalConnectionState(LocalConnectionState connectionState, bool server)
		{
		}

		internal virtual void Initialize(Transport t)
		{
		}

		protected byte[] GetIPBytes(string address)
		{
			return null;
		}

		protected EResult Send(HSteamNetConnection steamConnection, ArraySegment<byte> segment, byte channelId)
		{
			return default(EResult);
		}

		internal void ClearQueue(ConcurrentQueue<LocalPacket> queue)
		{
		}

		internal void ClearQueue(Queue<LocalPacket> queue)
		{
		}

		protected void GetMessage(IntPtr ptr, byte[] buffer, out ArraySegment<byte> segment, out byte channel)
		{
			segment = default(ArraySegment<byte>);
			channel = default(byte);
		}
	}
}
