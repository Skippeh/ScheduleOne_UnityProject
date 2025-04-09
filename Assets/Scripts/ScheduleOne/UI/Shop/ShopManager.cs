using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;

namespace ScheduleOne.UI.Shop
{
	public class ShopManager : NetworkSingleton<ShopManager>, IBaseSaveable, ISaveable
	{
		private ShopManagerLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EUI_002EShop_002EShopManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EUI_002EShop_002EShopManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

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

		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendStock(string shopCode, string itemID, int stock)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetStock(NetworkConnection conn, string shopCode, string itemID, int stock)
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

		private void RpcReader___Server_SendStock_15643032(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		public void RpcLogic___SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		private void RpcReader___Observers_SetStock_3509965635(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock)
		{
		}

		private void RpcReader___Target_SetStock_3509965635(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
