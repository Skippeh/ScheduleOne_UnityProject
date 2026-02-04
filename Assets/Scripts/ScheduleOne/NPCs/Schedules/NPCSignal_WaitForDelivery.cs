namespace ScheduleOne.NPCs.Schedules
{
	public class NPCSignal_WaitForDelivery : global::ScheduleOne.NPCs.Schedules.NPCSignal
	{
		public const float DestinationThreshold = 1.5f;

		public const float WalkSpeedMultiplier = 1.25f;

		private global::ScheduleOne.Quests.Contract contract;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_WaitForDeliveryAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_WaitForDeliveryAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		private global::ScheduleOne.Economy.DeliveryLocation Location => null;

		public void SetContract(global::ScheduleOne.Quests.Contract contract)
		{
		}

		public override void Awake()
		{
		}

		protected override void OnValidate()
		{
		}

		public override string GetName()
		{
			return null;
		}

		public override void Started()
		{
		}

		public override void LateStarted()
		{
		}

		public override void JumpTo()
		{
		}

		private void EnsureNPCHasEnoughCash()
		{
		}

		public override void OnActiveTick()
		{
		}

		private void CheckWarp()
		{
		}

		public override void Interrupt()
		{
		}

		public override void Resume()
		{
		}

		public override void End()
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

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_WaitForDelivery_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
