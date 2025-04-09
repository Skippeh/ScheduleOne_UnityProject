using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Schedules
{
	public class NPCEvent_Conversate : NPCEvent
	{
		private EVOLineType[] ConversationLines;

		private string[] AnimationTriggers;

		public const float DESTINATION_THRESHOLD = 1f;

		public const float TIME_BEFORE_WAIT_START = 3f;

		public ConversationLocation Location;

		private bool IsConversating;

		private Coroutine conversateRoutine;

		private bool IsWaiting;

		public UnityEvent OnWaitStart;

		public UnityEvent OnWaitEnd;

		private float timeAtDestination;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_ConversateAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_ConversateAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		private Transform StandPoint => null;

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

		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		[ObserversRpc(RunLocally = true)]
		protected virtual void StartWait()
		{
		}

		[ObserversRpc(RunLocally = true)]
		protected virtual void EndWait()
		{
		}

		[ObserversRpc(RunLocally = true)]
		protected virtual void StartConversate()
		{
		}

		[ObserversRpc(RunLocally = true)]
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

		private void RpcReader___Observers_StartWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_EndWait_2166136261()
		{
		}

		protected virtual void RpcLogic___EndWait_2166136261()
		{
		}

		private void RpcReader___Observers_EndWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_StartConversate_2166136261()
		{
		}

		protected virtual void RpcLogic___StartConversate_2166136261()
		{
		}

		private void RpcReader___Observers_StartConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_EndConversate_2166136261()
		{
		}

		protected virtual void RpcLogic___EndConversate_2166136261()
		{
		}

		private void RpcReader___Observers_EndConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
