using UnityEngine;

namespace LiquidVolumeFX
{
	public class RandomRotation : MonoBehaviour
	{
		[Range(1f, 50f)]
		public float speed;

		[Range(1f, 30f)]
		public float randomChangeInterval;

		private float lastTime;

		private Vector3 v;

		private float randomization;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
