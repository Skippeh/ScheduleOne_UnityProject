namespace ScheduleOne.Skating
{
	public class SkateboardAnimation : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class AlignmentSet
		{
			public global::UnityEngine.Transform Transform;

			public global::UnityEngine.Transform Default;

			public global::UnityEngine.Transform Animated;
		}

		[global::UnityEngine.Header("Settings")]
		public float JumpCrouchAmount;

		public float CrouchSpeed;

		public float ArmLiftRate;

		public float PelvisMaxRotation;

		public float HandsMaxRotation;

		public float PelvisOffsetBlend;

		public float VerticalMomentumMultiplier;

		public float VerticalMomentumOffsetClamp;

		public float MomentumMoveSpeed;

		public float IKBlendChangeRate;

		public float PushAnimationDuration;

		public float PushAnimationSpeed;

		public global::UnityEngine.AnimationClip PushAnim;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet PelvisContainerAlignment;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet PelvisAlignment;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet SpineContainerAlignment;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet SpineAlignment;

		public global::UnityEngine.Transform SpineAlignment_Hunched;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet LeftFootAlignment;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet RightFootAlignment;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet LeftLegBendTarget;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet RightLegBendTarget;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet LeftHandAlignment;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet RightHandAlignment;

		public global::UnityEngine.Transform AvatarFaceTarget;

		public global::UnityEngine.Transform HandContainer;

		public global::UnityEngine.Animation IKAnimation;

		[global::UnityEngine.Header("Arm Lift")]
		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet LeftHandLoweredAlignment;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet LeftHandRaisedAlignment;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet RightHandLoweredAlignment;

		public global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet RightHandRaisedAlignment;

		private global::ScheduleOne.Skating.Skateboard board;

		private float currentCrouchShift;

		private float targetArmLift;

		private float currentArmLift;

		private global::UnityEngine.Quaternion pelvisDefaultRotation;

		private global::UnityEngine.Vector3 pelvisDefaultPosition;

		private global::UnityEngine.Vector3 spineDefaultPosition;

		private float currentMomentumOffset;

		private float ikBlend;

		private global::System.Collections.Generic.List<global::ScheduleOne.Skating.SkateboardAnimation.AlignmentSet> alignmentSets;

		public float CurrentCrouchShift => 0f;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void UpdateIKBlend()
		{
		}

		private void UpdateBodyAlignment()
		{
		}

		private void UpdateArmLift()
		{
		}

		private void UpdatePelvisRotation()
		{
		}

		public void SetArmLift(float lift)
		{
		}

		private void OnPushStart()
		{
		}
	}
}
