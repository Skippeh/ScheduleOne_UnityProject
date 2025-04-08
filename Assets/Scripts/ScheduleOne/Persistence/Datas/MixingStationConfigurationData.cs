namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class MixingStationConfigurationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public global::ScheduleOne.Persistence.Datas.NumberFieldData Threshold;

		public MixingStationConfigurationData(global::ScheduleOne.Persistence.Datas.ObjectFieldData destination, global::ScheduleOne.Persistence.Datas.NumberFieldData threshold)
		{
		}
	}
}
