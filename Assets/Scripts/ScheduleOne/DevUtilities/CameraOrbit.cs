using ScheduleOne.AvatarFramework.Animation;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.DevUtilities
{
	public class CameraOrbit : MonoBehaviour
	{
		[Header("Required")]
		public Transform target;

		public Transform cam;

		public GraphicRaycaster raycaster;

		public AvatarLookController LookAt;

		[Header("Config")]
		public float targetdistance;

		public float xSpeed;

		public float ySpeed;

		public float sideOffset;

		public float yMinLimit;

		public float yMaxLimit;

		public float distanceMin;

		public float distanceMax;

		public float ScrollSensativity;

		private Rigidbody rb;

		private float x;

		private float y;

		private float targetx;

		private float targety;

		private float distance;

		private bool hoveringUI;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}
	}
}
