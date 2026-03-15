namespace ScheduleOne.Experimental
{
	[global::UnityEngine.CreateAssetMenu(fileName = "WheelOverrideData", menuName = "ScriptableObjects/Vehicle/Wheel override Data")]
	public class WheelOverrideData : global::UnityEngine.ScriptableObject
	{
		[global::System.Flags]
		public enum OverrideCategory
		{
			None = 0,
			Wheels = 1
		}

		[global::System.Flags]
		public enum WheelOverrides
		{
			None = 0,
			ForwardFriction = 1,
			SidewaysFriction = 2
		}

		[global::System.Flags]
		public enum WheelFrictionOverrides
		{
			None = 0,
			ExtremumSlip = 1,
			ExtremumValue = 2,
			AsymptoteSlip = 4,
			AsymptoteValue = 8,
			Stiffness = 0x10
		}

		public global::ScheduleOne.Experimental.VehicleSettings Settings;

		public global::ScheduleOne.Experimental.WheelOverrideData.OverrideCategory Categories;

		public global::ScheduleOne.Experimental.WheelOverrideData.WheelOverrides WheelFlags;

		public global::ScheduleOne.Experimental.WheelOverrideData.WheelFrictionOverrides ForwardFrictionFlags;

		public global::ScheduleOne.Experimental.WheelOverrideData.WheelFrictionOverrides SidewaysFrictionFlags;
	}
}
