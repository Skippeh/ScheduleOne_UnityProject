namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class GenericSaveablesData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.GenericSaveData[] Saveables;

		public GenericSaveablesData(global::ScheduleOne.Persistence.Datas.GenericSaveData[] saveables)
		{
		}
	}
}
