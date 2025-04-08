namespace ScheduleOne.Map
{
	public class FoliageRustleSound : global::UnityEngine.MonoBehaviour
	{
		public const float ACTIVATION_RANGE_SQUARED = 900f;

		public const float COOLDOWN = 1f;

		public global::ScheduleOne.Audio.AudioSourceController Sound;

		public global::UnityEngine.GameObject Container;

		private float timeOnLastHit;

		private void Awake()
		{
		}

		public void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		private void UpdateActive()
		{
		}
	}
}
