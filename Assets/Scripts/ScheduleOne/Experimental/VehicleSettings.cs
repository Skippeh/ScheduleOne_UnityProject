namespace ScheduleOne.Experimental
{
	[global::System.Serializable]
	public class VehicleSettings
	{
		public global::ScheduleOne.Experimental.WheelFrictionSettings ForwardFriction;

		public global::ScheduleOne.Experimental.WheelFrictionSettings SidewaysFriction;

		public global::ScheduleOne.Experimental.VehicleSettings Clone()
		{
			return null;
		}

		public global::ScheduleOne.Experimental.VehicleSettings Blend(global::ScheduleOne.Experimental.VehicleSettings other, float t)
		{
			return null;
		}
	}
}
