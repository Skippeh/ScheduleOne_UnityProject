namespace ScheduleOne.Delivery
{
	public class DeliveryManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Delivery.DeliveryManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Delivery.DeliveryInstance> Deliveries;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Delivery.DeliveryInstance> onDeliveryCreated;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Delivery.DeliveryInstance> onDeliveryCompleted;

		private global::ScheduleOne.Persistence.Loaders.DeliveriesLoader loader;

		private global::System.Collections.Generic.List<string> writtenVehicles;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Delivery.DeliveryInstance, int> minsSinceVehicleEmpty;

		private bool NetworkInitialize___EarlyScheduleOne_002EDelivery_002EDeliveryManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EDelivery_002EDeliveryManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void OnMinPass()
		{
		}

		public bool IsLoadingBayFree(global::ScheduleOne.Property.Property destination, int loadingDockIndex)
		{
			return false;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendDelivery(global::ScheduleOne.Delivery.DeliveryInstance delivery)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void ReceiveDelivery(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Delivery.DeliveryInstance delivery)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetDeliveryState(string deliveryID, global::ScheduleOne.Delivery.EDeliveryStatus status)
		{
		}

		private global::ScheduleOne.Delivery.DeliveryInstance GetDelivery(string deliveryID)
		{
			return null;
		}

		public global::ScheduleOne.Delivery.DeliveryInstance GetDelivery(global::ScheduleOne.Property.Property destination)
		{
			return null;
		}

		public global::ScheduleOne.Delivery.DeliveryInstance GetActiveShopDelivery(global::ScheduleOne.UI.Phone.Delivery.DeliveryShop shop)
		{
			return null;
		}

		public global::ScheduleOne.UI.Shop.ShopInterface GetShopInterface(string shopName)
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
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

		private void RpcWriter___Server_SendDelivery_2813439055(global::ScheduleOne.Delivery.DeliveryInstance delivery)
		{
		}

		public void RpcLogic___SendDelivery_2813439055(global::ScheduleOne.Delivery.DeliveryInstance delivery)
		{
		}

		private void RpcReader___Server_SendDelivery_2813439055(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveDelivery_2795369214(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Delivery.DeliveryInstance delivery)
		{
		}

		private void RpcLogic___ReceiveDelivery_2795369214(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Delivery.DeliveryInstance delivery)
		{
		}

		private void RpcReader___Observers_ReceiveDelivery_2795369214(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveDelivery_2795369214(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Delivery.DeliveryInstance delivery)
		{
		}

		private void RpcReader___Target_ReceiveDelivery_2795369214(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetDeliveryState_316609003(string deliveryID, global::ScheduleOne.Delivery.EDeliveryStatus status)
		{
		}

		private void RpcLogic___SetDeliveryState_316609003(string deliveryID, global::ScheduleOne.Delivery.EDeliveryStatus status)
		{
		}

		private void RpcReader___Observers_SetDeliveryState_316609003(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EDelivery_002EDeliveryManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
