namespace ScheduleOne.Cartel
{
	public class CartelDealer : global::ScheduleOne.Economy.Dealer
	{
		public const float DEALER_DEFEATED_INFLUENCE_CHANGE = -0.1f;

		public const int PRODUCT_COUNT_MIN = 2;

		public const int PRODUCT_COUNT_MAX = 4;

		public const int PRODUCT_QUANTITY_MIN = 1;

		public const int PRODUCT_QUANTITY_MAX = 10;

		[global::UnityEngine.Header("Cartel Dealer Inventory Settings")]
		public global::ScheduleOne.Product.ProductDefinition[] RandomProducts;

		public global::ScheduleOne.ItemFramework.EQuality ProductQuality;

		public global::ScheduleOne.Product.Packaging.PackagingDefinition DefaultPackaging;

		private global::ScheduleOne.Cartel.CartelGoonAppearance appearance;

		private bool NetworkInitialize___EarlyScheduleOne_002ECartel_002ECartelDealerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECartel_002ECartelDealerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsAcceptingDeals { get; private set; }

		private global::ScheduleOne.Cartel.GoonPool GoonPool => null;

		protected override void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void RandomizeInventory()
		{
		}

		public void RandomizeAppearance()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ConfigureGoonSettings(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		public void SetIsAcceptingDeals(bool accepting)
		{
		}

		public bool CanCurrentlyAcceptDeal()
		{
			return false;
		}

		private void DiedOrKnockedOut()
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

		private void RpcWriter___Observers_ConfigureGoonSettings_3427656873(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		private void RpcLogic___ConfigureGoonSettings_3427656873(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		private void RpcReader___Observers_ConfigureGoonSettings_3427656873(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ConfigureGoonSettings_3427656873(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Cartel.CartelGoonAppearance appearance, float moveSpeed)
		{
		}

		private void RpcReader___Target_ConfigureGoonSettings_3427656873(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
