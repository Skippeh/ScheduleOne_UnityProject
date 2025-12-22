namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class AirConditionerData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public global::ScheduleOne.Temperature.AirConditioner.EMode Mode;

		public AirConditionerData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, global::ScheduleOne.Temperature.AirConditioner.EMode mode)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
