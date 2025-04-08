namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class PlaceableStorageData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public global::ScheduleOne.Persistence.Datas.ItemSet Contents;

		public PlaceableStorageData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, global::ScheduleOne.Persistence.Datas.ItemSet contents)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
