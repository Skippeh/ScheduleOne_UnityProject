using System.Collections.Generic;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs
{
	public class NPCInventory : NetworkBehaviour, IItemSlotOwner
	{
		public delegate bool ItemFilter(ItemInstance item);

		public InteractableObject PickpocketIntObj;

		public const float COOLDOWN = 30f;

		[Header("Settings")]
		public int SlotCount;

		public bool CanBePickpocketed;

		public bool ClearInventoryEachNight;

		public ItemDefinition[] TestItems;

		[Header("Random cash")]
		public bool RandomCash;

		public int RandomCashMin;

		public int RandomCashMax;

		[Header("Random items")]
		public bool RandomItems;

		public StorableItemDefinition[] RandomItemDefinitions;

		public int RandomItemMin;

		public int RandomItemMax;

		private NPC npc;

		public UnityEvent onContentsChanged;

		private float timeOnLastExpire;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCInventoryAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCInventoryAssembly_002DCSharp_002Edll_Excuted;

		public List<ItemSlot> ItemSlots { get; set; }

		public virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void OnSleepStart()
		{
		}

		public int GetItemCount()
		{
			return 0;
		}

		public int _GetItemAmount(string id)
		{
			return 0;
		}

		public int GetIdenticalItemAmount(ItemInstance item)
		{
			return 0;
		}

		public int GetMaxItemCount(string[] ids)
		{
			return 0;
		}

		public bool CanItemFit(ItemInstance item, int quantity = 1)
		{
			return false;
		}

		public int HowManyCanFit(ItemInstance item)
		{
			return 0;
		}

		public void InsertItem(ItemInstance item, bool network = true)
		{
		}

		public ItemInstance GetFirstItem(string id, ItemFilter filter = null)
		{
			return null;
		}

		public ItemInstance GetFirstIdenticalItem(ItemInstance item, ItemFilter filter = null)
		{
			return null;
		}

		protected virtual void InventoryContentsChanged()
		{
		}

		public int GetTotalItemCount()
		{
			return 0;
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private void StartPickpocket()
		{
		}

		public void ExpirePickpocket()
		{
		}

		private bool CanPickpocket()
		{
			return false;
		}

		[Button]
		public void PrintInventoryContents()
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
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

		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPCInventory_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
