using UnityEngine;

namespace StylizedGrassDemo
{
	public class OrbitCamera : MonoBehaviour
	{
		[Space]
		public Transform pivot;

		[Space]
		public bool enableMouse;

		public float idleRotationSpeed;

		public float lookSmoothSpeed;

		public float moveSmoothSpeed;

		public float scrollSmoothSpeed;

		private Transform cam;

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
