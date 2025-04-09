using FishNet.Object;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	public class NPCAnimation : NetworkBehaviour
	{
		[Header("References")]
		public ScheduleOne.AvatarFramework.Avatar Avatar;

		[SerializeField]
		protected AvatarAnimation anim;

		[SerializeField]
		protected NPCMovement movement;

		protected NPC npc;

		[SerializeField]
		protected SmoothedVelocityCalculator velocityCalculator;

		[Header("Settings")]
		public AnimationCurve WalkMapCurve;

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
