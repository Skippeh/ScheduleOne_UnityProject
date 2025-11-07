namespace ScheduleOne.NPCs.Behaviour
{
	public class GenericDialogueBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		private global::ScheduleOne.PlayerScripts.Player targetPlayer;

		[global::UnityEngine.Header("Settings")]
		public bool FaceConversationTarget;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EGenericDialogueBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EGenericDialogueBehaviourAssembly_002DCSharp_002Edll_Excuted;

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendTargetPlayer(global::FishNet.Object.NetworkObject player)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetTargetPlayer(global::FishNet.Object.NetworkObject player)
		{
		}

		public override void Enable()
		{
		}

		public override void Disable()
		{
		}

		public override void Begin()
		{
		}

		public override void Resume()
		{
		}

		public override void End()
		{
		}

		public override void ActiveMinPass()
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

		private void RpcWriter___Server_SendTargetPlayer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		public void RpcLogic___SendTargetPlayer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Server_SendTargetPlayer_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetTargetPlayer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcLogic___SetTargetPlayer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Observers_SetTargetPlayer_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
