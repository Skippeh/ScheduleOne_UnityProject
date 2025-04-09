using System;
using ScheduleOne.GameTime;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class GameDateTimeData : SaveData
	{
		public int ElapsedDays;

		public int Time;

		public GameDateTimeData(int _elapsedDays, int _time)
		{
		}

		public GameDateTimeData(GameDateTime gameDateTime)
		{
		}
	}
}
