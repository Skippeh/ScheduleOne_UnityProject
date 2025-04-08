namespace ScheduleOne.NPCs.Schedules
{
	public class NPCSignal_WalkToLocation : global::ScheduleOne.NPCs.Schedules.NPCSignal
	{
		public global::UnityEngine.Transform Destination;

		public bool FaceDestinationDir;

		public float DestinationThreshold;

		public bool WarpIfSkipped;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_WalkToLocationAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_WalkToLocationAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		public override string GetName()
		{
			return null;
		}

		public override void Started()
		{
		}

		public override void ActiveUpdate()
		{
		}

		public override void LateStarted()
		{
		}

		public override void Interrupt()
		{
		}

		public override void Resume()
		{
		}

		public override void Skipped()
		{
		}

		private bool IsAtDestination()
		{
			return false;
		}

		protected override void WalkCallback(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReachedDestination()
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Observers_ReachedDestination_2166136261()
		{
		}

		private void RpcLogic___ReachedDestination_2166136261()
		{
		}

		private void RpcReader___Observers_ReachedDestination_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
