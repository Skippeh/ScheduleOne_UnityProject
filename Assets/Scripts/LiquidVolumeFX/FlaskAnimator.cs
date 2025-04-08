namespace LiquidVolumeFX
{
	public class FlaskAnimator : global::UnityEngine.MonoBehaviour
	{
		public float speed;

		public global::UnityEngine.Vector3 initialPosition;

		public global::UnityEngine.Vector3 finalPosition;

		public float duration;

		public float delay;

		[global::UnityEngine.Range(0f, 1f)]
		public float level;

		[global::UnityEngine.Range(0f, 1f)]
		public float minRange;

		[global::UnityEngine.Range(0f, 1f)]
		public float maxRange;

		[global::UnityEngine.Range(0f, 1f)]
		public float acceleration;

		[global::UnityEngine.Range(0f, 1f)]
		public float rotationSpeed;

		[global::UnityEngine.Range(0f, 2f)]
		public float alphaDuration;

		[global::UnityEngine.Range(0f, 1f)]
		public float finalRefractionBlur;

		private global::LiquidVolumeFX.LiquidVolume liquid;

		private float direction;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
