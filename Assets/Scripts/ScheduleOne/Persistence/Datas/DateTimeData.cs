namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class DateTimeData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public int Year;

		public int Month;

		public int Day;

		public int Hour;

		public int Minute;

		public int Second;

		public DateTimeData(global::System.DateTime date)
		{
		}

		public global::System.DateTime GetDateTime()
		{
			return default(global::System.DateTime);
		}
	}
}
