namespace ScheduleOne.NPCs.Schedules
{
	public class NPCEvent_LocationDialogue : global::ScheduleOne.NPCs.Schedules.NPCEvent
	{
		public global::UnityEngine.Transform Destination;

		public bool FaceDestinationDir;

		public float DestinationThreshold;

		public bool WarpIfSkipped;

		[global::UnityEngine.Header("Dialogue Settings")]
		public int GreetingOverrideToEnable;

		public int ChoiceToEnable;

		public global::ScheduleOne.Dialogue.DialogueContainer DialogueOverride;

		protected bool IsActionStarted;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_LocationDialogueAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_LocationDialogueAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		public override string GetName()
		{
			return null;
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public override void Started()
		{
		}

		public override void OnActiveTick()
		{
		}

		public override void LateStarted()
		{
		}

		public override void JumpTo()
		{
		}

		public override void End()
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

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		protected virtual void StartAction(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		protected virtual void EndAction()
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

		private void RpcWriter___Observers_StartAction_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void RpcLogic___StartAction_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_StartAction_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_StartAction_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_StartAction_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_EndAction_2166136261()
		{
		}

		protected virtual void RpcLogic___EndAction_2166136261()
		{
		}

		private void RpcReader___Observers_EndAction_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
