using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Employees;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class PotActionBehaviour : Behaviour
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

		[HideInInspector]
		public int AdditiveNumber;

		[Header("Equippables")]
		public AvatarEquippable WateringCanEquippable;

		public AvatarEquippable TrimmersEquippable;

		private Botanist botanist;

		private Coroutine walkToSuppliesRoutine;

		private Coroutine grabRoutine;

		private Coroutine walkToPotRoutine;

		private Coroutine performActionRoutine;

		private string currentActionAnimation;

		private AvatarEquippable currentActionEquippable;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EPotActionBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EPotActionBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public bool Initialized { get; protected set; }

		public Pot AssignedPot { get; protected set; }

		public EActionType CurrentActionType { get; protected set; }

		public EState CurrentState { get; protected set; }

		public override void Awake()
		{
		}

		public virtual void Initialize(Pot pot, EActionType actionType)
		{
		}

		protected override void Begin()
		{
		}

		protected override void Resume()
		{
		}

		protected override void Pause()
		{
		}

		public override void Disable()
		{
		}

		protected override void End()
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

		private string GetActionAnimation(EActionType actionType)
		{
			return null;
		}

		private AvatarEquippable GetActionEquippable(EActionType actionType)
		{
			return null;
		}

		public float GetWaitTime(EActionType actionType)
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

		private ITransitEntity GetSuppliesAsTransitEntity()
		{
			return null;
		}

		public bool CanGetToPot()
		{
			return false;
		}

		private Transform GetPotAccessPoint()
		{
			return null;
		}

		private bool IsAtPot()
		{
			return false;
		}

		private string[] GetRequiredItemIDs(EActionType actionType, Pot pot)
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

		public bool DoesTaskTypeRequireSupplies(EActionType actionType)
		{
			return false;
		}

		public bool DoesBotanistHaveMaterialsForTask(Botanist botanist, Pot pot, EActionType actionType, int additiveNumber = -1)
		{
			return false;
		}

		private ItemInstance GetSoilInSupplies()
		{
			return null;
		}

		private ItemInstance GetSeedInSupplies(Pot pot)
		{
			return null;
		}

		private ItemInstance GetAdditiveInSupplies(Pot pot, int additiveNumber)
		{
			return null;
		}

		public bool CanPotBeWatered(Pot pot, float threshold)
		{
			return false;
		}

		public bool CanPotHaveSoilPour(Pot pot)
		{
			return false;
		}

		public bool CanPotHaveSeedSown(Pot pot)
		{
			return false;
		}

		public bool CanPotHaveAdditiveApplied(Pot pot, out int additiveNumber)
		{
			additiveNumber = default(int);
			return false;
		}

		public bool CanPotBeHarvested(Pot pot)
		{
			return false;
		}

		public bool DoesPotHaveValidDestination(Pot pot)
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
