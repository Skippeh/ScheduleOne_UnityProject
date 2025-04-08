namespace ScheduleOne.Vehicles.Recording
{
	[global::System.Serializable]
	public class VehicleKeyFrame
	{
		[global::System.Serializable]
		public class WheelTransform
		{
			public float yPos;

			public global::UnityEngine.Quaternion rotation;
		}

		public global::UnityEngine.Vector3 position;

		public global::UnityEngine.Quaternion rotation;

		public bool brakesApplied;

		public bool reversing;

		public bool headlightsOn;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.Recording.VehicleKeyFrame.WheelTransform> wheels;
	}
}
