namespace ScheduleOne.Persistence.Datas
{
	public class MushroomBedData : global::ScheduleOne.Persistence.Datas.GrowContainerData
	{
		public global::ScheduleOne.Persistence.Datas.ShroomColonyData ShroomColonyData;

		public MushroomBedData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, string[] appliedAdditives, global::ScheduleOne.Persistence.Datas.ShroomColonyData colonyData)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0, null, 0f, 0, 0f, null)
		{
		}
	}
}
