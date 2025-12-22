namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class PackagingStationConfigurationData : global::ScheduleOne.Persistence.Datas.RenamableConfigurationData
	{
		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public PackagingStationConfigurationData(global::ScheduleOne.Persistence.Datas.StringFieldData name, global::ScheduleOne.Persistence.Datas.ObjectFieldData destination)
			: base(null)
		{
		}
	}
}
