namespace ScheduleOne.NPCs
{
	public class NPCAnimation : global::FishNet.Object.NetworkBehaviour
	{
		public bool DEBUG;

		protected global::ScheduleOne.NPCs.NPC npc;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.AnimationCurve WalkMapCurve;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCAnimationAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCAnimationAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
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

		private void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPCAnimation_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
