namespace ScheduleOne.Effects
{
	[global::System.Serializable]
	public class EffectState
	{
		[global::UnityEngine.Header("Controller Settings")]
		public global::ScheduleOne.Effects.EffectController controller;

		[global::UnityEngine.Header("Effect Settings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.EffectSettings> ActiveSettings;

		[global::UnityEngine.Header("Audio Settings")]
		public global::System.Collections.Generic.List<global::UnityEngine.AudioSettings> AudioSettings;
	}
}
