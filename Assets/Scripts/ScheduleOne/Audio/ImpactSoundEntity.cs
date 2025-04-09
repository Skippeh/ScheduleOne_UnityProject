using ScheduleOne.Combat;
using UnityEngine;

namespace ScheduleOne.Audio
{
	[RequireComponent(typeof(Rigidbody))]
	public class ImpactSoundEntity : MonoBehaviour
	{
		public enum EMaterial
		{
			Wood = 0,
			HollowMetal = 1,
			Cardboard = 2,
			Glass = 3,
			Plastic = 4,
			Basketball = 5,
			SmallHollowMetal = 6,
			PlasticBag = 7,
			Punch = 8,
			BaseballBat = 9
		}

		public const float MIN_IMPACT_MOMENTUM = 4f;

		public const float COOLDOWN = 0.25f;

		public EMaterial Material;

		private float lastImpactTime;

		private Rigidbody rb;

		public void Awake()
		{
		}

		private void OnImpacted(Impact impact)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}
