namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class GameDateTimeData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public int ElapsedDays;

		public int Time;

		public GameDateTimeData(int _elapsedDays, int _time)
		{
		}

		public GameDateTimeData(global::ScheduleOne.GameTime.GameDateTime gameDateTime)
		{
		}
	}
}
