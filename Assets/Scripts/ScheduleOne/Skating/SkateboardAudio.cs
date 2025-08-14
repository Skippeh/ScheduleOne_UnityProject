namespace ScheduleOne.Skating
{
	public class SkateboardAudio : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Skating.Skateboard Board;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Audio.AudioSourceController JumpAudio;

		public global::ScheduleOne.Audio.AudioSourceController LandAudio;

		public global::ScheduleOne.Audio.AudioSourceController RollingAudio;

		public global::ScheduleOne.Audio.AudioSourceController DirtRollingAudio;

		public global::ScheduleOne.Audio.AudioSourceController WindAudio;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void PlayJump(float force)
		{
		}

		public void PlayLand()
		{
		}
	}
}
