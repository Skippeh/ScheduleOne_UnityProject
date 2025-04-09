using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.FX
{
	public class CountdownExplosion : MonoBehaviour
	{
		public const float COUNTDOWN = 30f;

		public const float TICK_SPACING_MAX = 1f;

		public const float TICK_SPACING_MIN = 0.1f;

		public AudioSourceController TickSound;

		private Coroutine countdownRoutine;

		public void Trigger()
		{
		}

		public void StopCountdown()
		{
		}
	}
}
