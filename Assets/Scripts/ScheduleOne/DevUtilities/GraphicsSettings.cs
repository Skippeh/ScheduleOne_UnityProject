namespace ScheduleOne.DevUtilities
{
	[global::System.Serializable]
	public class GraphicsSettings
	{
		public enum EAntiAliasingMode
		{
			Off = 0,
			FXAA = 1,
			SMAA = 2
		}

		public enum EGraphicsQuality
		{
			Low = 0,
			Medium = 1,
			High = 2,
			Ultra = 3
		}

		public global::ScheduleOne.DevUtilities.GraphicsSettings.EGraphicsQuality GraphicsQuality;

		public global::ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode;

		public float FOV;

		public bool SSAO;

		public bool GodRays;
	}
}
