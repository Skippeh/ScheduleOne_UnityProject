using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Storage
{
	public class StorageEntity : NetworkBehaviour, IItemSlotOwner
	{
		public enum EAccessSettings
		{
			Closed = 0,
			SinglePlayerOnly = 1,
			Full = 2
		}

		public const int MAX_SLOTS = 20;

		[Header("Settings")]
		public string StorageEntityName;

		public string StorageEntitySubtitle;

		[Range(1f, 20f)]
		public int SlotCount;

		public bool EmptyOnSleep;

		[Header("Display Settings")]
		[Tooltip("How many rows to enforce when display contents in StorageMenu")]
		[Range(1f, 5f)]
		public int DisplayRowCount;

		[Header("Access Settings")]
		public EAccessSettings AccessSettings;

		[Tooltip("If the distance between this StorageEntity and the player is greater than this, the StorageMenu will be closed.")]
		[Range(0f, 10f)]
		public float MaxAccessDistance;

		[Header("Events")]
		[Tooltip("Invoked when this StorageEntity is accessed in the StorageMenu")]
		public UnityEvent onOpened;

		[Tooltip("Invoked when the StorageMenu is closed.")]
		public UnityEvent onClosed;

		[Tooltip("Invoked when the contents change in any way. i.e. an item is added, removed, or the quantity of an item changes.")]
		public UnityEvent onContentsChanged;

		private bool NetworkInitialize___EarlyScheduleOne_002EStorage_002EStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EStorage_002EStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpened => false;

		public Player CurrentAccessor { get; protected set; }

		public int ItemCount => 0;

		public List<ItemSlot> ItemSlots { get; set; }

		public virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		public Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			return null;
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

		protected virtual void ContentsChanged()
		{
		}

		public List<ItemInstance> GetAllItems()
		{
			return null;
		}

		public void LoadFromItemSet(ItemInstance[] items)
		{
		}

		public void ClearContents()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		protected virtual void OnOpened()
		{
		}

		protected virtual void OnClosed()
		{
		}

		public virtual bool CanBeOpened()
		{
			return false;
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendAccessor(NetworkObject accessor)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetAccessor(NetworkObject accessor)
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

		private void RpcWriter___Server_SendAccessor_3323014238(NetworkObject accessor)
		{
		}

		private void RpcLogic___SendAccessor_3323014238(NetworkObject accessor)
		{
		}

		private void RpcReader___Server_SendAccessor_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAccessor_3323014238(NetworkObject accessor)
		{
		}

		private void RpcLogic___SetAccessor_3323014238(NetworkObject accessor)
		{
		}

		private void RpcReader___Observers_SetAccessor_3323014238(PooledReader PooledReader0, Channel channel)
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

		protected virtual void Awake_UserLogic_ScheduleOne_002EStorage_002EStorageEntity_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
