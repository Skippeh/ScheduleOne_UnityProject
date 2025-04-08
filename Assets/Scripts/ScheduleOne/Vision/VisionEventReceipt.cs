namespace ScheduleOne.Vision
{
	[global::System.Serializable]
	public class VisionEventReceipt
	{
		public global::FishNet.Object.NetworkObject TargetPlayer;

		public global::ScheduleOne.PlayerScripts.PlayerVisualState.EVisualState State;

		public VisionEventReceipt(global::FishNet.Object.NetworkObject targetPlayer, global::ScheduleOne.PlayerScripts.PlayerVisualState.EVisualState state)
		{
		}

		public VisionEventReceipt()
		{
		}
	}
}
