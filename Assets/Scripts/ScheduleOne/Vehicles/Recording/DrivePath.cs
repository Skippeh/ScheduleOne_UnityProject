using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Vehicles.Recording
{
	[Serializable]
	[CreateAssetMenu(fileName = "DrivePath", menuName = "ScriptableObjects/DrivePath", order = 1)]
	public class DrivePath : ScriptableObject
	{
		public int fps;

		public List<VehicleKeyFrame> keyframes;
	}
}
