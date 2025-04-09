using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.Recording
{
	[Serializable]
	public class VehicleKeyFrame
	{
		[Serializable]
		public class WheelTransform
		{
			public float yPos;

			public Quaternion rotation;
		}

		public Vector3 position;

		public Quaternion rotation;

		public bool brakesApplied;

		public bool reversing;

		public bool headlightsOn;

		public List<WheelTransform> wheels;
	}
}
