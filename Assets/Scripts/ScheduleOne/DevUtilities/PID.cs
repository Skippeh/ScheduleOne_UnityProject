namespace ScheduleOne.DevUtilities
{
	[global::System.Serializable]
	public class PID
	{
		public float pFactor;

		public float iFactor;

		public float dFactor;

		private float integral;

		private float lastError;

		public PID(float pFactor, float iFactor, float dFactor)
		{
		}

		public float Update(float setpoint, float actual, float timeFrame)
		{
			return 0f;
		}
	}
}
