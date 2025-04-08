namespace LiquidVolumeFX
{
	public class RandomMove : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Range(-10f, 10f)]
		public float right;

		[global::UnityEngine.Range(-10f, 10f)]
		public float left;

		[global::UnityEngine.Range(-10f, 10f)]
		public float back;

		[global::UnityEngine.Range(-10f, 10f)]
		public float front;

		[global::UnityEngine.Range(0f, 0.2f)]
		public float speed;

		[global::UnityEngine.Range(0f, 2f)]
		public float rotationSpeed;

		[global::UnityEngine.Range(0.1f, 2f)]
		public float randomSpeed;

		public bool automatic;

		private global::UnityEngine.Vector3 velocity;

		private int flaskType;

		private void Update()
		{
		}
	}
}
