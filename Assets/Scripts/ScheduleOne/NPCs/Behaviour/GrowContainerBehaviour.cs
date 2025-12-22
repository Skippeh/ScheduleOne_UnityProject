namespace ScheduleOne.NPCs.Behaviour
{
	public abstract class GrowContainerBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		protected enum EState
		{
			Idle = 0,
			Walking = 1,
			GrabbingSupplies = 2,
			PerformingAction = 3
		}

		private global::UnityEngine.Coroutine _walkRoutine;

		private global::UnityEngine.Coroutine _grabRoutine;

		private global::UnityEngine.Coroutine _performActionRoutine;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EGrowContainerBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EGrowContainerBehaviourAssembly_002DCSharp_002Edll_Excuted;

		protected global::ScheduleOne.Growing.GrowContainer _growContainer { get; private set; }

		protected global::ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour.EState _currentState { get; private set; }

		protected global::ScheduleOne.Employees.Botanist _botanist { get; private set; }

		protected global::ScheduleOne.Management.BotanistConfiguration _botanistConfiguration => null;

		public override void Awake()
		{
		}

		public virtual void AssignAndEnable(global::ScheduleOne.Growing.GrowContainer growContainer)
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

		public virtual bool AreTaskConditionsMetForContainer(global::ScheduleOne.Growing.GrowContainer container)
		{
			return false;
		}

		public bool DoesBotanistHaveAccessToRequiredSupplies(global::ScheduleOne.Growing.GrowContainer container)
		{
			return false;
		}

		public override void OnActiveTick()
		{
		}

		protected virtual void OnStartPerformAction()
		{
		}

		protected virtual void OnStopPerformAction()
		{
		}

		protected virtual global::UnityEngine.Vector3 GetGrowContainerLookPoint()
		{
			return default(global::UnityEngine.Vector3);
		}

		protected virtual global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable GetActionEquippable()
		{
			return null;
		}

		protected virtual global::ScheduleOne.Trash.TrashItem GetTrashPrefab(global::ScheduleOne.ItemFramework.ItemInstance usedItem)
		{
			return null;
		}

		protected abstract void OnActionSuccess(global::ScheduleOne.ItemFramework.ItemInstance usedItem);

		protected abstract string GetAnimationBool();

		protected abstract float GetActionDuration();

		private void WalkTo(global::ScheduleOne.Management.ITransitEntity entity)
		{
		}

		private void GrabRequiredItemFromSupplies()
		{
		}

		private void PerformAction()
		{
		}

		protected virtual bool CheckSuccess(global::ScheduleOne.ItemFramework.ItemInstance usedItem)
		{
			return false;
		}

		private void StopAllRoutines()
		{
		}

		protected virtual string[] GetRequiredItemSuitableIDs(global::ScheduleOne.Growing.GrowContainer growContainer)
		{
			return null;
		}

		private bool DoesTaskRequireItem(global::ScheduleOne.Growing.GrowContainer growContainer, out string[] suitableItemIDs)
		{
			suitableItemIDs = null;
			return false;
		}

		private bool IsRequiredItemInInventory(global::ScheduleOne.Growing.GrowContainer growContainer)
		{
			return false;
		}

		private bool DoSuppliesContainRequiredItem(global::ScheduleOne.Growing.GrowContainer growContainer)
		{
			return false;
		}

		private global::ScheduleOne.ItemFramework.ItemSlot GetSuppliesSlotContainingRequiredItem(string[] suitableItemIDs)
		{
			return null;
		}

		protected global::ScheduleOne.ItemFramework.ItemSlot GetItemSlotContainingRequiredItem(global::ScheduleOne.ItemFramework.IItemSlotOwner itemSlotOwner, string[] suitableItemIDs)
		{
			return null;
		}

		private bool IsAtSupplies()
		{
			return false;
		}

		private bool IsAtGrowContainer()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EGrowContainerBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
