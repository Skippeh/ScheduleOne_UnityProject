namespace ScheduleOne.Audio
{
	[global::System.Serializable]
	public class AudioSettingsWrapper
	{
		public global::ScheduleOne.Audio.EAudioType AudioType;

		public float Volume;

		public float VolumeMultiplier;

		public global::UnityEngine.Vector2 MinMaxPitch;

		public float PitchMultiplier;

		public bool RandomizePitch;

		[global::UnityEngine.Range(10f, 22000f)]
		public int LowPassCutoffFrequency;
	}
}
