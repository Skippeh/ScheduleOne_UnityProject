namespace ScheduleOne.Storage
{
	public class PalletSlot : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		public global::System.Action onPalletAdded;

		public global::System.Action onPalletRemoved;

		public global::System.Guid GUID { get; protected set; }

		public global::ScheduleOne.Storage.Pallet occupant { get; protected set; }

		public void SetGUID(global::System.Guid guid)
		{
		}

		public void SetOccupant(global::ScheduleOne.Storage.Pallet _occupant)
		{
		}
	}
}
