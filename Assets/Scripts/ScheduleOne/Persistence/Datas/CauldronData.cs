namespace ScheduleOne.Persistence.Datas
{
	public class CauldronData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public global::ScheduleOne.Persistence.Datas.ItemSet Ingredients;

		public global::ScheduleOne.Persistence.Datas.ItemSet Liquid;

		public global::ScheduleOne.Persistence.Datas.ItemSet Output;

		public int RemainingCookTime;

		public global::ScheduleOne.ItemFramework.EQuality InputQuality;

		public CauldronData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, global::ScheduleOne.Persistence.Datas.ItemSet ingredients, global::ScheduleOne.Persistence.Datas.ItemSet liquid, global::ScheduleOne.Persistence.Datas.ItemSet output, int remainingCookTime, global::ScheduleOne.ItemFramework.EQuality inputQuality)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
