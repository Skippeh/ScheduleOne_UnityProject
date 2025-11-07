namespace ScheduleOne.NPCs.Behaviour
{
	public class FaceTargetBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public enum ETargetType
		{
			Player = 0,
			Position = 1
		}

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EFaceTargetBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EFaceTargetBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.NPCs.Behaviour.FaceTargetBehaviour.ETargetType TargetType { get; private set; }

		public global::ScheduleOne.PlayerScripts.Player TargetPlayer { get; private set; }

		public global::UnityEngine.Vector3 TargetPosition { get; private set; }

		public float Countdown { get; private set; }

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTarget(global::FishNet.Object.NetworkObject player, float countDown = 5f)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetTargetLocal(global::FishNet.Object.NetworkObject player)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTarget(global::UnityEngine.Vector3 position, float countDown = 5f)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetTargetLocal(global::UnityEngine.Vector3 position)
		{
		}

		public override void Begin()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		private global::UnityEngine.Vector3 GetTargetPosition()
		{
			return default(global::UnityEngine.Vector3);
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

		private void RpcWriter___Server_SetTarget_244313061(global::FishNet.Object.NetworkObject player, float countDown = 5f)
		{
		}

		public void RpcLogic___SetTarget_244313061(global::FishNet.Object.NetworkObject player, float countDown = 5f)
		{
		}

		private void RpcReader___Server_SetTarget_244313061(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetTargetLocal_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcLogic___SetTargetLocal_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Observers_SetTargetLocal_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetTarget_3661469815(global::UnityEngine.Vector3 position, float countDown = 5f)
		{
		}

		public void RpcLogic___SetTarget_3661469815(global::UnityEngine.Vector3 position, float countDown = 5f)
		{
		}

		private void RpcReader___Server_SetTarget_3661469815(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetTargetLocal_4276783012(global::UnityEngine.Vector3 position)
		{
		}

		private void RpcLogic___SetTargetLocal_4276783012(global::UnityEngine.Vector3 position)
		{
		}

		private void RpcReader___Observers_SetTargetLocal_4276783012(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
