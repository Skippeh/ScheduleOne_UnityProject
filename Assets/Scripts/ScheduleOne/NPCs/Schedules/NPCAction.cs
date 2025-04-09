using System;
using FishNet.Object;
using UnityEngine;

namespace ScheduleOne.NPCs.Schedules
{
	[Serializable]
	public abstract class NPCAction : NetworkBehaviour
	{
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		[SerializeField]
		protected int priority;

		[Header("Timing Settings")]
		public int StartTime;

		protected NPC npc;

		protected NPCScheduleManager schedule;

		public Action onEnded;

		protected int consecutivePathingFailures;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCActionAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCActionAssembly_002DCSharp_002Edll_Excuted;

		protected string ActionName => null;

		public bool IsEvent => false;

		public bool IsSignal => false;

		public bool IsActive { get; protected set; }

		public bool HasStarted { get; protected set; }

		public virtual int Priority => 0;

		protected NPCMovement movement => null;

		public virtual void Awake()
		{
		}

		protected override void OnValidate()
		{
		}

		private void GetReferences()
		{
		}

		protected virtual void Start()
		{
		}

		public virtual void Started()
		{
		}

		public virtual void LateStarted()
		{
		}

		public virtual void JumpTo()
		{
		}

		public virtual void End()
		{
		}

		public virtual void Interrupt()
		{
		}

		public virtual void Resume()
		{
		}

		public virtual void ResumeFailed()
		{
		}

		public virtual void Skipped()
		{
		}

		public virtual void ActiveUpdate()
		{
		}

		public virtual void ActiveMinPassed()
		{
		}

		public virtual void PendingMinPassed()
		{
		}

		public virtual void MinPassed()
		{
		}

		public virtual bool ShouldStart()
		{
			return false;
		}

		public abstract string GetName();

		public abstract string GetTimeDescription();

		public abstract int GetEndTime();

		protected void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
		}

		protected virtual void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		public virtual void SetStartTime(int startTime)
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ESchedules_002ENPCAction_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
