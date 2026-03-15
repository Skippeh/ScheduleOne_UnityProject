namespace ScheduleOne.Tools
{
	public abstract class GenericFootstepDetector : global::UnityEngine.MonoBehaviour
	{
		private const float GroundDetectionRange = 0.15f;

		private const float GroundDetectionRayOriginShift = 0.5f;

		[global::UnityEngine.SerializeField]
		private float _baseVolume;

		[global::UnityEngine.SerializeField]
		private float _stepDetectionCooldown;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform _referencePoint;

		private float _timeOnLastStep;

		public float VolumeMultiplier { get; set; }

		private void Awake()
		{
		}

		protected void TriggerStep(global::ScheduleOne.Core.EMaterialType materialType, global::UnityEngine.Vector3 stepPosition)
		{
		}

		protected bool IsCooldown()
		{
			return false;
		}

		protected bool IsGrounded(out global::ScheduleOne.Core.EMaterialType surfaceType)
		{
			surfaceType = default(global::ScheduleOne.Core.EMaterialType);
			return false;
		}
	}
}
