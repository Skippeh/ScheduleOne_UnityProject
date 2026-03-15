namespace ScheduleOne.AvatarFramework.Animation
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.AvatarFramework.Avatar))]
	public class AvatarFootstepDetector : global::ScheduleOne.Tools.GenericFootstepDetector
	{
		private const float StepThreshold = 0.125f;

		[global::UnityEngine.SerializeField]
		private float _detectionRange;

		private global::ScheduleOne.AvatarFramework.Avatar _avatar;

		private bool _leftDown;

		private bool _rightDown;

		private float _detectionRangeSqr;

		private global::UnityEngine.Transform _leftBone => null;

		private global::UnityEngine.Transform _rightBone => null;

		private void Awake()
		{
		}

		protected virtual void LateUpdate()
		{
		}
	}
}
