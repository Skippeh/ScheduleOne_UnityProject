using System;

namespace ScheduleOne.Vehicles.AI
{
	[Serializable]
	public struct PID_Parameters
	{
		public float P;

		public float I;

		public float D;

		public PID_Parameters(float P, float I, float D)
		{
			this.P = P;
			this.I = I;
			this.D = D;
		}
	}
}
