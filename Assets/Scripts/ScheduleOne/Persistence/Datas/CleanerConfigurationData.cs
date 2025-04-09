using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class CleanerConfigurationData : SaveData
	{
		public ObjectFieldData Bed;

		public ObjectListFieldData Bins;

		public CleanerConfigurationData(ObjectFieldData bed, ObjectListFieldData bins)
		{
		}
	}
}
