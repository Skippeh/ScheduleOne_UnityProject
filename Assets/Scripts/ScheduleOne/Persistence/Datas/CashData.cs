using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class CashData : ItemData
	{
		public float CashBalance;

		public CashData(string iD, int quantity, float cashBalance)
			: base(null, 0)
		{
		}
	}
}
