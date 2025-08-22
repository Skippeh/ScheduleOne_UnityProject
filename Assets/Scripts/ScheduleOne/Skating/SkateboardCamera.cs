namespace ScheduleOne.Skating
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Skating.Skateboard))]
	public class SkateboardCamera : global::FishNet.Object.NetworkBehaviour
	{
		private const float followDelta = 7.5f;

		private const float yMinLimit = -20f;

		private const float manualOverrideTime = 0.01f;

		private const float manualOverrideReturnTime = 0.6f;

		private const float xSpeed = 60f;

		private const float ySpeed = 40f;

		private const float yMaxLimit = 89f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform cameraOrigin;

		[global::UnityEngine.Header("Settings")]
		public float CameraFollowSpeed;

		public float HorizontalOffset;

		public float VerticalOffset;

		public float CameraDownAngle;

		[global::UnityEngine.Header("Settings")]
		public float FOVMultiplier_MinSpeed;

		public float FOVMultiplier_MaxSpeed;

		public float FOVMultiplierChangeRate;

		private global::ScheduleOne.Skating.Skateboard board;

		private float currentFovMultiplier;

		private bool cameraReversed;

		private bool cameraAdjusted;

		private float timeSinceCameraManuallyAdjusted;

		private float orbitDistance;

		private global::UnityEngine.Vector3 lastFrameCameraOffset;

		private global::UnityEngine.Vector3 lastManualOffset;

		private global::UnityEngine.Transform targetTransform;

		private global::UnityEngine.Transform cameraDolly;

		private float x;

		private float y;

		private float mouseIdleCooldown;

		private float mouseIdleTimer;

		private bool NetworkInitialize___EarlyScheduleOne_002ESkating_002ESkateboardCameraAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ESkating_002ESkateboardCameraAssembly_002DCSharp_002Edll_Excuted;

		private global::UnityEngine.Transform cam => null;

		private bool NeedSecondaryClick => false;

		public virtual void Awake()
		{
		}

		private void OnPlayerMountedSkateboard(global::ScheduleOne.Skating.Skateboard skateboard)
		{
		}

		public override void OnStartClient()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void CheckForClick()
		{
		}

		private void CheckForMouseMovement()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateCamera()
		{
		}

		private void HandleNonSecondaryClickCameraMovement()
		{
		}

		private void HandleSecondaryClickCameraMovement()
		{
		}

		private void UpdateFOV()
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

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void Awake_UserLogic_ScheduleOne_002ESkating_002ESkateboardCamera_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
