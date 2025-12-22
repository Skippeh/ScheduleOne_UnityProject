namespace ScheduleOne.NPCs.Behaviour
{
	public class DealerAttendDealBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		private global::ScheduleOne.Economy.Dealer _dealer;

		private global::ScheduleOne.Quests.Contract _contract;

		private global::ScheduleOne.Economy.Customer _customer;

		private global::UnityEngine.Coroutine _handoverRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EDealerAttendDealBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EDealerAttendDealBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		public void AssignContract(global::ScheduleOne.Quests.Contract contract)
		{
		}

		public override void Activate()
		{
		}

		public override void Resume()
		{
		}

		public override void Pause()
		{
		}

		public override void Deactivate()
		{
		}

		public override void OnActiveTick()
		{
		}

		private void BeginHandover()
		{
		}

		private void StopHandover()
		{
		}

		private bool IsAtDestination()
		{
			return false;
		}

		private bool IsCustomerReadyForHandover()
		{
			return false;
		}

		private global::UnityEngine.Vector3 GetStandPosition()
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::UnityEngine.Vector3 GetDirectionToFace()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EDealerAttendDealBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
