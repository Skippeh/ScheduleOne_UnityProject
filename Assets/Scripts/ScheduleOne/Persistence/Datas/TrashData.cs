namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class TrashData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.TrashItemData[] Items;

		public global::ScheduleOne.Persistence.Datas.TrashGeneratorData[] Generators;

		public TrashData(global::ScheduleOne.Persistence.Datas.TrashItemData[] trash, global::ScheduleOne.Persistence.Datas.TrashGeneratorData[] generators)
		{
		}
	}
}
