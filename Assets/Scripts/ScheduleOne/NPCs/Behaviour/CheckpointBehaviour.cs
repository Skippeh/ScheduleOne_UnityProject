using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Dialogue;
using ScheduleOne.Law;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Police;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class CheckpointBehaviour : Behaviour
	{
		public const float LOOK_TIME = 1.5f;

		private float currentLookTime;

		private bool trunkOpened;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ECheckpointBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ECheckpointBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public CheckpointManager.ECheckpointLocation AssignedCheckpoint { get; protected set; }

		public RoadCheckpoint Checkpoint { get; protected set; }

		public bool IsSearching { get; protected set; }

		public LandVehicle CurrentSearchedVehicle { get; protected set; }

		public Player Initiator { get; protected set; }

		private Transform standPoint => null;

		private DialogueDatabase dialogueDatabase => null;

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

		public override void ActiveMinPass()
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetCheckpoint(CheckpointManager.ECheckpointLocation loc)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetInitiator(NetworkObject init)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void StartSearch(NetworkObject targetVehicle, NetworkObject initiator)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void StopSearch()
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetIsSearching(bool s)
		{
		}

		private Vector3 GetSearchPoint()
		{
			return default(Vector3);
		}

		[ObserversRpc(RunLocally = true)]
		private void ConcludeSearch()
		{
		}

		private bool DoesVehicleContainIllicitItems()
		{
			return false;
		}

		private void PlayerWalkedThroughCheckPoint(Player player)
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

		private void RpcWriter___Observers_SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
		}

		public void RpcLogic___SetCheckpoint_4087078542(CheckpointManager.ECheckpointLocation loc)
		{
		}

		private void RpcReader___Observers_SetCheckpoint_4087078542(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetInitiator_3323014238(NetworkObject init)
		{
		}

		public void RpcLogic___SetInitiator_3323014238(NetworkObject init)
		{
		}

		private void RpcReader___Observers_SetInitiator_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
		}

		public void RpcLogic___StartSearch_3694055493(NetworkObject targetVehicle, NetworkObject initiator)
		{
		}

		private void RpcReader___Server_StartSearch_3694055493(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_StopSearch_2166136261()
		{
		}

		public void RpcLogic___StopSearch_2166136261()
		{
		}

		private void RpcReader___Server_StopSearch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsSearching_1140765316(bool s)
		{
		}

		public void RpcLogic___SetIsSearching_1140765316(bool s)
		{
		}

		private void RpcReader___Observers_SetIsSearching_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ConcludeSearch_2166136261()
		{
		}

		private void RpcLogic___ConcludeSearch_2166136261()
		{
		}

		private void RpcReader___Observers_ConcludeSearch_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
