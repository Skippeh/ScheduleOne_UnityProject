namespace ScheduleOne.NPCs.Behaviour
{
	public class PotActionBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public enum EActionType
		{
			None = 0,
			PourSoil = 1,
			SowSeed = 2,
			Water = 3,
			ApplyAdditive = 4,
			Harvest = 5
		}

		public enum EState
		{
			Idle = 0,
			WalkingToSupplies = 1,
			GrabbingSupplies = 2,
			WalkingToPot = 3,
			PerformingAction = 4,
			WalkingToDestination = 5
		}

		[global::UnityEngine.HideInInspector]
		public int AdditiveNumber;

		[global::UnityEngine.Header("Equippables")]
		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable WateringCanEquippable;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable TrimmersEquippable;

		private global::ScheduleOne.Employees.Botanist botanist;

		private global::UnityEngine.Coroutine walkToSuppliesRoutine;

		private global::UnityEngine.Coroutine grabRoutine;

		private global::UnityEngine.Coroutine walkToPotRoutine;

		private global::UnityEngine.Coroutine performActionRoutine;

		private string currentActionAnimation;

		private global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable currentActionEquippable;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EPotActionBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EPotActionBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public bool Initialized { get; protected set; }

		public global::ScheduleOne.ObjectScripts.Pot AssignedPot { get; protected set; }

		public global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EActionType CurrentActionType { get; protected set; }

		public global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EState CurrentState { get; protected set; }

		public override void Awake()
		{
		}

		public virtual void Initialize(global::ScheduleOne.ObjectScripts.Pot pot, global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EActionType actionType)
		{
		}

		public override void Begin()
		{
		}

		public override void Resume()
		{
		}

		public override void Pause()
		{
		}

		public override void Disable()
		{
		}

		public override void End()
		{
		}

		public override void ActiveMinPass()
		{
		}

		private void StartAction()
		{
		}

		private void StopAllActions()
		{
		}

		public void WalkToSupplies()
		{
		}

		public void GrabItem()
		{
		}

		public void WalkToPot()
		{
		}

		public void PerformAction()
		{
		}

		private void CompleteAction()
		{
		}

		private void StopPerformAction()
		{
		}

		private string GetActionAnimation(global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EActionType actionType)
		{
			return null;
		}

		private global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable GetActionEquippable(global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EActionType actionType)
		{
			return null;
		}

		public float GetWaitTime(global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EActionType actionType)
		{
			return 0f;
		}

		public bool CanGetToSupplies()
		{
			return false;
		}

		private bool IsAtSupplies()
		{
			return false;
		}

		private global::ScheduleOne.Management.ITransitEntity GetSuppliesAsTransitEntity()
		{
			return null;
		}

		public bool CanGetToPot()
		{
			return false;
		}

		private global::UnityEngine.Transform GetPotAccessPoint()
		{
			return null;
		}

		private bool IsAtPot()
		{
			return false;
		}

		private string[] GetRequiredItemIDs(global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EActionType actionType, global::ScheduleOne.ObjectScripts.Pot pot)
		{
			return null;
		}

		private string[] GetRequiredItemIDs()
		{
			return null;
		}

		private bool AreActionConditionsMet()
		{
			return false;
		}

		public bool DoesTaskTypeRequireSupplies(global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EActionType actionType)
		{
			return false;
		}

		public bool DoesBotanistHaveMaterialsForTask(global::ScheduleOne.Employees.Botanist botanist, global::ScheduleOne.ObjectScripts.Pot pot, global::ScheduleOne.NPCs.Behaviour.PotActionBehaviour.EActionType actionType, int additiveNumber = -1)
		{
			return false;
		}

		private global::ScheduleOne.ItemFramework.ItemInstance GetSoilInSupplies()
		{
			return null;
		}

		private global::ScheduleOne.ItemFramework.ItemInstance GetSeedInSupplies(global::ScheduleOne.ObjectScripts.Pot pot)
		{
			return null;
		}

		private global::ScheduleOne.ItemFramework.ItemInstance GetAdditiveInSupplies(global::ScheduleOne.ObjectScripts.Pot pot, int additiveNumber)
		{
			return null;
		}

		public bool CanPotBeWatered(global::ScheduleOne.ObjectScripts.Pot pot, float threshold)
		{
			return false;
		}

		public bool CanPotHaveSoilPour(global::ScheduleOne.ObjectScripts.Pot pot)
		{
			return false;
		}

		public bool CanPotHaveSeedSown(global::ScheduleOne.ObjectScripts.Pot pot)
		{
			return false;
		}

		public bool CanPotHaveAdditiveApplied(global::ScheduleOne.ObjectScripts.Pot pot, out int additiveNumber)
		{
			additiveNumber = default(int);
			return false;
		}

		public bool CanPotBeHarvested(global::ScheduleOne.ObjectScripts.Pot pot)
		{
			return false;
		}

		public bool DoesPotHaveValidDestination(global::ScheduleOne.ObjectScripts.Pot pot)
		{
			return false;
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EPotActionBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
