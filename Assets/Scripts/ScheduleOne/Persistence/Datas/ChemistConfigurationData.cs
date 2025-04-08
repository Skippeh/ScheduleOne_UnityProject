namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ChemistConfigurationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Bed;

		public global::ScheduleOne.Persistence.Datas.ObjectListFieldData Stations;

		public ChemistConfigurationData(global::ScheduleOne.Persistence.Datas.ObjectFieldData bed, global::ScheduleOne.Persistence.Datas.ObjectListFieldData stations)
		{
		}
	}
}
