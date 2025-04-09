using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.Recording
{
	public class VehicleRecorder : MonoBehaviour
	{
		public static int frameRate;

		public bool IS_RECORDING;

		public List<VehicleKeyFrame> keyFrames;

		private LandVehicle vehicleToRecord;

		private float timeSinceKeyFrame;

		protected virtual void Update()
		{
		}

		private VehicleKeyFrame Capture()
		{
			return null;
		}

		private VehicleKeyFrame.WheelTransform CaptureWheel(Wheel wheel)
		{
			return null;
		}
	}
}
