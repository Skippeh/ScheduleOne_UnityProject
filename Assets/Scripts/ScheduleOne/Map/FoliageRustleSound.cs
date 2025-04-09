using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class FoliageRustleSound : MonoBehaviour
	{
		public const float ACTIVATION_RANGE_SQUARED = 900f;

		public const float COOLDOWN = 1f;

		public AudioSourceController Sound;

		public GameObject Container;

		private float timeOnLastHit;

		private void Awake()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		private void UpdateActive()
		{
		}
	}
}
