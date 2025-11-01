namespace ScheduleOne.Audio
{
	public class SewerAmbience : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Audio.SewerAmbience>
	{
		public global::ScheduleOne.Map.SewerCameraPresense SewerCameraPresense;

		public global::ScheduleOne.Audio.AudioSourceController SewerAmbienceSource;

		public float SewerAmbienceVolume => 0f;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
