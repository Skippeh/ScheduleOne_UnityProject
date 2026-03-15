namespace ScheduleOne.Audio
{
	public class HeartbeatSoundController : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("VolumeController")]
		private global::ScheduleOne.Tools.FloatSmoother _volumeController;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("PitchController")]
		private global::ScheduleOne.Tools.FloatSmoother _pitchController;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("sound")]
		private global::ScheduleOne.Audio.AudioSourceController _sound;

		public global::ScheduleOne.Tools.FloatSmoother VolumeController => null;

		public global::ScheduleOne.Tools.FloatSmoother PitchController => null;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
