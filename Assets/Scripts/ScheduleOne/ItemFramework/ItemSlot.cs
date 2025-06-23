namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	public class ItemSlot
	{
		public global::System.Action onItemDataChanged;

		public global::System.Action onItemInstanceChanged;

		public global::System.Action onLocked;

		public global::System.Action onUnlocked;

		public global::System.Action onFilterChange;

		public global::ScheduleOne.ItemFramework.ItemInstance ItemInstance { get; protected set; }

		public global::ScheduleOne.ItemFramework.IItemSlotOwner SlotOwner { get; protected set; }

		private int SlotIndex => 0;

		public int Quantity => 0;

		public bool IsAtCapacity => false;

		public bool IsLocked => false;

		public global::ScheduleOne.ItemFramework.ItemSlotLock ActiveLock { get; protected set; }

		public bool IsRemovalLocked { get; protected set; }

		public bool IsAddLocked { get; protected set; }

		protected global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemFilter> HardFilters { get; set; }

		public bool CanPlayerSetFilter { get; set; }

		public global::ScheduleOne.ItemFramework.SlotFilter PlayerFilter { get; set; }

		public global::ScheduleOne.ItemFramework.ItemSlotSiblingSet SiblingSet { get; set; }

		public void SetSlotOwner(global::ScheduleOne.ItemFramework.IItemSlotOwner owner)
		{
		}

		public void SetSiblingSet(global::ScheduleOne.ItemFramework.ItemSlotSiblingSet set)
		{
		}

		public ItemSlot()
		{
		}

		public ItemSlot(bool canPlayerSetFilter = false)
		{
		}

		public void ReplicateStoredInstance()
		{
		}

		public virtual void SetStoredItem(global::ScheduleOne.ItemFramework.ItemInstance instance, bool _internal = false)
		{
		}

		public virtual void InsertItem(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public virtual void AddItem(global::ScheduleOne.ItemFramework.ItemInstance item, bool _internal = false)
		{
		}

		public virtual void ClearStoredInstance(bool _internal = false)
		{
		}

		public void SetQuantity(int amount, bool _internal = false)
		{
		}

		public void ChangeQuantity(int change, bool _internal = false)
		{
		}

		protected virtual void ItemDataChanged()
		{
		}

		protected virtual void ClearItemInstanceRequested()
		{
		}

		public void AddFilter(global::ScheduleOne.ItemFramework.ItemFilter filter)
		{
		}

		public void ApplyLock(global::FishNet.Object.NetworkObject lockOwner, string lockReason, bool _internal = false)
		{
		}

		public void RemoveLock(bool _internal = false)
		{
		}

		public void SetIsRemovalLocked(bool locked)
		{
		}

		public void SetIsAddLocked(bool locked)
		{
		}

		public virtual bool DoesItemMatchHardFilters(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return false;
		}

		public virtual bool DoesItemMatchPlayerFilters(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return false;
		}

		public void SetFilterable(bool filterable)
		{
		}

		public void SetPlayerFilter(global::ScheduleOne.ItemFramework.SlotFilter filter, bool _internal = false)
		{
		}

		public virtual int GetCapacityForItem(global::ScheduleOne.ItemFramework.ItemInstance item, bool checkPlayerFilters = false)
		{
			return 0;
		}

		public virtual bool CanSlotAcceptCash()
		{
			return false;
		}

		public static bool TryInsertItemIntoSet(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> ItemSlots, global::ScheduleOne.ItemFramework.ItemInstance item)
		{
			return false;
		}
	}
}
