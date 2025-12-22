namespace ScheduleOne.NPCs.Behaviour
{
	public class HarvestPotBehaviour : global::ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour
	{
		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable TrimmersEquippable;

		private global::ScheduleOne.ObjectScripts.Pot _pot;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EHarvestPotBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EHarvestPotBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		public override void AssignAndEnable(global::ScheduleOne.Growing.GrowContainer growContainer)
		{
		}

		protected override float GetActionDuration()
		{
			return 0f;
		}

		protected override string GetAnimationBool()
		{
			return null;
		}

		protected override global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable GetActionEquippable()
		{
			return null;
		}

		protected override void OnActionSuccess(global::ScheduleOne.ItemFramework.ItemInstance usedItem)
		{
		}

		private int GetQuantityToHarvest()
		{
			return 0;
		}

		public override bool AreTaskConditionsMetForContainer(global::ScheduleOne.Growing.GrowContainer container)
		{
			return false;
		}

		protected override bool CheckSuccess(global::ScheduleOne.ItemFramework.ItemInstance usedItem)
		{
			return false;
		}

		public bool DoesPotHaveValidDestination(global::ScheduleOne.ObjectScripts.Pot pot)
		{
			return false;
		}

		private int GetDestinationCapacityForItem(global::ScheduleOne.ObjectScripts.Pot pot, global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return 0;
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EHarvestPotBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
