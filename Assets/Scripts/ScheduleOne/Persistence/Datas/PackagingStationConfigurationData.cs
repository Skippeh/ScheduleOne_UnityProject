using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class PackagingStationConfigurationData : SaveData
	{
		public ObjectFieldData Destination;

		public PackagingStationConfigurationData(ObjectFieldData destination)
		{
		}
	}
}
