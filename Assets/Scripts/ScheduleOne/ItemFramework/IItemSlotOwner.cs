using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;

namespace ScheduleOne.ItemFramework
{
	public interface IItemSlotOwner
	{
		List<ItemSlot> ItemSlots { get; set; }

		void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance);

		void SetItemSlotQuantity(int itemSlotIndex, int quantity);

		void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason);

		void SendItemsToClient(NetworkConnection conn)
		{
		}

		int GetTotalItemCount()
		{
			return 0;
		}

		int GetItemCount(string id)
		{
			return 0;
		}
	}
}
