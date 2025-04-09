using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Skating
{
	public class SkateboardAnimation : MonoBehaviour
	{
		[Serializable]
		public class AlignmentSet
		{
			public Transform Transform;

			public Transform Default;

			public Transform Animated;
		}

		[Header("Settings")]
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

		[Header("References")]
		public AlignmentSet PelvisContainerAlignment;

		public AlignmentSet PelvisAlignment;

		public AlignmentSet SpineContainerAlignment;

		public AlignmentSet SpineAlignment;

		public Transform SpineAlignment_Hunched;

		public AlignmentSet LeftFootAlignment;

		public AlignmentSet RightFootAlignment;

		public AlignmentSet LeftLegBendTarget;

		public AlignmentSet RightLegBendTarget;

		public AlignmentSet LeftHandAlignment;

		public AlignmentSet RightHandAlignment;

		public Transform AvatarFaceTarget;

		public Transform HandContainer;

		public Animation IKAnimation;

		[Header("Arm Lift")]
		public AlignmentSet LeftHandLoweredAlignment;

		public AlignmentSet LeftHandRaisedAlignment;

		public AlignmentSet RightHandLoweredAlignment;

		public AlignmentSet RightHandRaisedAlignment;

		private Skateboard board;

		private float currentCrouchShift;

		private float targetArmLift;

		private float currentArmLift;

		private Quaternion pelvisDefaultRotation;

		private Vector3 pelvisDefaultPosition;

		private Vector3 spineDefaultPosition;

		private float currentMomentumOffset;

		private float ikBlend;

		private List<AlignmentSet> alignmentSets;

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
