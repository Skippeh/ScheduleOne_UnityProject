namespace ScheduleOne.AvatarFramework.Animation
{
	public class AvatarFootstepDetector : global::UnityEngine.MonoBehaviour
	{
		public const float GROUND_DETECTION_RANGE = 0.15f;

		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		public global::UnityEngine.Transform ReferencePoint;

		public global::UnityEngine.Transform LeftBone;

		public global::UnityEngine.Transform RightBone;

		public float StepThreshold;

		public global::UnityEngine.LayerMask GroundDetectionMask;

		public float MaxDetectionRange;

		private bool leftDown;

		private bool rightDown;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Materials.EMaterialType, float> onStep;

		private void LateUpdate()
		{
		}

		public void TriggerStep()
		{
		}

		public bool IsGrounded(out global::ScheduleOne.Materials.EMaterialType surfaceType)
		{
			surfaceType = default(global::ScheduleOne.Materials.EMaterialType);
			return false;
		}
	}
}
