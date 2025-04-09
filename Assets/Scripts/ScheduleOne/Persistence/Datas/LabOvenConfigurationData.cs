using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class LabOvenConfigurationData : SaveData
	{
		public ObjectFieldData Destination;

		public LabOvenConfigurationData(ObjectFieldData destination)
		{
		}
	}
}
