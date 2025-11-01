namespace ScheduleOne.AvatarFramework.Animation
{
	public class AvatarAnimation : global::UnityEngine.MonoBehaviour
	{
		public enum EFlinchType
		{
			Light = 0,
			Heavy = 1
		}

		public enum EFlinchDirection
		{
			Forward = 0,
			Backward = 1,
			Left = 2,
			Right = 3
		}

		public const bool GLOBAL_USE_IMPOSTOR = true;

		public const float AnimationRangeSqr = 2025f;

		public const float FrustrumCullMinDist = 225f;

		public const float RunningAnimationSpeed = 8f;

		public const float MaxBoneOffset = 0.01f;

		public const float MaxBoneOffsetSqr = 0.0001f;

		public static global::UnityEngine.Vector3 SITTING_OFFSET;

		public const float SEAT_TIME = 0.5f;

		private bool _IsAvatarCulled;

		public bool DEBUG_MODE;

		private int framesActive;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Animator animator;

		public global::UnityEngine.Transform HipBone;

		public global::UnityEngine.Transform[] Bones;

		protected global::ScheduleOne.AvatarFramework.Avatar avatar;

		public global::UnityEngine.Transform LeftHandContainer;

		public global::UnityEngine.Transform RightHandContainer;

		public global::UnityEngine.Transform RightHandAlignmentPoint;

		public global::UnityEngine.Transform LeftHandAlignmentPoint;

		public global::ScheduleOne.AvatarFramework.Animation.AvatarIKController IKController;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask GroundingMask;

		public string StandUpFromBackClipName;

		public string StandUpFromFrontClipName;

		public bool UseImpostor;

		public bool AllowCulling;

		public global::UnityEngine.Events.UnityEvent onStandupStart;

		public global::UnityEngine.Events.UnityEvent onStandupDone;

		public global::UnityEngine.Events.UnityEvent onHeavyFlinch;

		private global::ScheduleOne.AvatarFramework.Animation.BoneTransform[] standingBoneTransforms;

		private global::ScheduleOne.AvatarFramework.Animation.BoneTransform[] standUpFromBackBoneTransforms;

		private global::ScheduleOne.AvatarFramework.Animation.BoneTransform[] standUpFromFrontBoneTransforms;

		private global::ScheduleOne.AvatarFramework.Animation.BoneTransform[] ragdollBoneTransforms;

		private global::UnityEngine.Coroutine standUpRoutine;

		private global::UnityEngine.Coroutine seatRoutine;

		private global::ScheduleOne.Skating.Skateboard activeSkateboard;

		private bool animationEnabled;

		private global::UnityEngine.AnimatorCullingMode initialCullingMode;

		public bool IsCrouched { get; protected set; }

		public bool IsSeated => false;

		public float TimeSinceSitEnd { get; protected set; }

		public global::ScheduleOne.AvatarFramework.Animation.AvatarSeat CurrentSeat { get; protected set; }

		public bool StandUpAnimationPlaying { get; protected set; }

		public bool IsAvatarCulled
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event global::System.Action<bool> onAvatarCullStateChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void InfrequentUpdate()
		{
		}

		private void MinPass()
		{
		}

		private void UpdateAnimationActive()
		{
		}

		public void SetDirection(float dir)
		{
		}

		public void SetStrafe(float strafe)
		{
		}

		public void SetTimeAirborne(float airbone)
		{
		}

		public void SetCrouched(bool crouched)
		{
		}

		public void SetGrounded(bool grounded)
		{
		}

		public void Jump()
		{
		}

		public void SetAnimationEnabled(bool enabled)
		{
		}

		public void Flinch(global::UnityEngine.Vector3 forceDirection, global::ScheduleOne.AvatarFramework.Animation.AvatarAnimation.EFlinchType flinchType)
		{
		}

		public void PlayStandUpAnimation()
		{
		}

		protected void RagdollChange(bool wasRagdolled, bool ragdoll, bool playStandUpAnim)
		{
		}

		private void AlignPositionToHips()
		{
		}

		private bool ShouldGetUpFromBack()
		{
			return false;
		}

		private void PopulateBoneTransforms(global::ScheduleOne.AvatarFramework.Animation.BoneTransform[] boneTransforms)
		{
		}

		private global::System.Collections.Generic.List<global::UnityEngine.Pose> GetBoneTransforms()
		{
			return null;
		}

		private void PopulateAnimationStartBoneTransforms(string clipName, global::ScheduleOne.AvatarFramework.Animation.BoneTransform[] boneTransforms)
		{
		}

		public void SetTrigger(string trigger)
		{
		}

		public void ResetTrigger(string trigger)
		{
		}

		public void SetBool(string id, bool value)
		{
		}

		public void SetSeat(global::ScheduleOne.AvatarFramework.Animation.AvatarSeat seat)
		{
		}

		public void SkateboardMounted(global::ScheduleOne.Skating.Skateboard board)
		{
		}

		public void SkateboardDismounted()
		{
		}

		private void SkateboardPush()
		{
		}
	}
}
