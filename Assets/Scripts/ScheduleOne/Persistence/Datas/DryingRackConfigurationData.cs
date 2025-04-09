using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class DryingRackConfigurationData : SaveData
	{
		public QualityFieldData TargetQuality;

		public ObjectFieldData Destination;

		public DryingRackConfigurationData(QualityFieldData targetquality, ObjectFieldData destination)
		{
		}
	}
}
