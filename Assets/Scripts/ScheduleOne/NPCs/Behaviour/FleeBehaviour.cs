namespace ScheduleOne.NPCs.Behaviour
{
	public class FleeBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public enum EFleeMode
		{
			Entity = 0,
			Point = 1
		}

		public const float FLEE_DIST_MIN = 20f;

		public const float FLEE_DIST_MAX = 40f;

		public const float FLEE_SPEED = 0.7f;

		private global::UnityEngine.Vector3 currentFleeTarget;

		private float nextVO;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EFleeBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EFleeBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::FishNet.Object.NetworkObject EntityToFlee { get; private set; }

		public global::UnityEngine.Vector3 PointToFlee => default(global::UnityEngine.Vector3);

		public global::ScheduleOne.NPCs.Behaviour.FleeBehaviour.EFleeMode FleeMode { get; private set; }

		public global::UnityEngine.Vector3 FleeOrigin { get; private set; }

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetEntityToFlee(global::FishNet.Object.NetworkObject entity)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetPointToFlee(global::UnityEngine.Vector3 point)
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

		public override void Pause()
		{
		}

		private void StartFlee()
		{
		}

		public override void ActiveMinPass()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		private void Stop()
		{
		}

		private void Flee()
		{
		}

		public global::UnityEngine.Vector3 GetFleePosition()
		{
			return default(global::UnityEngine.Vector3);
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

		private void RpcWriter___Observers_SetEntityToFlee_3323014238(global::FishNet.Object.NetworkObject entity)
		{
		}

		public void RpcLogic___SetEntityToFlee_3323014238(global::FishNet.Object.NetworkObject entity)
		{
		}

		private void RpcReader___Observers_SetEntityToFlee_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetPointToFlee_4276783012(global::UnityEngine.Vector3 point)
		{
		}

		public void RpcLogic___SetPointToFlee_4276783012(global::UnityEngine.Vector3 point)
		{
		}

		private void RpcReader___Observers_SetPointToFlee_4276783012(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
