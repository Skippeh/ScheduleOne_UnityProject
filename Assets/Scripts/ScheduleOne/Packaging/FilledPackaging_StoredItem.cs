using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	public class FilledPackaging_StoredItem : StoredItem
	{
		public FilledPackagingVisuals Visuals;

		public override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
		}

		public override GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			return null;
		}
	}
}
