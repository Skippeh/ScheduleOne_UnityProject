namespace ScheduleOne.NPCs.Schedules
{
	public class NPCSignal_UseVendingMachine : global::ScheduleOne.NPCs.Schedules.NPCSignal
	{
		private const float destinationThreshold = 1f;

		public global::ScheduleOne.ObjectScripts.VendingMachine MachineOverride;

		private global::ScheduleOne.ObjectScripts.VendingMachine TargetMachine;

		private global::UnityEngine.Coroutine purchaseCoroutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_UseVendingMachineAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_UseVendingMachineAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		public override string GetName()
		{
			return null;
		}

		public override void Started()
		{
		}

		public override void MinPassed()
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

		private global::ScheduleOne.ObjectScripts.VendingMachine GetTargetMachine()
		{
			return null;
		}

		protected override void WalkCallback(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void Purchase()
		{
		}

		private bool CheckItem()
		{
			return false;
		}

		private void ItemWasStolen()
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

		private void RpcWriter___Observers_Purchase_2166136261()
		{
		}

		public void RpcLogic___Purchase_2166136261()
		{
		}

		private void RpcReader___Observers_Purchase_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
