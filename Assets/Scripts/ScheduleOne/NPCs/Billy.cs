namespace ScheduleOne.NPCs
{
	public class Billy : global::ScheduleOne.NPCs.NPC
	{
		public const int REQUESTED_PRODUCT_AMOUNT = 20;

		public const string REQUESTED_PRODUCT_ID = "cocaine";

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Quests.Contract TradeContract;

		public global::ScheduleOne.ItemFramework.ItemDefinition RDXDefinition;

		private global::ScheduleOne.Economy.Customer customerComp;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBillyAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBillyAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		public void OpenRDXTradeHandover()
		{
		}

		private void HandoverOutcome(global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> givenItems, float payment)
		{
		}

		private float GetSucccessChance(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, float price)
		{
			return 0f;
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBilly_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
