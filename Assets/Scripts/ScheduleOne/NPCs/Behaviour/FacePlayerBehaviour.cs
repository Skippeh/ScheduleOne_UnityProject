using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.NPCs.Behaviour
{
	public class FacePlayerBehaviour : Behaviour
	{
		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EFacePlayerBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EFacePlayerBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public Player Player { get; private set; }

		public float Countdown { get; private set; }

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTarget(NetworkObject player, float countDown = 5f)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetTargetLocal(NetworkObject player)
		{
		}

		protected override void Begin()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		public override void Disable()
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

		private void RpcWriter___Server_SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
		}

		public void RpcLogic___SetTarget_244313061(NetworkObject player, float countDown = 5f)
		{
		}

		private void RpcReader___Server_SetTarget_244313061(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetTargetLocal_3323014238(NetworkObject player)
		{
		}

		private void RpcLogic___SetTargetLocal_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Observers_SetTargetLocal_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
