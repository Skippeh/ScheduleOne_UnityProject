using System;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.GameTime
{
	[Serializable]
	public struct GameDateTime
	{
		public int elapsedDays;

		public int time;

		public GameDateTime(int _elapsedDays, int _time)
		{
			elapsedDays = _elapsedDays;
			time = _time;
		}

		public GameDateTime(int _minSum)
		{
			elapsedDays = _minSum / 1440;
			int minSum = _minSum % 1440;
			if (_minSum < 0)
			{
				minSum = -_minSum % 1440;
			}
			time = TimeManager.Get24HourTimeFromMinSum(minSum);
		}

		public GameDateTime(GameDateTimeData data)
		{
			elapsedDays = data.ElapsedDays;
			time = data.Time;
		}

		public int GetMinSum()
		{
			return 0;
		}

		public GameDateTime AddMins(int mins)
		{
			return default(GameDateTime);
		}

		public static GameDateTime operator +(GameDateTime a, GameDateTime b)
		{
			return default(GameDateTime);
		}

		public static GameDateTime operator -(GameDateTime a, GameDateTime b)
		{
			return default(GameDateTime);
		}

		public static bool operator >(GameDateTime a, GameDateTime b)
		{
			return false;
		}

		public static bool operator <(GameDateTime a, GameDateTime b)
		{
			return false;
		}
	}
}
