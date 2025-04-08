namespace ScheduleOne.Storage
{
	public class StorageTile : global::UnityEngine.MonoBehaviour
	{
		public int x;

		public int y;

		[global::UnityEngine.SerializeField]
		public global::ScheduleOne.Storage.StorageGrid ownerGrid;

		public global::System.Action onOccupantChanged;

		public global::ScheduleOne.Storage.StorageGrid _ownerGrid => null;

		public global::ScheduleOne.Storage.StoredItem occupant { get; protected set; }

		public void InitializeStorageTile(int _x, int _y, float _available_Offset, global::ScheduleOne.Storage.StorageGrid _ownerGrid)
		{
		}

		public void SetOccupant(global::ScheduleOne.Storage.StoredItem occ)
		{
		}
	}
}
