namespace ScheduleOne.ItemFramework
{
	public class CashPickup : global::ScheduleOne.ItemFramework.ItemPickup
	{
		public float Value;

		private bool NetworkInitialize___EarlyScheduleOne_002EItemFramework_002ECashPickupAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EItemFramework_002ECashPickupAssembly_002DCSharp_002Edll_Excuted;

		protected override void Hovered()
		{
		}

		protected override bool CanPickup()
		{
			return false;
		}

		protected override void Pickup()
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

		public override void Awake()
		{
		}
	}
}
