namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class BrickPressConfigurationData : global::ScheduleOne.Persistence.Datas.RenamableConfigurationData
	{
		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public BrickPressConfigurationData(global::ScheduleOne.Persistence.Datas.StringFieldData name, global::ScheduleOne.Persistence.Datas.ObjectFieldData destination)
			: base(null)
		{
		}
	}
}
