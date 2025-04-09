using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class LaunderOperationData : SaveData
	{
		public float Amount;

		public int MinutesSinceStarted;

		public LaunderOperationData(float amount, int minutesSinceStarted)
		{
		}
	}
}
