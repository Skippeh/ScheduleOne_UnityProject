namespace ScheduleOne.Audio
{
	public class StartLoopStopAudio : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Audio.AudioSourceController StartSound;

		public global::ScheduleOne.Audio.AudioSourceController LoopSound;

		public global::ScheduleOne.Audio.AudioSourceController StopSound;

		public bool FadeLoopIn;

		public bool FadeLoopOut;

		private float timeSinceStart;

		private float timeSinceStop;

		public bool Runnning { get; private set; }

		private void Update()
		{
		}

		[global::EasyButtons.Button]
		public void StartAudio()
		{
		}

		[global::EasyButtons.Button]
		public void StopAudio()
		{
		}
	}
}
