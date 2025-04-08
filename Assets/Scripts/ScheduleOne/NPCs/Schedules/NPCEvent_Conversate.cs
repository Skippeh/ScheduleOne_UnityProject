namespace ScheduleOne.NPCs.Schedules
{
	public class NPCEvent_Conversate : global::ScheduleOne.NPCs.Schedules.NPCEvent
	{
		private global::ScheduleOne.VoiceOver.EVOLineType[] ConversationLines;

		private string[] AnimationTriggers;

		public const float DESTINATION_THRESHOLD = 1f;

		public const float TIME_BEFORE_WAIT_START = 3f;

		public global::ScheduleOne.NPCs.Schedules.ConversationLocation Location;

		private bool IsConversating;

		private global::UnityEngine.Coroutine conversateRoutine;

		private bool IsWaiting;

		public global::UnityEngine.Events.UnityEvent OnWaitStart;

		public global::UnityEngine.Events.UnityEvent OnWaitEnd;

		private float timeAtDestination;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_ConversateAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_ConversateAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		private global::UnityEngine.Transform StandPoint => null;

		public override string GetName()
		{
			return null;
		}

		protected override void Start()
		{
		}

		public override void Started()
		{
		}

		public override void ActiveUpdate()
		{
		}

		public override void MinPassed()
		{
		}

		public override void LateStarted()
		{
		}

		public override void JumpTo()
		{
		}

		public override void End()
		{
		}

		public override void Interrupt()
		{
		}

		public override void Resume()
		{
		}

		private bool IsAtDestination()
		{
			return false;
		}

		private bool CanConversationStart()
		{
			return false;
		}

		protected override void WalkCallback(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		protected virtual void StartWait()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		protected virtual void EndWait()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		protected virtual void StartConversate()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		protected virtual void EndConversate()
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

		private void RpcWriter___Observers_StartWait_2166136261()
		{
		}

		protected virtual void RpcLogic___StartWait_2166136261()
		{
		}

		private void RpcReader___Observers_StartWait_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_EndWait_2166136261()
		{
		}

		protected virtual void RpcLogic___EndWait_2166136261()
		{
		}

		private void RpcReader___Observers_EndWait_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_StartConversate_2166136261()
		{
		}

		protected virtual void RpcLogic___StartConversate_2166136261()
		{
		}

		private void RpcReader___Observers_StartConversate_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_EndConversate_2166136261()
		{
		}

		protected virtual void RpcLogic___EndConversate_2166136261()
		{
		}

		private void RpcReader___Observers_EndConversate_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
