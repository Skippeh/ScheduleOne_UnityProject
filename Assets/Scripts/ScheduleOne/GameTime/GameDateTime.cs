namespace ScheduleOne.GameTime
{
	[global::System.Serializable]
	public struct GameDateTime
	{
		public int elapsedDays;

		public int time;

		public GameDateTime(int _elapsedDays, int _time)
		{
			elapsedDays = 0;
			time = 0;
		}

		public GameDateTime(int _minSum)
		{
			elapsedDays = 0;
			time = 0;
		}

		public GameDateTime(global::ScheduleOne.Persistence.Datas.GameDateTimeData data)
		{
			elapsedDays = 0;
			time = 0;
		}

		public int GetMinSum()
		{
			return 0;
		}

		public global::ScheduleOne.GameTime.GameDateTime AddMins(int mins)
		{
			return default(global::ScheduleOne.GameTime.GameDateTime);
		}

		public global::ScheduleOne.GameTime.GameDateTime GetCopy()
		{
			return default(global::ScheduleOne.GameTime.GameDateTime);
		}

		public static global::ScheduleOne.GameTime.GameDateTime operator +(global::ScheduleOne.GameTime.GameDateTime a, global::ScheduleOne.GameTime.GameDateTime b)
		{
			return default(global::ScheduleOne.GameTime.GameDateTime);
		}

		public static global::ScheduleOne.GameTime.GameDateTime operator -(global::ScheduleOne.GameTime.GameDateTime a, global::ScheduleOne.GameTime.GameDateTime b)
		{
			return default(global::ScheduleOne.GameTime.GameDateTime);
		}

		public static bool operator >(global::ScheduleOne.GameTime.GameDateTime a, global::ScheduleOne.GameTime.GameDateTime b)
		{
			return false;
		}

		public static bool operator <(global::ScheduleOne.GameTime.GameDateTime a, global::ScheduleOne.GameTime.GameDateTime b)
		{
			return false;
		}
	}
}
