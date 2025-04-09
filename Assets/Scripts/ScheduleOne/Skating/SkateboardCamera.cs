using FishNet.Object;
using UnityEngine;

namespace ScheduleOne.Skating
{
	[RequireComponent(typeof(Skateboard))]
	public class SkateboardCamera : NetworkBehaviour
	{
		private const float followDelta = 7.5f;

		private const float yMinLimit = -20f;

		private const float manualOverrideTime = 0.01f;

		private const float manualOverrideReturnTime = 0.6f;

		private const float xSpeed = 60f;

		private const float ySpeed = 40f;

		private const float yMaxLimit = 89f;

		[Header("References")]
		public Transform cameraOrigin;

		[Header("Settings")]
		public float CameraFollowSpeed;

		public float HorizontalOffset;

		public float VerticalOffset;

		public float CameraDownAngle;

		[Header("Settings")]
		public float FOVMultiplier_MinSpeed;

		public float FOVMultiplier_MaxSpeed;

		public float FOVMultiplierChangeRate;

		private Skateboard board;

		private float currentFovMultiplier;

		private bool cameraReversed;

		private bool cameraAdjusted;

		private float timeSinceCameraManuallyAdjusted;

		private float orbitDistance;

		private Vector3 lastFrameCameraOffset;

		private Vector3 lastManualOffset;

		private Transform targetTransform;

		private Transform cameraDolly;

		private float x;

		private float y;

		private bool NetworkInitialize___EarlyScheduleOne_002ESkating_002ESkateboardCameraAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ESkating_002ESkateboardCameraAssembly_002DCSharp_002Edll_Excuted;

		private Transform cam => null;

		public virtual void Awake()
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

		private void LateUpdate()
		{
		}

		private void UpdateCamera()
		{
		}

		private void UpdateFOV()
		{
		}

		private static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		private Vector3 GetTargetCameraPosition()
		{
			return default(Vector3);
		}

		private Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			return default(Vector3);
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
