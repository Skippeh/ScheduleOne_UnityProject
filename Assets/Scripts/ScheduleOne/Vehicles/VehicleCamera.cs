namespace ScheduleOne.Vehicles
{
	public class VehicleCamera : global::UnityEngine.MonoBehaviour
	{
		private const float followDelta = 10f;

		private const float yMinLimit = -20f;

		private const float manualOverrideTime = 0.01f;

		private const float manualOverrideReturnTime = 0.6f;

		private const float xSpeed = 60f;

		private const float ySpeed = 40f;

		private const float yMaxLimit = 89f;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Vehicles.LandVehicle vehicle;

		[global::UnityEngine.Header("Camera Settings")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform cameraOrigin;

		[global::UnityEngine.SerializeField]
		protected float lateralOffset;

		[global::UnityEngine.SerializeField]
		protected float verticalOffset;

		protected bool cameraReversed;

		protected float timeSinceCameraManuallyAdjusted;

		protected float orbitDistance;

		protected global::UnityEngine.Vector3 lastFrameCameraOffset;

		protected global::UnityEngine.Vector3 lastManualOffset;

		private global::UnityEngine.Transform targetTransform;

		private global::UnityEngine.Transform cameraDolly;

		private float x;

		private float y;

		private float mouseIdleCooldown;

		private float mouseIdleTimer;

		private global::UnityEngine.Transform cam => null;

		private bool NeedSecondaryClick => false;

		protected virtual void Start()
		{
		}

		private void Subscribe()
		{
		}

		protected virtual void Update()
		{
		}

		private void PlayerEnteredVehicle(global::ScheduleOne.Vehicles.LandVehicle veh)
		{
		}

		private void CheckForClick()
		{
		}

		private void CheckForMouseMovement()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void HandleNonSecondaryClickCameraMovement()
		{
		}

		private void HandleSecondaryClickCameraMovement()
		{
		}

		private void ForceCameraReturn()
		{
		}

		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		private global::UnityEngine.Vector3 GetTargetCameraPosition()
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::UnityEngine.Vector3 LimitCameraPosition(global::UnityEngine.Vector3 targetPosition)
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
