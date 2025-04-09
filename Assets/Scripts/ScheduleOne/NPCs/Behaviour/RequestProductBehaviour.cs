using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Dialogue;
using ScheduleOne.Economy;
using ScheduleOne.ItemFramework;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.Handover;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class RequestProductBehaviour : Behaviour
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

		private DialogueController.GreetingOverride requestGreeting;

		private DialogueController.DialogueChoice acceptRequestChoice;

		private DialogueController.DialogueChoice followChoice;

		private DialogueController.DialogueChoice rejectChoice;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ERequestProductBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ERequestProductBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public Player TargetPlayer { get; private set; }

		public EState State { get; private set; }

		private Customer customer => null;

		[ObserversRpc(RunLocally = true)]
		public void AssignTarget(NetworkObject plr)
		{
		}

		protected virtual void Start()
		{
		}

		protected override void Begin()
		{
		}

		protected override void End()
		{
		}

		public override void Disable()
		{
		}

		public override void ActiveMinPass()
		{
		}

		private bool IsTargetDestinationValid()
		{
			return false;
		}

		private bool GetNewDestination(out Vector3 dest)
		{
			dest = default(Vector3);
			return false;
		}

		public static bool IsTargetValid(Player player)
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

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendStartInitialDialogue()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void StartInitialDialogue()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendStartFollowUpDialogue()
		{
		}

		[ObserversRpc(RunLocally = true)]
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

		private void HandoverClosed(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
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

		private void RpcWriter___Observers_AssignTarget_3323014238(NetworkObject plr)
		{
		}

		public void RpcLogic___AssignTarget_3323014238(NetworkObject plr)
		{
		}

		private void RpcReader___Observers_AssignTarget_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendStartInitialDialogue_2166136261()
		{
		}

		private void RpcLogic___SendStartInitialDialogue_2166136261()
		{
		}

		private void RpcReader___Server_SendStartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_StartInitialDialogue_2166136261()
		{
		}

		private void RpcLogic___StartInitialDialogue_2166136261()
		{
		}

		private void RpcReader___Observers_StartInitialDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendStartFollowUpDialogue_2166136261()
		{
		}

		private void RpcLogic___SendStartFollowUpDialogue_2166136261()
		{
		}

		private void RpcReader___Server_SendStartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_StartFollowUpDialogue_2166136261()
		{
		}

		private void RpcLogic___StartFollowUpDialogue_2166136261()
		{
		}

		private void RpcReader___Observers_StartFollowUpDialogue_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
