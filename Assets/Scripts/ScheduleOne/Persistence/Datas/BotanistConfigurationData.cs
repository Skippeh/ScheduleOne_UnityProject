using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class BotanistConfigurationData : SaveData
	{
		public ObjectFieldData Bed;

		public ObjectFieldData Supplies;

		public ObjectListFieldData Pots;

		public BotanistConfigurationData(ObjectFieldData bed, ObjectFieldData supplies, ObjectListFieldData pots)
		{
		}
	}
}
