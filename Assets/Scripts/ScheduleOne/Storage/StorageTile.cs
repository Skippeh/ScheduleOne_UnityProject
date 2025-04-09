using System;
using UnityEngine;

namespace ScheduleOne.Storage
{
	public class StorageTile : MonoBehaviour
	{
		public int x;

		public int y;

		[SerializeField]
		public StorageGrid ownerGrid;

		public Action onOccupantChanged;

		public StorageGrid _ownerGrid => null;

		public StoredItem occupant { get; protected set; }

		public void InitializeStorageTile(int _x, int _y, float _available_Offset, StorageGrid _ownerGrid)
		{
		}

		public void SetOccupant(StoredItem occ)
		{
		}
	}
}
