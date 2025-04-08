namespace ScheduleOne.Persistence.Datas
{
	public class ToggleableItemData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public bool IsOn;

		public ToggleableItemData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, bool isOn)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
