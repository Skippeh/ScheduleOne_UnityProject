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

		protected virtual void OnKnockOut()
		{
		}

		protected virtual void OnDie()
		{
		}

		public global::ScheduleOne.NPCs.Behaviour.Behaviour GetBehaviour(string BehaviourName)
		{
			return null;
		}

		public virtual void Update()
		{
		}

		public virtual void LateUpdate()
		{
		}

		protected virtual void MinPass()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002ENPCBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
