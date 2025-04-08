namespace ScheduleOne.DevUtilities
{
	public class OrbitCamera : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform cameraStartPoint;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform centrePoint;

		[global::UnityEngine.Header("Settings")]
		public float targetFollowSpeed;

		public float yMinLimit;

		public float yMaxLimit;

		public static float xSpeed;

		public static float ySpeed;

		private global::UnityEngine.Vector3 rotationOriginPoint;

		private float distance;

		private float prevDistance;

		private float x;

		private float y;

		private global::UnityEngine.Transform targetTransform;

		public bool isEnabled { get; protected set; }

		protected global::UnityEngine.Transform cam => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		[global::EasyButtons.Button]
		public void Enable()
		{
		}

		public void Disable()
		{
		}

		protected void UpdateRotation()
		{
		}

		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		private void FinalizeCameraMovement()
		{
		}
	}
}
