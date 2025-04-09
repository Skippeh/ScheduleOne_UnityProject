using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Doors
{
	public class SensorRollerDoors : RollerDoor
	{
		[Header("References")]
		public VehicleDetector Detector;

		public VehicleDetector ClipDetector;

		[Header("Settings")]
		public bool DetectPlayerOccupiedVehiclesOnly;

		protected virtual void Update()
		{
		}
	}
}
