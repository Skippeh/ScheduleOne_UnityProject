namespace ScheduleOne.ItemFramework
{
	public class ItemSlotLock
	{
		public global::ScheduleOne.ItemFramework.ItemSlot Slot { get; protected set; }

		public global::FishNet.Object.NetworkObject LockOwner { get; protected set; }

		public string LockReason { get; protected set; }

		public ItemSlotLock(global::ScheduleOne.ItemFramework.ItemSlot slot, global::FishNet.Object.NetworkObject lockOwner, string lockReason)
		{
		}
	}
}
