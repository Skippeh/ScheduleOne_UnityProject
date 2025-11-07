namespace ScheduleOne.NPCs.Behaviour
{
	public class CheckpointBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float LOOK_TIME = 1.5f;

		private float currentLookTime;

		private bool trunkOpened;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ECheckpointBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ECheckpointBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation AssignedCheckpoint { get; protected set; }

		public global::ScheduleOne.Police.RoadCheckpoint Checkpoint { get; protected set; }

		public bool IsSearching { get; protected set; }

		public global::ScheduleOne.Vehicles.LandVehicle CurrentSearchedVehicle { get; protected set; }

		public global::ScheduleOne.PlayerScripts.Player Initiator { get; protected set; }

		private global::UnityEngine.Transform standPoint => null;

		private global::ScheduleOne.Dialogue.DialogueDatabase dialogueDatabase => null;

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

		public override void ActiveMinPass()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetCheckpoint(global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation loc)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetInitiator(global::FishNet.Object.NetworkObject init)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void StartSearch(global::FishNet.Object.NetworkObject targetVehicle, global::FishNet.Object.NetworkObject initiator)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void StopSearch()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetIsSearching(bool s)
		{
		}

		private global::UnityEngine.Vector3 GetSearchPoint()
		{
			return default(global::UnityEngine.Vector3);
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ConcludeSearch()
		{
		}

		private bool DoesVehicleContainIllicitItems()
		{
			return false;
		}

		private void PlayerWalkedThroughCheckPoint(global::ScheduleOne.PlayerScripts.Player player)
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

		private void RpcWriter___Observers_SetCheckpoint_4087078542(global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation loc)
		{
		}

		public void RpcLogic___SetCheckpoint_4087078542(global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation loc)
		{
		}

		private void RpcReader___Observers_SetCheckpoint_4087078542(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetInitiator_3323014238(global::FishNet.Object.NetworkObject init)
		{
		}

		public void RpcLogic___SetInitiator_3323014238(global::FishNet.Object.NetworkObject init)
		{
		}

		private void RpcReader___Observers_SetInitiator_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_StartSearch_3694055493(global::FishNet.Object.NetworkObject targetVehicle, global::FishNet.Object.NetworkObject initiator)
		{
		}

		public void RpcLogic___StartSearch_3694055493(global::FishNet.Object.NetworkObject targetVehicle, global::FishNet.Object.NetworkObject initiator)
		{
		}

		private void RpcReader___Server_StartSearch_3694055493(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_StopSearch_2166136261()
		{
		}

		public void RpcLogic___StopSearch_2166136261()
		{
		}

		private void RpcReader___Server_StopSearch_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetIsSearching_1140765316(bool s)
		{
		}

		public void RpcLogic___SetIsSearching_1140765316(bool s)
		{
		}

		private void RpcReader___Observers_SetIsSearching_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ConcludeSearch_2166136261()
		{
		}

		private void RpcLogic___ConcludeSearch_2166136261()
		{
		}

		private void RpcReader___Observers_ConcludeSearch_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
