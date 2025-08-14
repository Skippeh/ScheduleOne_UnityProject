namespace ScheduleOne.Vision
{
	[global::System.Serializable]
	public class VisionEventReceipt
	{
		public global::FishNet.Object.NetworkObject Target;

		public global::ScheduleOne.Vision.EVisualState State;

		public VisionEventReceipt(global::FishNet.Object.NetworkObject target, global::ScheduleOne.Vision.EVisualState state)
		{
		}

		public VisionEventReceipt()
		{
		}
	}
}
