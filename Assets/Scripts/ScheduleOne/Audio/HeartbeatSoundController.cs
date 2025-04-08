namespace ScheduleOne.Audio
{
	public class HeartbeatSoundController : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Audio.AudioSourceController sound;

		public global::ScheduleOne.Tools.FloatSmoother VolumeController;

		public global::ScheduleOne.Tools.FloatSmoother PitchController;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
