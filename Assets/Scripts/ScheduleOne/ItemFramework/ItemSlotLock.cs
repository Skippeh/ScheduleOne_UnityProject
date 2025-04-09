using FishNet.Object;

namespace ScheduleOne.ItemFramework
{
	public class ItemSlotLock
	{
		public ItemSlot Slot { get; protected set; }

		public NetworkObject LockOwner { get; protected set; }

		public string LockReason { get; protected set; }

		public ItemSlotLock(ItemSlot slot, NetworkObject lockOwner, string lockReason)
		{
		}
	}
}
