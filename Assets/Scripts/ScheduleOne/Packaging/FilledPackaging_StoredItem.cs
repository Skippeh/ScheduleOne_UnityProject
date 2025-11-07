namespace ScheduleOne.Packaging
{
	public class FilledPackaging_StoredItem : global::ScheduleOne.Storage.StoredItem
	{
		public global::ScheduleOne.Product.MultiTypeVisualsSetter Visuals;

		public override void InitializeStoredItem(global::ScheduleOne.Storage.StorableItemInstance _item, global::ScheduleOne.Storage.StorageGrid grid, global::UnityEngine.Vector2 _originCoordinate, float _rotation)
		{
		}

		public override global::UnityEngine.GameObject CreateGhostModel(global::ScheduleOne.ItemFramework.ItemInstance _item, global::UnityEngine.Transform parent)
		{
			return null;
		}
	}
}
