using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class MixingStationConfigurationData : SaveData
	{
		public ObjectFieldData Destination;

		public NumberFieldData Threshold;

		public MixingStationConfigurationData(ObjectFieldData destination, NumberFieldData threshold)
		{
		}
	}
}
