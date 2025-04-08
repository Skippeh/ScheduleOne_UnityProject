namespace ScheduleOne.NPCs.Schedules
{
	public class NPCSignal_HandleDeal : global::ScheduleOne.NPCs.Schedules.NPCSignal
	{
		private global::ScheduleOne.Economy.Dealer dealer;

		private global::ScheduleOne.Quests.Contract contract;

		private global::ScheduleOne.Economy.Customer customer;

		private global::UnityEngine.Coroutine handoverRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_HandleDealAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_HandleDealAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		public void AssignContract(global::ScheduleOne.Quests.Contract c)
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

		public override void MinPassed()
		{
		}

		public override void LateStarted()
		{
		}

		public override void JumpTo()
		{
		}

		public override void Interrupt()
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

		private bool IsCustomerReady()
		{
			return false;
		}

		protected override void WalkCallback(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
		{
		}

		private void BeginHandover()
		{
		}

		private void StopHandover()
		{
		}

		private global::UnityEngine.Vector3 GetStandPos()
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::UnityEngine.Vector3 GetStandDir()
		{
			return default(global::UnityEngine.Vector3);
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ESchedules_002ENPCSignal_HandleDeal_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
