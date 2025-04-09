using UnityEngine;

namespace LiquidVolumeFX
{
	public class VerticalBounce : MonoBehaviour
	{
		[Range(0f, 0.1f)]
		public float acceleration;

		private float direction;

		private float y;

		private float speed;

		private void Update()
		{
		}
	}
}
