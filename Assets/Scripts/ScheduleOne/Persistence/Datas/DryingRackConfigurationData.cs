namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class DryingRackConfigurationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::ScheduleOne.Persistence.Datas.QualityFieldData TargetQuality;

		public global::ScheduleOne.Persistence.Datas.ObjectFieldData Destination;

		public DryingRackConfigurationData(global::ScheduleOne.Persistence.Datas.QualityFieldData targetquality, global::ScheduleOne.Persistence.Datas.ObjectFieldData destination)
		{
		}
	}
}
