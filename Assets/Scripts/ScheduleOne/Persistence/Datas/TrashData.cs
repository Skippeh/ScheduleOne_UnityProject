namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class TrashData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.TrashItemData[] Items;

		public TrashData(global::ScheduleOne.Persistence.Datas.TrashItemData[] trash)
		{
		}
	}
}
