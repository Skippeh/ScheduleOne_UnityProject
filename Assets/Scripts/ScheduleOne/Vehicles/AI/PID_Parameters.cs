namespace ScheduleOne.Vehicles.AI
{
	[global::System.Serializable]
	public struct PID_Parameters
	{
		public float P;

		public float I;

		public float D;

		public PID_Parameters(float P, float I, float D)
		{
			this.P = 0f;
			this.I = 0f;
			this.D = 0f;
		}
	}
}
