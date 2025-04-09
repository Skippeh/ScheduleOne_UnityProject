using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class TimeData : SaveData
	{
		public int TimeOfDay;

		public int ElapsedDays;

		public int Playtime;

		public TimeData(int timeOfDay, int elapsedDays, int playtime)
		{
		}
	}
}
