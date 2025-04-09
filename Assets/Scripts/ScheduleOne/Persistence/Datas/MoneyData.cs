using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class MoneyData : SaveData
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
