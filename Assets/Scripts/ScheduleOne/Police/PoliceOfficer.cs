namespace ScheduleOne.Police
{
	public class PoliceOfficer : global::ScheduleOne.NPCs.NPC
	{
		public const float DEACTIVATION_TIME = 1f;

		public const float INVESTIGATION_COOLDOWN = 60f;

		public const float INVESTIGATION_MAX_DISTANCE = 8f;

		public const float INVESTIGATION_MIN_VISIBILITY = 0.2f;

		public const float INVESTIGATION_CHECK_INTERVAL = 1f;

		public const float BODY_SEARCH_CHANCE_DEFAULT = 0.1f;

		public const float MIN_CHATTER_INTERVAL = 15f;

		public const float MAX_CHATTER_INTERVAL = 45f;

		public static global::System.Action<global::ScheduleOne.Vision.VisionEventReceipt> OnPoliceVisionEvent;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Police.PoliceOfficer> Officers;

		public global::ScheduleOne.Vehicles.LandVehicle AssignedVehicle;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.NPCs.Behaviour.PursuitBehaviour PursuitBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviour VehiclePursuitBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.BodySearchBehaviour BodySearchBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.CheckpointBehaviour CheckpointBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.FootPatrolBehaviour FootPatrolBehaviour;

		public global::ScheduleOne.FX.ProximityCircle ProxCircle;

		public global::ScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviour VehiclePatrolBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.SentryBehaviour SentryBehaviour;

		public global::ScheduleOne.VoiceOver.PoliceChatterVO ChatterVO;

		public global::ScheduleOne.NPCs.Behaviour.Behaviour[] DeactivationBlockingBehaviours;

		[global::UnityEngine.Header("Dialogue")]
		public global::ScheduleOne.Dialogue.DialogueContainer CheckpointDialogue;

		[global::UnityEngine.Header("Tools")]
		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable BatonPrefab;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable TaserPrefab;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable GunPrefab;

		[global::UnityEngine.Header("Settings")]
		public bool AutoDeactivate;

		public bool ChatterEnabled;

		[global::UnityEngine.Header("Behaviour Settings")]
		[global::UnityEngine.Range(0f, 1f)]
		public float Suspicion;

		[global::UnityEngine.Range(0f, 1f)]
		public float Leniency;

		[global::UnityEngine.Header("Body Search Settings")]
		[global::UnityEngine.Range(0f, 1f)]
		public float BodySearchChance;

		[global::UnityEngine.Range(1f, 10f)]
		public float BodySearchDuration;

		[global::UnityEngine.HideInInspector]
		public global::ScheduleOne.AvatarFramework.Customization.PoliceBelt belt;

		private float timeSinceReadyToPool;

		private float timeSinceOutOfSight;

		private float chatterCountDown;

		private global::ScheduleOne.Police.Investigation currentBodySearchInvestigation;

		private bool generalCrimeResponseActive;

		private bool NetworkInitialize___EarlyScheduleOne_002EPolice_002EPoliceOfficerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPolice_002EPoliceOfficerAssembly_002DCSharp_002Edll_Excuted;

		public global::FishNet.Object.NetworkObject PursuitTarget => null;

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected void Update()
		{
		}

		protected override void MinPass()
		{
		}

		private void UpdateVision()
		{
		}

		private void CheckDeactivation()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginFootPursuit_Networked(string playerCode, bool includeColleagues = true)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void BeginFootPursuit(string playerCode)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginVehiclePursuit_Networked(string playerCode, global::FishNet.Object.NetworkObject vehicle, bool beginAsSighted)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void BeginVehiclePursuit(string playerCode, global::FishNet.Object.NetworkObject vehicle, bool beginAsSighted)
		{
		}

		public void BeginBodySearch_LocalPlayer()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public virtual void BeginBodySearch_Networked(string playerCode)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void BeginBodySearch(string playerCode)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public virtual void AssignToCheckpoint(global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation location)
		{
		}

		public void UnassignFromCheckpoint()
		{
		}

		public void StartFootPatrol(global::ScheduleOne.NPCs.Behaviour.PatrolGroup group, bool warpToStartPoint)
		{
		}

		public void StartVehiclePatrol(global::ScheduleOne.NPCs.Behaviour.VehiclePatrolRoute route, global::ScheduleOne.Vehicles.LandVehicle vehicle)
		{
		}

		public virtual void AssignToSentryLocation(global::ScheduleOne.Law.SentryLocation location)
		{
		}

		public void UnassignFromSentryLocation()
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		protected bool ShouldNoticeGeneralCrime(global::ScheduleOne.PlayerScripts.Player player)
		{
			return false;
		}

		public override bool ShouldSave()
		{
			return false;
		}

		public override string GetNameAddress()
		{
			return null;
		}

		private void UpdateChatter()
		{
		}

		private void ProcessVisionEvent(global::ScheduleOne.Vision.VisionEventReceipt visionEventReceipt)
		{
		}

		public static global::ScheduleOne.Police.PoliceOfficer GetNearestOfficer(global::UnityEngine.Vector3 position, out float distanceToTarget, bool onlyConscious = true)
		{
			distanceToTarget = default(float);
			return null;
		}

		private new void OnDie()
		{
		}

		public virtual void UpdateBodySearch()
		{
		}

		private bool CanInvestigate()
		{
			return false;
		}

		private void UpdateExistingInvestigation()
		{
		}

		private void CheckNewInvestigation()
		{
		}

		private void StartBodySearchInvestigation(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		private void StopBodySearchInvestigation()
		{
		}

		public void ConductBodySearch(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		private bool CanInvestigatePlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
			return false;
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

		private void RpcWriter___Server_BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = true)
		{
		}

		public virtual void RpcLogic___BeginFootPursuit_Networked_310431262(string playerCode, bool includeColleagues = true)
		{
		}

		private void RpcReader___Server_BeginFootPursuit_Networked_310431262(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_BeginFootPursuit_3615296227(string playerCode)
		{
		}

		private void RpcLogic___BeginFootPursuit_3615296227(string playerCode)
		{
		}

		private void RpcReader___Observers_BeginFootPursuit_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_BeginVehiclePursuit_Networked_1834136777(string playerCode, global::FishNet.Object.NetworkObject vehicle, bool beginAsSighted)
		{
		}

		public virtual void RpcLogic___BeginVehiclePursuit_Networked_1834136777(string playerCode, global::FishNet.Object.NetworkObject vehicle, bool beginAsSighted)
		{
		}

		private void RpcReader___Server_BeginVehiclePursuit_Networked_1834136777(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_BeginVehiclePursuit_1834136777(string playerCode, global::FishNet.Object.NetworkObject vehicle, bool beginAsSighted)
		{
		}

		private void RpcLogic___BeginVehiclePursuit_1834136777(string playerCode, global::FishNet.Object.NetworkObject vehicle, bool beginAsSighted)
		{
		}

		private void RpcReader___Observers_BeginVehiclePursuit_1834136777(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_BeginBodySearch_Networked_3615296227(string playerCode)
		{
		}

		public virtual void RpcLogic___BeginBodySearch_Networked_3615296227(string playerCode)
		{
		}

		private void RpcReader___Server_BeginBodySearch_Networked_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_BeginBodySearch_3615296227(string playerCode)
		{
		}

		private void RpcLogic___BeginBodySearch_3615296227(string playerCode)
		{
		}

		private void RpcReader___Observers_BeginBodySearch_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_AssignToCheckpoint_4087078542(global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation location)
		{
		}

		public virtual void RpcLogic___AssignToCheckpoint_4087078542(global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation location)
		{
		}

		private void RpcReader___Observers_AssignToCheckpoint_4087078542(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EPolice_002EPoliceOfficer_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
