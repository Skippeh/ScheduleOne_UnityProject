namespace ScheduleOne.Audio
{
	public class AmbientOneShot : global::UnityEngine.MonoBehaviour
	{
		public enum EPlayTime
		{
			All = 0,
			Day = 1,
			Night = 2
		}

		public global::ScheduleOne.Audio.AudioSourceController Audio;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Range(0f, 1f)]
		public float Volume;

		[global::UnityEngine.Range(0f, 1f)]
		public float ChancePerHour;

		public int CooldownTime;

		public global::ScheduleOne.Audio.AmbientOneShot.EPlayTime PlayTime;

		public float MinDistance;

		public float MaxDistance;

		public bool PlayWhileInSewer;

		private int timeSinceLastPlay;

		private void Start()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void MinPass()
		{
		}

		private void Play()
		{
		}
	}
}
