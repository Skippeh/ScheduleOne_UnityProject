namespace ScheduleOne.UI.Shop
{
	public class ShopManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.UI.Shop.ShopManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		private global::ScheduleOne.Persistence.Loaders.ShopManagerLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EUI_002EShop_002EShopManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EUI_002EShop_002EShopManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		protected override void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendStock(string shopCode, string itemID, int stock)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetStock(global::FishNet.Connection.NetworkConnection conn, string shopCode, string itemID, int stock)
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

		private void RpcWriter___Server_SendStock_15643032(string shopCode, string itemID, int stock)
		{
		}

		public void RpcLogic___SendStock_15643032(string shopCode, string itemID, int stock)
		{
		}

		private void RpcReader___Server_SendStock_15643032(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetStock_3509965635(global::FishNet.Connection.NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		public void RpcLogic___SetStock_3509965635(global::FishNet.Connection.NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		private void RpcReader___Observers_SetStock_3509965635(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetStock_3509965635(global::FishNet.Connection.NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		private void RpcReader___Target_SetStock_3509965635(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
