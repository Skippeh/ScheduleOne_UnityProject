namespace ScheduleOne.Tools
{
	public class ParticleCollisionDetector : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.GameObject> onCollision;

		private global::UnityEngine.ParticleSystem ps;

		private void Awake()
		{
		}

		public void OnParticleCollision(global::UnityEngine.GameObject other)
		{
		}

		private void OnParticleTrigger()
		{
		}
	}
}
