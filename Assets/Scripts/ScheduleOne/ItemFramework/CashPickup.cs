namespace ScheduleOne.ItemFramework
{
	public class CashPickup : global::ScheduleOne.ItemFramework.ItemPickup
	{
		[global::FishNet.Object.Synchronizing.SyncVar(OnChange = "ValueChanged")]
		public float Value;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.ObjectScripts.Cash.CashStackVisuals CashStackVisuals;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar___Value;

		private bool NetworkInitialize___EarlyScheduleOne_002EItemFramework_002ECashPickupAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EItemFramework_002ECashPickupAssembly_002DCSharp_002Edll_Excuted;

		public float SyncAccessor_Value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

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

		private void ValueChanged(float oldValue, float newValue, bool asServer)
		{
		}

		private void UpdateCashStackVisuals()
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

		public virtual bool ReadSyncVar___ScheduleOne_002EItemFramework_002ECashPickup(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
