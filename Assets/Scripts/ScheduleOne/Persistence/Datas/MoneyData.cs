namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class MoneyData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public float OnlineBalance;

		public float Networth;

		public float LifetimeEarnings;

		public float WeeklyDepositSum;

		public MoneyData(float onlineBalance, float netWorth, float lifetimeEarnings, float weeklyDepositSum)
		{
		}
	}
}
