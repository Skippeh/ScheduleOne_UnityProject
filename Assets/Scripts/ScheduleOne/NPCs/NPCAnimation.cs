namespace ScheduleOne.NPCs
{
	public class NPCAnimation : global::FishNet.Object.NetworkBehaviour
	{
		public bool DEBUG;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.AvatarFramework.Animation.AvatarAnimation anim;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.NPCs.NPCMovement movement;

		protected global::ScheduleOne.NPCs.NPC npc;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Tools.SmoothedVelocityCalculator velocityCalculator;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.AnimationCurve WalkMapCurve;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCAnimationAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCAnimationAssembly_002DCSharp_002Edll_Excuted;

		private void Start()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void UpdateMovementAnimation()
		{
		}

		public virtual void SetRagdollActive(bool active)
		{
		}

		public void ResetVelocityCalculations()
		{
		}

		public void StandupStart()
		{
		}

		public void StandupDone()
		{
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

		public virtual void Awake()
		{
		}
	}
}
