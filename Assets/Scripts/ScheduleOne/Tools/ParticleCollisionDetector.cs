using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	public class ParticleCollisionDetector : MonoBehaviour
	{
		public UnityEvent<GameObject> onCollision;

		private ParticleSystem ps;

		private void Awake()
		{
		}

		public void OnParticleCollision(GameObject other)
		{
		}

		private void OnParticleTrigger()
		{
		}
	}
}
