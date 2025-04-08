namespace ScheduleOne.NPCs.Schedules
{
	public class NPCSignal : global::ScheduleOne.NPCs.Schedules.NPCAction
	{
		public int MaxDuration;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCSignalAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCSignalAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		public bool StartedThisCycle { get; protected set; }

		public override string GetName()
		{
			return null;
		}

		public override void ActiveUpdate()
		{
		}

		public override string GetTimeDescription()
		{
			return null;
		}

		public override int GetEndTime()
		{
			return 0;
		}

		public override void Started()
		{
		}

		public override void LateStarted()
		{
		}

		public override bool ShouldStart()
		{
			return false;
		}

		public override void Interrupt()
		{
		}

		public override void MinPassed()
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
