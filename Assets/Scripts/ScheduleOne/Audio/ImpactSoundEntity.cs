namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class ImpactSoundEntity : global::UnityEngine.MonoBehaviour
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

		public global::ScheduleOne.Audio.ImpactSoundEntity.EMaterial Material;

		private float lastImpactTime;

		private global::UnityEngine.Rigidbody rb;

		public void Awake()
		{
		}

		private void OnImpacted(global::ScheduleOne.Combat.Impact impact)
		{
		}

		private void OnCollisionEnter(global::UnityEngine.Collision collision)
		{
		}
	}
}
