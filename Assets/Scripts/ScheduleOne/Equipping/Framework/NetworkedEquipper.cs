namespace ScheduleOne.Equipping.Framework
{
	public abstract class NetworkedEquipper : global::FishNet.Object.NetworkBehaviour
	{
		[global::FishNet.Object.Synchronizing.SyncObject]
		private readonly global::FishNet.Object.Synchronizing.SyncList<global::ScheduleOne.Equipping.EquippedItemHandler> _networkEquippedItems;

		private global::System.Collections.Generic.List<global::ScheduleOne.Equipping.EquippedItemHandler> _allEquippedItems;

		private bool NetworkInitialize___EarlyScheduleOne_002EEquipping_002EFramework_002ENetworkedEquipperAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEquipping_002EFramework_002ENetworkedEquipperAssembly_002DCSharp_002Edll_Excuted;

		protected abstract global::ScheduleOne.Core.Equipping.Framework.IEquippableUser GetUser();

		public override void OnStartClient()
		{
		}

		public global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler Equip(global::ScheduleOne.Core.Equipping.Framework.EquippableData equippable, bool networked = true)
		{
			return null;
		}

		public global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler Equip(global::ScheduleOne.Core.Items.Framework.BaseItemInstance item, bool networked = true)
		{
			return null;
		}

		public void Unequip(global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler equippedItem)
		{
		}

		private void AddEquippedItem(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private void RemoveEquippedItem(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void Unequip_Server(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void Unequip_Client(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void AddNetworkedEquippedItem_Server(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void RemoveNetworkedEquippedItem_Server(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler CreateHandlerForEquippable(global::ScheduleOne.Core.Equipping.Framework.EquippableData equippable)
		{
			return null;
		}

		private void NetworkEquippedItems_OnChange(global::FishNet.Object.Synchronizing.SyncListOperation op, int index, global::ScheduleOne.Equipping.EquippedItemHandler oldItem, global::ScheduleOne.Equipping.EquippedItemHandler newItem, bool asServer)
		{
		}

		public void UnequipAll()
		{
		}

		private bool CanEquip(global::ScheduleOne.Core.Equipping.Framework.EquippableData equippable)
		{
			return false;
		}

		private bool IsRightHandOccupied()
		{
			return false;
		}

		private bool IsLeftHandOccupied()
		{
			return false;
		}

		private bool IsItemEquipped(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
			return false;
		}

		[global::ScheduleOne.Core.Button]
		public void PrintLists()
		{
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_Unequip_Server_897730888(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private void RpcLogic___Unequip_Server_897730888(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private void RpcReader___Server_Unequip_Server_897730888(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Unequip_Client_897730888(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private void RpcLogic___Unequip_Client_897730888(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private void RpcReader___Observers_Unequip_Client_897730888(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_AddNetworkedEquippedItem_Server_897730888(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private void RpcLogic___AddNetworkedEquippedItem_Server_897730888(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private void RpcReader___Server_AddNetworkedEquippedItem_Server_897730888(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RemoveNetworkedEquippedItem_Server_897730888(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private void RpcLogic___RemoveNetworkedEquippedItem_Server_897730888(global::ScheduleOne.Equipping.EquippedItemHandler handler)
		{
		}

		private void RpcReader___Server_RemoveNetworkedEquippedItem_Server_897730888(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
