namespace ScheduleOne.Vehicles.Modification
{
	public class VehicleColors : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Vehicles.Modification.VehicleColors>
	{
		[global::System.Serializable]
		public class VehicleColorData
		{
			public global::ScheduleOne.Vehicles.Modification.EVehicleColor color;

			public string colorName;

			public global::UnityEngine.Color MaterialColor;

			public global::UnityEngine.Color32 UIColor;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.Modification.VehicleColors.VehicleColorData> colorLibrary;

		public string GetColorName(global::ScheduleOne.Vehicles.Modification.EVehicleColor c)
		{
			return null;
		}

		public global::UnityEngine.Color32 GetColorUIColor(global::ScheduleOne.Vehicles.Modification.EVehicleColor c)
		{
			return default(global::UnityEngine.Color32);
		}
	}
}
