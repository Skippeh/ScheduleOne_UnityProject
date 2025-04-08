namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class GridItemData : global::ScheduleOne.Persistence.Datas.BuildableItemData
	{
		public string GridGUID;

		public global::UnityEngine.Vector2 OriginCoordinate;

		public int Rotation;

		public GridItemData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation)
			: base(default(global::System.Guid), null, 0)
		{
		}
	}
}
