using System;
using System.Collections.Generic;
using FishNet.Object;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	public class ItemSlot
	{
		public Action onItemDataChanged;

		public Action onItemInstanceChanged;

		public Action onLocked;

		public Action onUnlocked;

		public ItemInstance ItemInstance { get; protected set; }

		public IItemSlotOwner SlotOwner { get; protected set; }

		private int SlotIndex => 0;

		public int Quantity => 0;

		public bool IsAtCapacity => false;

		public bool IsLocked => false;

		public ItemSlotLock ActiveLock { get; protected set; }

		public bool IsRemovalLocked { get; protected set; }

		public bool IsAddLocked { get; protected set; }

		protected List<ItemFilter> Filters { get; set; }

		public void SetSlotOwner(IItemSlotOwner owner)
		{
		}

		public void ReplicateStoredInstance()
		{
		}

		public virtual void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
		}

		public virtual void InsertItem(ItemInstance item)
		{
		}

		public virtual void AddItem(ItemInstance item, bool _internal = false)
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

		public void AddFilter(ItemFilter filter)
		{
		}

		public void ApplyLock(NetworkObject lockOwner, string lockReason, bool _internal = false)
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

		public virtual bool DoesItemMatchFilters(ItemInstance item)
		{
			return false;
		}

		public virtual int GetCapacityForItem(ItemInstance item)
		{
			return 0;
		}

		public virtual bool CanSlotAcceptCash()
		{
			return false;
		}

		public static bool TryInsertItemIntoSet(List<ItemSlot> ItemSlots, ItemInstance item)
		{
			return false;
		}
	}
}
