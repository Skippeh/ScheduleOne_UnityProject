namespace ScheduleOne.Storage
{
	public class StorageEntity : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.ItemFramework.IItemSlotOwner
	{
		public enum EAccessSettings
		{
			Closed = 0,
			SinglePlayerOnly = 1,
			Full = 2
		}

		public const int MAX_SLOTS = 20;

		[global::UnityEngine.Header("Settings")]
		public string StorageEntityName;

		public string StorageEntitySubtitle;

		[global::UnityEngine.Range(1f, 20f)]
		public int SlotCount;

		public bool EmptyOnSleep;

		public bool SlotsAreFilterable;

		[global::UnityEngine.Header("Display Settings")]
		[global::UnityEngine.Tooltip("How many rows to enforce when display contents in StorageMenu")]
		[global::UnityEngine.Range(1f, 5f)]
		public int DisplayRowCount;

		[global::UnityEngine.Header("Access Settings")]
		public global::ScheduleOne.Storage.StorageEntity.EAccessSettings AccessSettings;

		[global::UnityEngine.Tooltip("If the distance between this StorageEntity and the player is greater than this, the StorageMenu will be closed.")]
		[global::UnityEngine.Range(0f, 10f)]
		public float MaxAccessDistance;

		[global::UnityEngine.Header("Events")]
		[global::UnityEngine.Tooltip("Invoked when this StorageEntity is accessed in the StorageMenu")]
		public global::UnityEngine.Events.UnityEvent onOpened;

		[global::UnityEngine.Tooltip("Invoked when the StorageMenu is closed.")]
		public global::UnityEngine.Events.UnityEvent onClosed;

		[global::UnityEngine.Tooltip("Invoked when the contents change in any way. i.e. an item is added, removed, or the quantity of an item changes.")]
		public global::UnityEngine.Events.UnityEvent onContentsChanged;

		private bool NetworkInitialize___EarlyScheduleOne_002EStorage_002EStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EStorage_002EStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpened => false;

		public global::ScheduleOne.PlayerScripts.Player CurrentAccessor { get; protected set; }

		public int ItemCount => 0;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> ItemSlots { get; set; }

		public virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void GetNetworth(global::ScheduleOne.Money.MoneyManager.FloatContainer container)
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Storage.StorableItemInstance, int> GetContentsDictionary()
		{
			return null;
		}

		public bool CanItemFit(global::ScheduleOne.ItemFramework.ItemInstance item, int quantity = 1)
		{
			return false;
		}

		public int HowManyCanFit(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return 0;
		}

		public void InsertItem(global::ScheduleOne.ItemFramework.ItemInstance item, bool network = true)
		{
		}

		protected virtual void ContentsChanged()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> GetAllItems()
		{
			return null;
		}

		public void LoadFromItemSet(global::ScheduleOne.ItemFramework.ItemInstance[] items)
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

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendAccessor(global::FishNet.Object.NetworkObject accessor)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetAccessor(global::FishNet.Object.NetworkObject accessor)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		[global::FishNet.Object.TargetRpc(RunLocally = true)]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
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

		private void RpcWriter___Server_SendAccessor_3323014238(global::FishNet.Object.NetworkObject accessor)
		{
		}

		private void RpcLogic___SendAccessor_3323014238(global::FishNet.Object.NetworkObject accessor)
		{
		}

		private void RpcReader___Server_SendAccessor_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAccessor_3323014238(global::FishNet.Object.NetworkObject accessor)
		{
		}

		private void RpcLogic___SetAccessor_3323014238(global::FishNet.Object.NetworkObject accessor)
		{
		}

		private void RpcReader___Observers_SetAccessor_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetStoredInstance_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		public void RpcLogic___SetStoredInstance_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcReader___Server_SetStoredInstance_2652194801(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcLogic___SetStoredInstance_Internal_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance)
		{
		}

		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Server_SetItemSlotQuantity_1692629761(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetSlotLocked_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		public void RpcLogic___SetSlotLocked_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Server_SetSlotLocked_3170825843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcLogic___SetSlotLocked_Internal_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetSlotFilter_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		public void RpcLogic___SetSlotFilter_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcReader___Server_SetSlotFilter_527532783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcLogic___SetSlotFilter_Internal_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter)
		{
		}

		private void RpcReader___Target_SetSlotFilter_Internal_527532783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EStorage_002EStorageEntity_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
