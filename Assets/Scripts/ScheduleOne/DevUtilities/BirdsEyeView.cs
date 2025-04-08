namespace ScheduleOne.DevUtilities
{
	public class BirdsEyeView : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.DevUtilities.BirdsEyeView>
	{
		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Vector3 bounds_Min;

		public global::UnityEngine.Vector3 bounds_Max;

		[global::UnityEngine.Header("Camera settings")]
		public float lateralMovementSpeed;

		public float scrollMovementSpeed;

		public float targetFollowSpeed;

		[global::UnityEngine.Header("Camera orbit settings")]
		public float xSpeed;

		public float ySpeed;

		public float yMinLimit;

		public float yMaxLimit;

		private global::UnityEngine.Vector3 rotationOriginPoint;

		private float distance;

		private float prevDistance;

		private float x;

		private float y;

		private global::UnityEngine.Transform targetTransform;

		private global::UnityEngine.Coroutine originSlideRoutine;

		private global::UnityEngine.Transform playerCam => null;

		public bool isEnabled { get; protected set; }

		protected override void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void Enable(global::UnityEngine.Vector3 startPosition, global::UnityEngine.Quaternion startRotation)
		{
		}

		public void Disable(bool reenableCameraLook = true)
		{
		}

		protected void UpdateLateralMovement()
		{
		}

		protected void UpdateScrollMovement()
		{
		}

		protected void UpdateRotation()
		{
		}

		private void FinalizeCameraMovement()
		{
		}

		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		private void CancelOriginSlide()
		{
		}

		public void SlideCameraOrigin(global::UnityEngine.Vector3 position, float offsetDistance, float time = 0f)
		{
		}
	}
}
