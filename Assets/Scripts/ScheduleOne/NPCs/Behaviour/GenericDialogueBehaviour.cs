using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.NPCs.Behaviour
{
	public class GenericDialogueBehaviour : Behaviour
	{
		private Player targetPlayer;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EGenericDialogueBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EGenericDialogueBehaviourAssembly_002DCSharp_002Edll_Excuted;

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendTargetPlayer(NetworkObject player)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetTargetPlayer(NetworkObject player)
		{
		}

		public override void Enable()
		{
		}

		public override void Disable()
		{
		}

		protected override void Begin()
		{
		}

		protected override void Resume()
		{
		}

		protected override void End()
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

		private void RpcWriter___Server_SendTargetPlayer_3323014238(NetworkObject player)
		{
		}

		public void RpcLogic___SendTargetPlayer_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Server_SendTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetTargetPlayer_3323014238(NetworkObject player)
		{
		}

		private void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
