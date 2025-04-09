using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class ItemData : SaveData
	{
		public string ID;

		public int Quantity;

		public ItemData(string iD, int quantity)
		{
		}
	}
}
