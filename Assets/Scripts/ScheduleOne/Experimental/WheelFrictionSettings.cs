namespace ScheduleOne.Experimental
{
	[global::System.Serializable]
	public class WheelFrictionSettings
	{
		public float ExtremumSlip;

		public float ExtremumValue;

		public float AsymptoteSlip;

		public float AsymptoteValue;

		public float Stiffness;

		public global::ScheduleOne.Experimental.WheelFrictionSettings Blend(global::ScheduleOne.Experimental.WheelFrictionSettings other, float t)
		{
			return null;
		}
	}
}
