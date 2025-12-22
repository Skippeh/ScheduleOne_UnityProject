namespace ScheduleOne.NPCs.Behaviour
{
	public class WaterPotBehaviour : global::ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour
	{
		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable Equippable;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EWaterPotBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EWaterPotBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
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

		public override bool AreTaskConditionsMetForContainer(global::ScheduleOne.Growing.GrowContainer container)
		{
			return false;
		}

		public virtual bool AreTaskConditionsMetForContainer(global::ScheduleOne.Growing.GrowContainer container, float wateringThreshold)
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002EWaterPotBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
