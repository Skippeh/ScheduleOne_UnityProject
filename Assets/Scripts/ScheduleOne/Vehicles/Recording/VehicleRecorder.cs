namespace ScheduleOne.Vehicles.Recording
{
	public class VehicleRecorder : global::UnityEngine.MonoBehaviour
	{
		public static int frameRate;

		public bool IS_RECORDING;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.Recording.VehicleKeyFrame> keyFrames;

		private global::ScheduleOne.Vehicles.LandVehicle vehicleToRecord;

		private float timeSinceKeyFrame;

		protected virtual void Update()
		{
		}

		private global::ScheduleOne.Vehicles.Recording.VehicleKeyFrame Capture()
		{
			return null;
		}

		private global::ScheduleOne.Vehicles.Recording.VehicleKeyFrame.WheelTransform CaptureWheel(global::ScheduleOne.Vehicles.Wheel wheel)
		{
			return null;
		}
	}
}
