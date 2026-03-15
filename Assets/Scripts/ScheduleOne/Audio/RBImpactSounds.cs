namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class RBImpactSounds : global::UnityEngine.MonoBehaviour
	{
		public const float MinImpactMomentum = 4f;

		public const float SoundCooldown = 0.25f;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("Material")]
		private global::ScheduleOne.Core.Audio.EImpactSound _material;

		private float _lastImpactTime;

		private global::UnityEngine.Rigidbody _rb;

		private void Awake()
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
