using EasyButtons;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	public class OrbitCamera : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		protected Transform cameraStartPoint;

		[SerializeField]
		protected Transform centrePoint;

		[Header("Settings")]
		public float targetFollowSpeed;

		public float yMinLimit;

		public float yMaxLimit;

		public static float xSpeed;

		public static float ySpeed;

		private Vector3 rotationOriginPoint;

		private float distance;

		private float prevDistance;

		private float x;

		private float y;

		private Transform targetTransform;

		public bool isEnabled { get; protected set; }

		protected Transform cam => null;

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

		[Button]
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
