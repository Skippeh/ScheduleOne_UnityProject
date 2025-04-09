using UnityEngine;

namespace LiquidVolumeFX
{
	public class FlaskAnimator : MonoBehaviour
	{
		public float speed;

		public Vector3 initialPosition;

		public Vector3 finalPosition;

		public float duration;

		public float delay;

		[Range(0f, 1f)]
		public float level;

		[Range(0f, 1f)]
		public float minRange;

		[Range(0f, 1f)]
		public float maxRange;

		[Range(0f, 1f)]
		public float acceleration;

		[Range(0f, 1f)]
		public float rotationSpeed;

		[Range(0f, 2f)]
		public float alphaDuration;

		[Range(0f, 1f)]
		public float finalRefractionBlur;

		private LiquidVolume liquid;

		private float direction;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
