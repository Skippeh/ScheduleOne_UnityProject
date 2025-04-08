namespace ScheduleOne.Persistence.Datas
{
	public class ChemistryStationData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public global::ScheduleOne.Persistence.Datas.ItemSet InputContents;

		public global::ScheduleOne.Persistence.Datas.ItemSet OutputContents;

		public string CurrentRecipeID;

		public global::ScheduleOne.ItemFramework.EQuality ProductQuality;

		public global::UnityEngine.Color StartLiquidColor;

		public float LiquidLevel;

		public int CurrentTime;

		public ChemistryStationData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, global::ScheduleOne.Persistence.Datas.ItemSet inputContents, global::ScheduleOne.Persistence.Datas.ItemSet outputContents, string currentRecipeID, global::ScheduleOne.ItemFramework.EQuality productQuality, global::UnityEngine.Color startLiquidColor, float liquidLevel, int currentTime)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
