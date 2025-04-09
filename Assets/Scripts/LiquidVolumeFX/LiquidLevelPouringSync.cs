using UnityEngine;

namespace LiquidVolumeFX
{
	public class LiquidLevelPouringSync : MonoBehaviour
	{
		public float fillSpeed;

		public float sinkFactor;

		private LiquidVolume lv;

		private Rigidbody rb;

		private void Start()
		{
		}

		private void OnParticleCollision(GameObject other)
		{
		}

		private void UpdateColliderPos()
		{
		}
	}
}
