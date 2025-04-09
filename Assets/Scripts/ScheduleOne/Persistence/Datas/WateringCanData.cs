using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class WateringCanData : ItemData
	{
		public float CurrentFillAmount;

		public WateringCanData(string iD, int quantity, float currentFillLevel)
			: base(null, 0)
		{
		}
	}
}
