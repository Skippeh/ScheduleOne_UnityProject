using UnityEngine;

namespace VolumetricFogAndMist2.Demos
{
	public class FPS_Controller : MonoBehaviour
	{
		private CharacterController characterController;

		private Transform mainCamera;

		private float inputHor;

		private float inputVert;

		private float mouseHor;

		private float mouseVert;

		private float mouseInvertX;

		private float mouseInvertY;

		private float camVertAngle;

		private bool isGrounded;

		private Vector3 jumpDirection;

		private float sprint;

		public float sprintMax;

		public float airControl;

		public float jumpHeight;

		public float gravity;

		public float characterHeight;

		public float cameraHeight;

		public float speed;

		public float rotationSpeed;

		public float mouseSensitivity;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
