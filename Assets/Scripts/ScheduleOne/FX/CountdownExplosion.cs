namespace ScheduleOne.FX
{
	public class CountdownExplosion : global::UnityEngine.MonoBehaviour
	{
		public const float COUNTDOWN = 30f;

		public const float TICK_SPACING_MAX = 1f;

		public const float TICK_SPACING_MIN = 0.1f;

		public global::ScheduleOne.Audio.AudioSourceController TickSound;

		private global::UnityEngine.Coroutine countdownRoutine;

		public void Trigger()
		{
		}

		public void StopCountdown()
		{
		}
	}
}
