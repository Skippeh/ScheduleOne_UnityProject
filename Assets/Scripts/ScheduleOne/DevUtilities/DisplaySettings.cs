namespace ScheduleOne.DevUtilities
{
	[global::System.Serializable]
	public struct DisplaySettings
	{
		public enum EDisplayMode
		{
			Windowed = 0,
			FullscreenWindow = 1,
			ExclusiveFullscreen = 2
		}

		public int ResolutionIndex;

		public global::ScheduleOne.DevUtilities.DisplaySettings.EDisplayMode DisplayMode;

		public bool VSync;

		public int TargetFPS;

		public float UIScale;

		public float CameraBobbing;

		public int ActiveDisplayIndex;

		public global::ScheduleOne.DevUtilities.Settings.EUnitType UnitType;

		public static global::System.Collections.Generic.List<global::UnityEngine.Resolution> GetResolutions()
		{
			return null;
		}
	}
}
