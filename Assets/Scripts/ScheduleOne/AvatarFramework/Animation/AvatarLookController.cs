namespace ScheduleOne.AvatarFramework.Animation
{
	public class AvatarLookController : global::UnityEngine.MonoBehaviour
	{
		public const float LookAtPlayerRange = 4f;

		public const float EyeContractRange = 10f;

		public const float AimIKRange = 20f;

		public static global::UnityEngine.Transform TempContainer;

		public bool DEBUG;

		[global::UnityEngine.Header("References")]
		public global::RootMotion.FinalIK.AimIK Aim;

		public global::UnityEngine.Transform HeadBone;

		public global::UnityEngine.Transform LookForwardTarget;

		public global::UnityEngine.Transform LookOrigin;

		public global::ScheduleOne.AvatarFramework.EyeController Eyes;

		[global::UnityEngine.Header("Optional NPC reference")]
		public global::ScheduleOne.NPCs.NPC NPC;

		[global::UnityEngine.Header("Settings")]
		public bool AutoLookAtPlayer;

		public float LookLerpSpeed;

		public float AimIKWeight;

		public float BodyRotationSpeed;

		private global::ScheduleOne.AvatarFramework.Avatar avatar;

		private global::UnityEngine.Vector3 lookAtPos;

		private global::UnityEngine.Transform lookAtTarget;

		private global::UnityEngine.Vector3 lastFrameOffset;

		private bool overrideLookAt;

		private global::UnityEngine.Vector3 overriddenLookTarget;

		private int overrideLookPriority;

		private bool overrideRotateBody;

		private bool blockLookOverrides;

		private global::UnityEngine.Vector3 lastFrameLookOriginPos;

		private global::UnityEngine.Vector3 lastFrameLookOriginForward;

		public global::UnityEngine.Transform ForceLookTarget;

		public bool ForceLookRotateBody;

		private float defaultIKWeight;

		private global::ScheduleOne.PlayerScripts.Player nearestPlayer;

		private float nearestPlayerDist;

		private float localPlayerDist;

		private float cullRange;

		public float BodyRotationSpeedMultiplier { get; set; }

		private void Awake()
		{
		}

		private void UpdateLook()
		{
		}

		private void UpdateNearestPlayer()
		{
		}

		private void LateUpdate()
		{
		}

		public void OverrideLookTarget(global::UnityEngine.Vector3 targetPosition, int priority, bool rotateBody = false)
		{
		}

		public void BlockLookTargetOverrides()
		{
		}

		private void LookForward()
		{
		}

		private void LerpTargetTransform()
		{
		}

		private global::ScheduleOne.PlayerScripts.Player GetNearestPlayer()
		{
			return null;
		}

		private bool CanLookAt(global::UnityEngine.Vector3 position)
		{
			return false;
		}

		protected void RagdollChange(bool oldValue, bool ragdoll, bool playStandUpAnim)
		{
		}

		public void OverrideIKWeight(float weight)
		{
		}

		public void ResetIKWeight()
		{
		}
	}
}
