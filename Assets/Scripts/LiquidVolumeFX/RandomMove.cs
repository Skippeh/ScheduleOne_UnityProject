using UnityEngine;

namespace LiquidVolumeFX
{
	public class RandomMove : MonoBehaviour
	{
		[Range(-10f, 10f)]
		public float right;

		[Range(-10f, 10f)]
		public float left;

		[Range(-10f, 10f)]
		public float back;

		[Range(-10f, 10f)]
		public float front;

		[Range(0f, 0.2f)]
		public float speed;

		[Range(0f, 2f)]
		public float rotationSpeed;

		[Range(0.1f, 2f)]
		public float randomSpeed;

		public bool automatic;

		private Vector3 velocity;

		private int flaskType;

		private void Update()
		{
		}
	}
}
