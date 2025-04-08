namespace LiquidVolumeFX
{
	public class LiquidLevelPouringSync : global::UnityEngine.MonoBehaviour
	{
		public float fillSpeed;

		public float sinkFactor;

		private global::LiquidVolumeFX.LiquidVolume lv;

		private global::UnityEngine.Rigidbody rb;

		private void Start()
		{
		}

		private void OnParticleCollision(global::UnityEngine.GameObject other)
		{
		}

		private void UpdateColliderPos()
		{
		}
	}
}
