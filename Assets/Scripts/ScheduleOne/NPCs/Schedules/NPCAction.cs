namespace ScheduleOne.NPCs.Schedules
{
	[global::System.Serializable]
	public abstract class NPCAction : global::FishNet.Object.NetworkBehaviour
	{
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		[global::UnityEngine.SerializeField]
		protected int priority;

		[global::UnityEngine.Header("Timing Settings")]
		public int StartTime;

		protected global::ScheduleOne.NPCs.NPC npc;

		protected global::ScheduleOne.NPCs.NPCScheduleManager schedule;

		public global::System.Action onEnded;

		protected int consecutivePathingFailures;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCActionAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCActionAssembly_002DCSharp_002Edll_Excuted;

		protected string ActionName => null;

		public bool IsEvent => false;

		public bool IsSignal => false;

		public bool IsActive => false;

		public bool HasStarted { get; protected set; }

		public virtual int Priority => 0;

		protected global::ScheduleOne.NPCs.NPCMovement movement => null;

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

		private void OnDestroy()
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

		public virtual void OnActiveTick()
		{
		}

		public virtual void OnActiveMinPass()
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

		protected void SetDestination(global::UnityEngine.Vector3 position, bool teleportIfFail = true)
		{
		}

		protected virtual void WalkCallback(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
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
