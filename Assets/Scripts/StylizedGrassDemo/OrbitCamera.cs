namespace StylizedGrassDemo
{
	public class OrbitCamera : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Space]
		public global::UnityEngine.Transform pivot;

		[global::UnityEngine.Space]
		public bool enableMouse;

		public float idleRotationSpeed;

		public float lookSmoothSpeed;

		public float moveSmoothSpeed;

		public float scrollSmoothSpeed;

		private global::UnityEngine.Transform cam;

		private float cameraRotSide;

		private float cameraRotUp;

		private float cameraRotSideCur;

		private float cameraRotUpCur;

		private float distance;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
