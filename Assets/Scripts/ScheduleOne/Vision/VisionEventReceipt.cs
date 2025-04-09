using System;
using FishNet.Object;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Vision
{
	[Serializable]
	public class VisionEventReceipt
	{
		public NetworkObject TargetPlayer;

		public PlayerVisualState.EVisualState State;

		public VisionEventReceipt(NetworkObject targetPlayer, PlayerVisualState.EVisualState state)
		{
		}

		public VisionEventReceipt()
		{
		}
	}
}
