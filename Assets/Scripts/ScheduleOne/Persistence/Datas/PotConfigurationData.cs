using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class PotConfigurationData : SaveData
	{
		public ItemFieldData Seed;

		public ItemFieldData Additive1;

		public ItemFieldData Additive2;

		public ItemFieldData Additive3;

		public ObjectFieldData Destination;

		public PotConfigurationData(ItemFieldData seed, ItemFieldData additive1, ItemFieldData additive2, ItemFieldData additive3, ObjectFieldData destination)
		{
		}
	}
}
