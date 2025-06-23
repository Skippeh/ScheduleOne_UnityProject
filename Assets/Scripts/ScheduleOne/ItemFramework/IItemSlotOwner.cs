namespace ScheduleOne.ItemFramework
{
	public interface IItemSlotOwner
	{
		global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> ItemSlots { get; set; }

		void SetStoredInstance(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.ItemInstance instance);

		void SetItemSlotQuantity(int itemSlotIndex, int quantity);

		void SetSlotLocked(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, bool locked, global::FishNet.Object.NetworkObject lockOwner, string lockReason);

		void SetSlotFilter(global::FishNet.Connection.NetworkConnection conn, int itemSlotIndex, global::ScheduleOne.ItemFramework.SlotFilter filter);

		void SendItemSlotDataToClient(global::FishNet.Connection.NetworkConnection conn)
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
