namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class LaunderOperationData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public float Amount;

		public int MinutesSinceStarted;

		public LaunderOperationData(float amount, int minutesSinceStarted)
		{
		}
	}
}
