namespace LiquidVolumeFX
{
	public class RandomRotation : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Range(1f, 50f)]
		public float speed;

		[global::UnityEngine.Range(1f, 30f)]
		public float randomChangeInterval;

		private float lastTime;

		private global::UnityEngine.Vector3 v;

		private float randomization;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
