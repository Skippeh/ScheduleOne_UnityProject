using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	public class BirdsEyeView : Singleton<BirdsEyeView>
	{
		[Header("Settings")]
		public Vector3 bounds_Min;

		public Vector3 bounds_Max;

		[Header("Camera settings")]
		public float lateralMovementSpeed;

		public float scrollMovementSpeed;

		public float targetFollowSpeed;

		[Header("Camera orbit settings")]
		public float xSpeed;

		public float ySpeed;

		public float yMinLimit;

		public float yMaxLimit;

		private Vector3 rotationOriginPoint;

		private float distance;

		private float prevDistance;

		private float x;

		private float y;

		private Transform targetTransform;

		private Coroutine originSlideRoutine;

		private Transform playerCam => null;

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

		public void Enable(Vector3 startPosition, Quaternion startRotation)
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

		public void SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0f)
		{
		}
	}
}
