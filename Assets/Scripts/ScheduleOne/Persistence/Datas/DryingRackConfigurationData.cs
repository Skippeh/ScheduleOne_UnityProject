namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class DryingRackConfigurationData : global::ScheduleOne.Persistence.Datas.RenamableConfigurationData
	{
		public global::ScheduleOne.Persistence.Datas.QualityFieldData TargetQuality;

		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public global::ScheduleOne.Persistence.Datas.NumberFieldData StartThreshold;

		public DryingRackConfigurationData(global::ScheduleOne.Persistence.Datas.StringFieldData name, global::ScheduleOne.Persistence.Datas.QualityFieldData targetquality, global::ScheduleOne.Persistence.Datas.ObjectFieldData destination, global::ScheduleOne.Persistence.Datas.NumberFieldData startThreshold)
			: base(null)
		{
		}
	}
}
