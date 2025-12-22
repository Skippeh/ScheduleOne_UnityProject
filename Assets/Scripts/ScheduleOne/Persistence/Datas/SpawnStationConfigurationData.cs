namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class SpawnStationConfigurationData : global::ScheduleOne.Persistence.Datas.RenamableConfigurationData
	{
		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public SpawnStationConfigurationData(global::ScheduleOne.Persistence.Datas.StringFieldData name, global::ScheduleOne.Persistence.Datas.ObjectFieldData destination)
			: base(null)
		{
		}
	}
}
