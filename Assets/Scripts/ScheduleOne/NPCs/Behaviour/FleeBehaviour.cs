using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class FleeBehaviour : Behaviour
	{
		public enum EFleeMode
		{
			Entity = 0,
			Point = 1
		}

		public const float FLEE_DIST_MIN = 20f;

		public const float FLEE_DIST_MAX = 40f;

		public const float FLEE_SPEED = 0.7f;

		private Vector3 currentFleeTarget;

		private float nextVO;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EFleeBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EFleeBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public NetworkObject EntityToFlee { get; private set; }

		public Vector3 PointToFlee => default(Vector3);

		public EFleeMode FleeMode { get; private set; }

		public Vector3 FleeOrigin { get; private set; }

		[ObserversRpc(RunLocally = true)]
		public void SetEntityToFlee(NetworkObject entity)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetPointToFlee(Vector3 point)
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

		protected override void Pause()
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

		public Vector3 GetFleePosition()
		{
			return default(Vector3);
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

		private void RpcWriter___Observers_SetEntityToFlee_3323014238(NetworkObject entity)
		{
		}

		public void RpcLogic___SetEntityToFlee_3323014238(NetworkObject entity)
		{
		}

		private void RpcReader___Observers_SetEntityToFlee_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetPointToFlee_4276783012(Vector3 point)
		{
		}

		public void RpcLogic___SetPointToFlee_4276783012(Vector3 point)
		{
		}

		private void RpcReader___Observers_SetPointToFlee_4276783012(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
