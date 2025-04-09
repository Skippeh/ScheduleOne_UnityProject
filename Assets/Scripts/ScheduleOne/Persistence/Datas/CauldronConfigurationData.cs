using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class CauldronConfigurationData : SaveData
	{
		public ObjectFieldData Destination;

		public CauldronConfigurationData(ObjectFieldData destination)
		{
		}
	}
}
