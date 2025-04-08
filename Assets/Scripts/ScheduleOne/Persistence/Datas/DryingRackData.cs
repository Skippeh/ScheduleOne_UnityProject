namespace ScheduleOne.Persistence.Datas
{
	public class DryingRackData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public global::ScheduleOne.Persistence.Datas.ItemSet Input;

		public global::ScheduleOne.Persistence.Datas.ItemSet Output;

		public global::ScheduleOne.ObjectScripts.DryingOperation[] DryingOperations;

		public DryingRackData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, global::ScheduleOne.Persistence.Datas.ItemSet input, global::ScheduleOne.Persistence.Datas.ItemSet output, global::ScheduleOne.ObjectScripts.DryingOperation[] dryingOperations)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
