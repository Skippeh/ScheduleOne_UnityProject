namespace ScheduleOne.Vehicles.AI
{
	public class SteerPID
	{
		private float error_old;

		private float error_sum;

		public float GetNewValue(float error, global::ScheduleOne.Vehicles.AI.PID_Parameters pid_parameters)
		{
			return 0f;
		}

		public static float AddValueToAverage(float oldAverage, float valueToAdd, float count)
		{
			return 0f;
		}
	}
}
