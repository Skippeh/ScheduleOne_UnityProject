namespace ScheduleOne.Weather
{
	public class SkyOverrideEnclosure : global::ScheduleOne.Weather.WorldEnclosure
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Tooltip("Higher priority overrides will take precedence over lower ones")]
		[global::UnityEngine.SerializeField]
		private int _priority;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.SkySettings _skySettings;

		public int Priority => 0;

		public global::ScheduleOne.Weather.SkySettings SkySettings => null;
	}
}
