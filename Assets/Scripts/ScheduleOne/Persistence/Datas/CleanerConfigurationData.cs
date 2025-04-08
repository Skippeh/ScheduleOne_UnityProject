namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class CleanerConfigurationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Bed;

		public global::ScheduleOne.Persistence.Datas.ObjectListFieldData Bins;

		public CleanerConfigurationData(global::ScheduleOne.Persistence.Datas.ObjectFieldData bed, global::ScheduleOne.Persistence.Datas.ObjectListFieldData bins)
		{
		}
	}
}
