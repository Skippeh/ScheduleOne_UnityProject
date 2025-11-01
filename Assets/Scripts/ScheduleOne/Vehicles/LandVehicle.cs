namespace ScheduleOne.Vehicles
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Vehicles.VehicleCamera))]
	[global::UnityEngine.RequireComponent(typeof(global::FishNet.Component.Transforming.NetworkTransform))]
	[global::UnityEngine.RequireComponent(typeof(global::FishNet.Component.Ownership.PredictedOwner))]
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Vehicles.VehicleCollisionDetector))]
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Combat.PhysicsDamageable))]
	public class LandVehicle : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Persistence.ISaveable
	{
		[global::System.Serializable]
		public class BodyMesh
		{
			public global::UnityEngine.MeshRenderer Renderer;

			public int MaterialIndex;
		}

		public delegate void VehiclePlayerEvent(global::ScheduleOne.PlayerScripts.Player player);

		public const float KINEMATIC_THRESHOLD_DISTANCE = 30f;

		public const float MAX_TURNOVER_SPEED = 5f;

		public const float TURNOVER_FORCE = 8f;

		public const bool USE_WHEEL = false;

		public const float SPEED_DISPLAY_MULTIPLIER = 1.4f;

		public bool DEBUG;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected string vehicleName;

		[global::UnityEngine.SerializeField]
		protected string vehicleCode;

		[global::UnityEngine.SerializeField]
		protected float vehiclePrice;

		public bool UseHumanoidCollider;

		public bool SpawnAsPlayerOwned;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject vehicleModel;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.WheelCollider[] driveWheels;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.WheelCollider[] steerWheels;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.WheelCollider[] handbrakeWheels;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.Wheel> wheels;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject intObj;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.Transform> exitPoints;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Rigidbody rb;

		public global::ScheduleOne.Vehicles.VehicleSeat[] Seats;

		public global::UnityEngine.BoxCollider boundingBox;

		public global::ScheduleOne.Vehicles.AI.VehicleAgent Agent;

		public global::ScheduleOne.Tools.SmoothedVelocityCalculator VelocityCalculator;

		public global::ScheduleOne.Storage.StorageDoorAnimation Trunk;

		public global::UnityEngine.AI.NavMeshObstacle NavMeshObstacle;

		public global::Pathfinding.NavmeshCut NavmeshCut;

		public global::ScheduleOne.Vehicles.VehicleHumanoidCollider HumanoidColliderContainer;

		public global::ScheduleOne.Map.POI POI;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.Sound.VehicleSound> Sounds;

		public global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.PlayerPusher> Pushers;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform centerOfMass;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform cameraOrigin;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Vehicles.VehicleLights lights;

		[global::UnityEngine.Header("Steer settings")]
		[global::UnityEngine.SerializeField]
		protected float maxSteeringAngle;

		[global::UnityEngine.SerializeField]
		protected float steerRate;

		[global::UnityEngine.SerializeField]
		protected bool flipSteer;

		[global::UnityEngine.Header("Drive settings")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve motorTorque;

		public float TopSpeed;

		[global::UnityEngine.Range(2f, 16f)]
		[global::UnityEngine.SerializeField]
		protected float diffGearing;

		[global::UnityEngine.SerializeField]
		protected float handBrakeForce;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.AnimationCurve brakeForce;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.1f, 3f)]
		protected float BrakeForceMultiplier;

		[global::UnityEngine.Range(0.5f, 10f)]
		[global::UnityEngine.SerializeField]
		protected float downforce;

		[global::UnityEngine.Range(0f, 1f)]
		[global::UnityEngine.SerializeField]
		protected float reverseMultiplier;

		[global::UnityEngine.Header("Color Settings")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Vehicles.LandVehicle.BodyMesh[] BodyMeshes;

		public global::ScheduleOne.Vehicles.Modification.EVehicleColor DefaultColor;

		private global::ScheduleOne.Vehicles.Modification.EVehicleColor DisplayedColor;

		[global::UnityEngine.Header("Outline settings")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.GameObject> outlineRenderers;

		protected global::EPOOutline.Outlinable outlineEffect;

		[global::UnityEngine.Header("Control overrides")]
		public bool overrideControls;

		public float throttleOverride;

		public float steerOverride;

		[global::UnityEngine.Header("Storage settings")]
		public global::ScheduleOne.Storage.StorageEntity Storage;

		private global::ScheduleOne.Vehicles.VehicleSeat localPlayerSeat;

		private bool _isOccupied;

		private RollingAverage<float> previousSpeeds;

		private const int previousSpeedsSampleSize = 20;

		[global::FishNet.Object.Synchronizing.SyncVar(Channel = global::FishNet.Transporting.Channel.Unreliable, SendRate = 0.05f, WritePermissions = global::FishNet.Object.Synchronizing.WritePermission.ClientUnsynchronized)]
		public float currentSteerAngle;

		private float lastFrameSteerAngle;

		private float lastReplicatedSteerAngle;

		private bool justExitedVehicle;

		private global::UnityEngine.Vector3 lastFramePosition;

		private global::UnityEngine.Transform closestExitPoint;

		[global::UnityEngine.HideInInspector]
		public global::ScheduleOne.Vehicles.ParkData CurrentParkData;

		private global::ScheduleOne.Persistence.Loaders.VehicleLoader loader;

		public global::ScheduleOne.Vehicles.LandVehicle.VehiclePlayerEvent onPlayerEnterVehicle;

		public global::ScheduleOne.Vehicles.LandVehicle.VehiclePlayerEvent onPlayerExitVehicle;

		public global::UnityEngine.Events.UnityEvent onVehicleStart;

		public global::UnityEngine.Events.UnityEvent onVehicleStop;

		public global::UnityEngine.Events.UnityEvent onHandbrakeApplied;

		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.Collision> onCollision;

		public global::UnityEngine.Events.UnityEvent<bool> onOccupy;

		public global::FishNet.Object.Synchronizing.SyncVar<float> syncVar___currentSteerAngle;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CbrakesApplied_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CisReversing_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002ELandVehicleAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002ELandVehicleAssembly_002DCSharp_002Edll_Excuted;

		public string VehicleName => null;

		public string VehicleCode => null;

		public float VehiclePrice => 0f;

		public bool IsPlayerOwned { get; protected set; }

		public bool IsVisible { get; protected set; }

		public global::System.Guid GUID { get; protected set; }

		public global::UnityEngine.Vector3 boundingBoxDimensions => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Transform driverEntryPoint => null;

		public global::UnityEngine.Rigidbody Rb => null;

		public float ActualMaxSteeringAngle => 0f;

		public bool MaxSteerAngleOverridden { get; private set; }

		public float OverriddenMaxSteerAngle { get; private set; }

		public global::ScheduleOne.Vehicles.Modification.EVehicleColor OwnedColor { get; private set; }

		public int Capacity => 0;

		public int CurrentPlayerOccupancy => 0;

		public bool localPlayerIsDriver { get; protected set; }

		public bool localPlayerIsInVehicle { get; protected set; }

		public bool isOccupied
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::ScheduleOne.PlayerScripts.Player DriverPlayer => null;

		public global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> OccupantPlayers => null;

		public global::ScheduleOne.NPCs.NPC[] OccupantNPCs { get; protected set; }

		public float speed_Kmh { get; protected set; }

		public float speed_Ms => 0f;

		public float speed_Mph => 0f;

		public float currentThrottle { get; protected set; }

		public bool brakesApplied
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return false;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		public bool isReversing
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return false;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		public bool isStatic { get; protected set; }

		public bool handbrakeApplied { get; protected set; }

		public float boundingBaseOffset => 0f;

		public bool isParked => false;

		public global::ScheduleOne.Map.ParkingLot CurrentParkingLot { get; protected set; }

		public global::ScheduleOne.Map.ParkingSpot CurrentParkingSpot { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public float SyncAccessor_currentSteerAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool SyncAccessor__003CbrakesApplied_003Ek__BackingField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SyncAccessor__003CisReversing_003Ek__BackingField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public override void OnStartServer()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public override void OnStartClient()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetIsPlayerOwned(global::FishNet.Connection.NetworkConnection conn, bool playerOwned)
		{
		}

		private void RefreshPoI()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		protected virtual void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void GetNetworth(global::ScheduleOne.Money.MoneyManager.FloatContainer container)
		{
		}

		protected virtual void Update()
		{
		}

		private void OnDrawGizmos()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void OnCollisionEnter(global::UnityEngine.Collision collision)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		protected virtual void SetOwner(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		protected virtual void OnOwnerChanged()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTransform_Server(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetTransform(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot)
		{
		}

		public void DestroyVehicle()
		{
		}

		protected virtual void UpdateThrottle()
		{
		}

		protected virtual void ApplyThrottle()
		{
		}

		public void ApplyHandbrake()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SetSteeringAngle(float sa)
		{
		}

		protected virtual void UpdateSteerAngle()
		{
		}

		protected virtual void ApplySteerAngle()
		{
		}

		private void DelaySetStatic(bool stat)
		{
		}

		public virtual void SetIsStatic(bool stat)
		{
		}

		public void AlignTo(global::UnityEngine.Transform target, global::ScheduleOne.Vehicles.EParkingAlignment type, bool network = false)
		{
		}

		public global::System.Tuple<global::UnityEngine.Vector3, global::UnityEngine.Quaternion> GetAlignmentTransform(global::UnityEngine.Transform target, global::ScheduleOne.Vehicles.EParkingAlignment type)
		{
			return null;
		}

		public float GetVehicleValue()
		{
			return 0f;
		}

		public void OverrideMaxSteerAngle(float maxAngle)
		{
		}

		public void ResetMaxSteerAngle()
		{
		}

		public void SetObstaclesActive(bool active)
		{
		}

		public global::ScheduleOne.Vehicles.VehicleSeat GetFirstFreeSeat()
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetSeatOccupant(global::FishNet.Connection.NetworkConnection conn, int seatIndex, global::FishNet.Connection.NetworkConnection occupant)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SetSeatOccupant_Server(int seatIndex, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void Hovered()
		{
		}

		private void Interacted()
		{
		}

		private void StartVehicle()
		{
		}

		private void StopVehicle()
		{
		}

		private void EnterVehicle()
		{
		}

		public void ExitVehicle()
		{
		}

		private void EndJustExited()
		{
		}

		public global::UnityEngine.Transform GetExitPoint(int seatIndex = 0)
		{
			return null;
		}

		private global::UnityEngine.Transform GetClosestExitPoint(global::UnityEngine.Vector3 pos)
		{
			return null;
		}

		private global::UnityEngine.Transform GetValidExitPoint(global::System.Collections.Generic.List<global::UnityEngine.Transform> possibleExitPoints)
		{
			return null;
		}

		public void AddNPCOccupant(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public void RemoveNPCOccupant(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public virtual bool CanBeRecovered()
		{
			return false;
		}

		public virtual void RecoverVehicle()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendOwnedColor(global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		protected virtual void SetOwnedColor(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}

		public virtual void ApplyColor(global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}

		public void ApplyOwnedColor()
		{
		}

		public void ShowOutline(global::ScheduleOne.EntityFramework.BuildableItem.EOutlineColor color)
		{
		}

		public void HideOutline()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void Park_Networked(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Vehicles.ParkData parkData)
		{
		}

		public void Park(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Vehicles.ParkData parkData, bool network)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void ExitPark_Networked(global::FishNet.Connection.NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		public void ExitPark(bool moveToExitPoint = true)
		{
		}

		public void SetVisible(bool vis)
		{
		}

		public void RegisterSound(global::ScheduleOne.Vehicles.Sound.VehicleSound sound)
		{
		}

		public void DeregisterSound(global::ScheduleOne.Vehicles.Sound.VehicleSound sound)
		{
		}

		public void RegisterPusher(global::ScheduleOne.Vehicles.PlayerPusher pusher)
		{
		}

		public void DeregisterPusher(global::ScheduleOne.Vehicles.PlayerPusher pusher)
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> GetContents()
		{
			return null;
		}

		public virtual global::ScheduleOne.Persistence.Datas.VehicleData GetVehicleData()
		{
			return null;
		}

		public string GetSaveString()
		{
			return null;
		}

		private global::ScheduleOne.Persistence.Datas.ItemSet GetContentsSet()
		{
			return null;
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.VehicleData data, string containerPath)
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

		private void RpcWriter___Observers_SetIsPlayerOwned_214505783(global::FishNet.Connection.NetworkConnection conn, bool playerOwned)
		{
		}

		public void RpcLogic___SetIsPlayerOwned_214505783(global::FishNet.Connection.NetworkConnection conn, bool playerOwned)
		{
		}

		private void RpcReader___Observers_SetIsPlayerOwned_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsPlayerOwned_214505783(global::FishNet.Connection.NetworkConnection conn, bool playerOwned)
		{
		}

		private void RpcReader___Target_SetIsPlayerOwned_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetOwner_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void RpcLogic___SetOwner_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Server_SetOwner_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_OnOwnerChanged_2166136261()
		{
		}

		protected virtual void RpcLogic___OnOwnerChanged_2166136261()
		{
		}

		private void RpcReader___Observers_OnOwnerChanged_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetTransform_Server_3848837105(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot)
		{
		}

		public void RpcLogic___SetTransform_Server_3848837105(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot)
		{
		}

		private void RpcReader___Server_SetTransform_Server_3848837105(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetTransform_3848837105(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot)
		{
		}

		public void RpcLogic___SetTransform_3848837105(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot)
		{
		}

		private void RpcReader___Observers_SetTransform_3848837105(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetSteeringAngle_431000436(float sa)
		{
		}

		private void RpcLogic___SetSteeringAngle_431000436(float sa)
		{
		}

		private void RpcReader___Server_SetSteeringAngle_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSeatOccupant_3428404692(global::FishNet.Connection.NetworkConnection conn, int seatIndex, global::FishNet.Connection.NetworkConnection occupant)
		{
		}

		private void RpcLogic___SetSeatOccupant_3428404692(global::FishNet.Connection.NetworkConnection conn, int seatIndex, global::FishNet.Connection.NetworkConnection occupant)
		{
		}

		private void RpcReader___Observers_SetSeatOccupant_3428404692(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetSeatOccupant_3428404692(global::FishNet.Connection.NetworkConnection conn, int seatIndex, global::FishNet.Connection.NetworkConnection occupant)
		{
		}

		private void RpcReader___Target_SetSeatOccupant_3428404692(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Server_SetSeatOccupant_Server_3266232555(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendOwnedColor_911055161(global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}

		public void RpcLogic___SendOwnedColor_911055161(global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}

		private void RpcReader___Server_SendOwnedColor_911055161(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_SetOwnedColor_1679996372(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}

		protected virtual void RpcLogic___SetOwnedColor_1679996372(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}

		private void RpcReader___Target_SetOwnedColor_1679996372(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetOwnedColor_1679996372(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Vehicles.Modification.EVehicleColor col)
		{
		}

		private void RpcReader___Observers_SetOwnedColor_1679996372(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Park_Networked_2633993806(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Vehicles.ParkData parkData)
		{
		}

		private void RpcLogic___Park_Networked_2633993806(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Vehicles.ParkData parkData)
		{
		}

		private void RpcReader___Observers_Park_Networked_2633993806(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Park_Networked_2633993806(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Vehicles.ParkData parkData)
		{
		}

		private void RpcReader___Target_Park_Networked_2633993806(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ExitPark_Networked_214505783(global::FishNet.Connection.NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		public void RpcLogic___ExitPark_Networked_214505783(global::FishNet.Connection.NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		private void RpcReader___Observers_ExitPark_Networked_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ExitPark_Networked_214505783(global::FishNet.Connection.NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		private void RpcReader___Target_ExitPark_Networked_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EVehicles_002ELandVehicle(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVehicles_002ELandVehicle_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
