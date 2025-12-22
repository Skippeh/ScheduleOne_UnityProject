namespace ScheduleOne.NPCs.Behaviour
{
	public class RequestProductBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public enum EState
		{
			InitialApproach = 0,
			FollowPlayer = 1
		}

		public const float CONVERSATION_RANGE = 2.5f;

		public const float FOLLOW_MAX_RANGE = 5f;

		public const int MINS_TO_ASK_AGAIN = 90;

		private int minsSinceLastDialogue;

		private global::ScheduleOne.Dialogue.DialogueController.GreetingOverride requestGreeting;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice acceptRequestChoice;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice followChoice;

		private global::ScheduleOne.Dialogue.DialogueController.DialogueChoice rejectChoice;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ERequestProductBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ERequestProductBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.PlayerScripts.Player TargetPlayer { get; private set; }

		public global::ScheduleOne.NPCs.Behaviour.RequestProductBehaviour.EState State { get; private set; }

		private global::ScheduleOne.Economy.Customer customer => null;

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void AssignTarget(global::FishNet.Object.NetworkObject plr)
		{
		}

		protected virtual void Start()
		{
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		public override void Disable()
		{
		}

		public override void OnActiveTick()
		{
		}

		private bool IsTargetDestinationValid()
		{
			return false;
		}

		private bool GetNewDestination(out global::UnityEngine.Vector3 dest)
		{
			dest = default(global::UnityEngine.Vector3);
			return false;
		}

		public static bool IsTargetValid(global::ScheduleOne.PlayerScripts.Player player)
		{
			return false;
		}

		public bool CanStartDialogue()
		{
			return false;
		}

		private void SetUpDialogue()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendStartInitialDialogue()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void StartInitialDialogue()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendStartFollowUpDialogue()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void StartFollowUpDialogue()
		{
		}

		private bool DialogueActive(bool enabled)
		{
			return false;
		}

		private void RequestAccepted()
		{
		}

		private void HandoverClosed(global::ScheduleOne.UI.Handover.HandoverScreen.EHandoverOutcome outcome, global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> items, float askingPrice)
		{
		}

		private void Follow()
		{
		}

		private void RequestRejected()
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

		private void RpcWriter___Observers_AssignTarget_3323014238(global::FishNet.Object.NetworkObject plr)
		{
		}

		public void RpcLogic___AssignTarget_3323014238(global::FishNet.Object.NetworkObject plr)
		{
		}

		private void RpcReader___Observers_AssignTarget_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendStartInitialDialogue_2166136261()
		{
		}

		private void RpcLogic___SendStartInitialDialogue_2166136261()
		{
		}

		private void RpcReader___Server_SendStartInitialDialogue_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_StartInitialDialogue_2166136261()
		{
		}

		private void RpcLogic___StartInitialDialogue_2166136261()
		{
		}

		private void RpcReader___Observers_StartInitialDialogue_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendStartFollowUpDialogue_2166136261()
		{
		}

		private void RpcLogic___SendStartFollowUpDialogue_2166136261()
		{
		}

		private void RpcReader___Server_SendStartFollowUpDialogue_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_StartFollowUpDialogue_2166136261()
		{
		}

		private void RpcLogic___StartFollowUpDialogue_2166136261()
		{
		}

		private void RpcReader___Observers_StartFollowUpDialogue_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
