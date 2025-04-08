namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class CashData : global::ScheduleOne.Persistence.Datas.ItemData
	{
		public float CashBalance;

		public CashData(string iD, int quantity, float cashBalance)
			: base(null, 0)
		{
		}
	}
}
