namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class MixingStationConfigurationData : global::ScheduleOne.Persistence.Datas.RenamableConfigurationData
	{
		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public global::ScheduleOne.Persistence.Datas.NumberFieldData Threshold;

		public MixingStationConfigurationData(global::ScheduleOne.Persistence.Datas.StringFieldData name, global::ScheduleOne.Persistence.Datas.ObjectFieldData destination, global::ScheduleOne.Persistence.Datas.NumberFieldData threshold)
			: base(null)
		{
		}
	}
}
