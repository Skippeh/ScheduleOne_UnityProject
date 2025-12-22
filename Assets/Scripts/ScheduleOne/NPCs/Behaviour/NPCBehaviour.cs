namespace ScheduleOne.NPCs.Behaviour
{
	public class NPCBehaviour : global::FishNet.Object.NetworkBehaviour
	{
		public bool DEBUG_MODE;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.NPCs.NPCScheduleManager ScheduleManager;

		[global::UnityEngine.Header("Default Behaviours")]
		public global::ScheduleOne.NPCs.Behaviour.CoweringBehaviour CoweringBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.RagdollBehaviour RagdollBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.CallPoliceBehaviour CallPoliceBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.GenericDialogueBehaviour GenericDialogueBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.HeavyFlinchBehaviour HeavyFlinchBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.FaceTargetBehaviour FaceTargetBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.DeadBehaviour DeadBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.UnconsciousBehaviour UnconsciousBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.Behaviour SummonBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.ConsumeProductBehaviour ConsumeProductBehaviour;

		public global::ScheduleOne.Combat.CombatBehaviour CombatBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.FleeBehaviour FleeBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.StationaryBehaviour StationaryBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.RequestProductBehaviour RequestProductBehaviour;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.NPCs.Behaviour.Behaviour> behaviourStack;

		private global::UnityEngine.Coroutine summonRoutine;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.NPCs.Behaviour.Behaviour> enabledBehaviours;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ENPCBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ENPCBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.NPCs.Behaviour.Behaviour activeBehaviour { get; set; }

		public global::ScheduleOne.NPCs.NPC Npc { get; private set; }

		public virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnValidate()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void Summon(string buildingGUID, int doorIndex, float duration)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void ConsumeProduct(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		private void OnKnockOut()
		{
		}

		private void OnRevive()
		{
		}

		protected virtual void OnDie()
		{
		}

		public global::ScheduleOne.NPCs.Behaviour.Behaviour GetBehaviour(string BehaviourName)
		{
			return null;
		}

		public T GetBehaviour<T>() where T : global::ScheduleOne.NPCs.Behaviour.Behaviour
		{
			return null;
		}

		public virtual void Update()
		{
		}

		public virtual void LateUpdate()
		{
		}

		protected virtual void OnTick()
		{
		}

		public void SortBehaviourStack()
		{
		}

		private global::ScheduleOne.NPCs.Behaviour.Behaviour GetEnabledBehaviour()
		{
			return null;
		}

		private void AddEnabledBehaviour(global::ScheduleOne.NPCs.Behaviour.Behaviour b)
		{
		}

		private void RemoveEnabledBehaviour(global::ScheduleOne.NPCs.Behaviour.Behaviour b)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void EnableBehaviour_Server(int behaviourIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void EnableBehaviour_Client(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void DisableBehaviour_Server(int behaviourIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void DisableBehaviour_Client(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ActivateBehaviour_Server(int behaviourIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void ActivateBehaviour_Client(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void DeactivateBehaviour_Server(int behaviourIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void DeactivateBehaviour_Client(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void PauseBehaviour_Server(int behaviourIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void PauseBehaviour_Client(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ResumeBehaviour_Server(int behaviourIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void ResumeBehaviour_Client(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
		}

		public void RpcLogic___Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
		}

		private void RpcReader___Server_Summon_900355577(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_ConsumeProduct_2622925554(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		public void RpcLogic___ConsumeProduct_2622925554(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		private void RpcReader___Server_ConsumeProduct_2622925554(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_EnableBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		public void RpcLogic___EnableBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		private void RpcReader___Server_EnableBehaviour_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_EnableBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		public void RpcLogic___EnableBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Observers_EnableBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_EnableBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Target_EnableBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_DisableBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		public void RpcLogic___DisableBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		private void RpcReader___Server_DisableBehaviour_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_DisableBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		public void RpcLogic___DisableBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Observers_DisableBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_DisableBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Target_DisableBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ActivateBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		public void RpcLogic___ActivateBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		private void RpcReader___Server_ActivateBehaviour_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ActivateBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		public void RpcLogic___ActivateBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Observers_ActivateBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ActivateBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Target_ActivateBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_DeactivateBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		public void RpcLogic___DeactivateBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		private void RpcReader___Server_DeactivateBehaviour_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_DeactivateBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		public void RpcLogic___DeactivateBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Observers_DeactivateBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_DeactivateBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Target_DeactivateBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_PauseBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		public void RpcLogic___PauseBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		private void RpcReader___Server_PauseBehaviour_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PauseBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		public void RpcLogic___PauseBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Observers_PauseBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_PauseBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Target_PauseBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ResumeBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		public void RpcLogic___ResumeBehaviour_Server_3316948804(int behaviourIndex)
		{
		}

		private void RpcReader___Server_ResumeBehaviour_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ResumeBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		public void RpcLogic___ResumeBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Observers_ResumeBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ResumeBehaviour_Client_2681120339(global::FishNet.Connection.NetworkConnection conn, int behaviourIndex)
		{
		}

		private void RpcReader___Target_ResumeBehaviour_Client_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002ENPCBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
