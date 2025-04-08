namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ProceduralGridItemData : global::ScheduleOne.Persistence.Datas.BuildableItemData
	{
		public int Rotation;

		public global::ScheduleOne.Persistence.Datas.FootprintMatchData[] FootprintMatches;

		public ProceduralGridItemData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, int rotation, global::ScheduleOne.Persistence.Datas.FootprintMatchData[] footprintMatches)
			: base(default(global::System.Guid), null, 0)
		{
		}
	}
}
