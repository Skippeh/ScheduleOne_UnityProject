namespace ScheduleOne.Persistence.Datas
{
	public class SoilPourerData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public string SoilID;

		public SoilPourerData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string soilID)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
