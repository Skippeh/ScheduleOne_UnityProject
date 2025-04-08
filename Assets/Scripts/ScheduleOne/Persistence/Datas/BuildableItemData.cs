namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class BuildableItemData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string GUID;

		public string ItemString;

		public int LoadOrder;

		public BuildableItemData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder)
		{
		}
	}
}
