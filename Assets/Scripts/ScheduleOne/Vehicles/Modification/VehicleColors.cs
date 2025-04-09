using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Vehicles.Modification
{
	public class VehicleColors : Singleton<VehicleColors>
	{
		[Serializable]
		public class VehicleColorData
		{
			public EVehicleColor color;

			public string colorName;

			public Material material;

			public Color32 UIColor;
		}

		public List<VehicleColorData> colorLibrary;

		public string GetColorName(EVehicleColor c)
		{
			return null;
		}

		public Color32 GetColorUIColor(EVehicleColor c)
		{
			return default(Color32);
		}
	}
}
