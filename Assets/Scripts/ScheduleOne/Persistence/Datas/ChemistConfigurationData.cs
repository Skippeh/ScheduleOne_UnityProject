using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class ChemistConfigurationData : SaveData
	{
		public ObjectFieldData Bed;

		public ObjectListFieldData Stations;

		public ChemistConfigurationData(ObjectFieldData bed, ObjectListFieldData stations)
		{
		}
	}
}
