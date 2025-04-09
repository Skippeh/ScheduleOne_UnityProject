using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.VoiceOver
{
	public class PoliceChatterVO : VOEmitter
	{
		public AudioSourceController StartBeep;

		public AudioSourceController StartEndBeep;

		public AudioSourceController Static;

		private Coroutine chatterRoutine;

		public override void Play(EVOLineType lineType)
		{
		}

		private void PlayChatter()
		{
		}
	}
}
