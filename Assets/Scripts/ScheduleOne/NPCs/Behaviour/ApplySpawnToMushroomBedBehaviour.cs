namespace ScheduleOne.NPCs.Behaviour
{
	public class ApplySpawnToMushroomBedBehaviour : global::ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour
	{
		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EApplySpawnToMushroomBedBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EApplySpawnToMushroomBedBehaviourAssembly_002DCSharp_002Edll_Excuted;

		protected override float GetActionDuration()
		{
			return 0f;
		}

		protected override string GetAnimationBool()
		{
			return null;
		}

		protected override string[] GetRequiredItemSuitableIDs(global::ScheduleOne.Growing.GrowContainer growContainer)
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

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
