namespace ScheduleOne.DevUtilities
{
	public class CameraOrbit : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Required")]
		public global::UnityEngine.Transform target;

		public global::UnityEngine.Transform cam;

		public global::UnityEngine.UI.GraphicRaycaster raycaster;

		public global::ScheduleOne.AvatarFramework.Animation.AvatarLookController LookAt;

		[global::UnityEngine.Header("Config")]
		public float targetdistance;

		public float xSpeed;

		public float ySpeed;

		public float sideOffset;

		public float yMinLimit;

		public float yMaxLimit;

		public float distanceMin;

		public float distanceMax;

		public float ScrollSensativity;

		private global::UnityEngine.Rigidbody rb;

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
