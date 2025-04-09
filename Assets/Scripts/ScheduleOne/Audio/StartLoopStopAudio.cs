using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Audio
{
	public class StartLoopStopAudio : MonoBehaviour
	{
		public AudioSourceController StartSound;

		public AudioSourceController LoopSound;

		public AudioSourceController StopSound;

		public bool FadeLoopIn;

		public bool FadeLoopOut;

		private float timeSinceStart;

		private float timeSinceStop;

		public bool Runnning { get; private set; }

		private void Update()
		{
		}

		[Button]
		public void StartAudio()
		{
		}

		[Button]
		public void StopAudio()
		{
		}
	}
}
