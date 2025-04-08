namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class TimeData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public int TimeOfDay;

		public int ElapsedDays;

		public int Playtime;

		public TimeData(int timeOfDay, int elapsedDays, int playtime)
		{
		}
	}
}
