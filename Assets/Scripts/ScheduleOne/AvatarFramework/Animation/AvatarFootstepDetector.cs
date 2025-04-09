using ScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Animation
{
	public class AvatarFootstepDetector : MonoBehaviour
	{
		public const float MAX_DETECTION_RANGE = 20f;

		public const float GROUND_DETECTION_RANGE = 0.25f;

		public Avatar Avatar;

		public Transform ReferencePoint;

		public Transform LeftBone;

		public Transform RightBone;

		public float StepThreshold;

		public LayerMask GroundDetectionMask;

		private bool leftDown;

		private bool rightDown;

		public UnityEvent<EMaterialType, float> onStep;

		private void LateUpdate()
		{
		}

		public void TriggerStep()
		{
		}

		public bool IsGrounded(out EMaterialType surfaceType)
		{
			surfaceType = default(EMaterialType);
			return false;
		}
	}
}
