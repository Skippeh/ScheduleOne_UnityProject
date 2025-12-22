namespace ScheduleOne.Persistence.Datas
{
	public class GrowContainerData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public string SoilID;

		public float SoilLevel;

		public int RemainingSoilUses;

		public float WaterLevel;

		public string[] AppliedAdditives;

		public GrowContainerData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, string[] appliedAdditives)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}

		public void ConvertOldAdditiveFormatToNew()
		{
		}
	}
}
