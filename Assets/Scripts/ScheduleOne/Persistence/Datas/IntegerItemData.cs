using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class IntegerItemData : ItemData
	{
		public int Value;

		public IntegerItemData(string iD, int quantity, int value)
			: base(null, 0)
		{
		}
	}
}
