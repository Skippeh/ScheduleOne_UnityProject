using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class BrickPressConfigurationData : SaveData
	{
		public ObjectFieldData Destination;

		public BrickPressConfigurationData(ObjectFieldData destination)
		{
		}
	}
}
