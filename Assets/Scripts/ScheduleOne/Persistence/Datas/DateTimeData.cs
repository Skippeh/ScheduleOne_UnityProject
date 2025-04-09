using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class DateTimeData : SaveData
	{
		public int Year;

		public int Month;

		public int Day;

		public int Hour;

		public int Minute;

		public int Second;

		public DateTimeData(DateTime date)
		{
		}

		public DateTime GetDateTime()
		{
			return default(DateTime);
		}
	}
}
