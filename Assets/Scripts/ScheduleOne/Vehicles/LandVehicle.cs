using System;
using System.Collections.Generic;
using EPOOutline;
using FishNet.Component.Ownership;
using FishNet.Component.Transforming;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Pathfinding;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Money;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Storage;
using ScheduleOne.Tools;
using ScheduleOne.Vehicles.AI;
using ScheduleOne.Vehicles.Modification;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace ScheduleOne.Vehicles
{
	[RequireComponent(typeof(VehicleCamera))]
	[RequireComponent(typeof(NetworkTransform))]
	[RequireComponent(typeof(PredictedOwner))]
	[RequireComponent(typeof(VehicleCollisionDetector))]
	[RequireComponent(typeof(PhysicsDamageable))]
	public class LandVehicle : NetworkBehaviour, IGUIDRegisterable, ISaveable
	{
		[Serializable]
		public class BodyMesh
		{
			public MeshRenderer Renderer;

			public int MaterialIndex;
		}

		public delegate void VehiclePlayerEvent(Player player);

		public const float KINEMATIC_THRESHOLD_DISTANCE = 30f;

		public const float MAX_TURNOVER_SPEED = 5f;

		public const float TURNOVER_FORCE = 8f;

		public const bool USE_WHEEL = false;

		public const float SPEED_DISPLAY_MULTIPLIER = 1.4f;

		public bool DEBUG;

		[Header("Settings")]
		[SerializeField]
		protected string vehicleName;

		[SerializeField]
		protected string vehicleCode;

		[SerializeField]
		protected float vehiclePrice;

		public bool UseHumanoidCollider;

		public bool SpawnAsPlayerOwned;

		[Header("References")]
		[SerializeField]
		protected GameObject vehicleModel;

		[SerializeField]
		protected WheelCollider[] driveWheels;

		[SerializeField]
		protected WheelCollider[] steerWheels;

		[SerializeField]
		protected WheelCollider[] handbrakeWheels;

		[HideInInspector]
		public List<Wheel> wheels;

		[SerializeField]
		protected InteractableObject intObj;

		[SerializeField]
		protected List<Transform> exitPoints;

		[SerializeField]
		protected Rigidbody rb;

		public VehicleSeat[] Seats;

		public BoxCollider boundingBox;

		public VehicleAgent Agent;

		public SmoothedVelocityCalculator VelocityCalculator;

		public StorageDoorAnimation Trunk;

		public NavMeshObstacle NavMeshObstacle;

		public NavmeshCut NavmeshCut;

		public VehicleHumanoidCollider HumanoidColliderContainer;

		public POI POI;

		[SerializeField]
		protected Transform centerOfMass;

		[SerializeField]
		protected Transform cameraOrigin;

		[SerializeField]
		protected VehicleLights lights;

		[Header("Steer settings")]
		[SerializeField]
		protected float maxSteeringAngle;

		[SerializeField]
		protected float steerRate;

		[SerializeField]
		protected bool flipSteer;

		[Header("Drive settings")]
		[SerializeField]
		protected AnimationCurve motorTorque;

		public float TopSpeed;

		[Range(2f, 16f)]
		[SerializeField]
		protected float diffGearing;

		[SerializeField]
		protected float handBrakeForce;

		[SerializeField]
		protected AnimationCurve brakeForce;

		[Range(0.5f, 10f)]
		[SerializeField]
		protected float downforce;

		[Range(0f, 1f)]
		[SerializeField]
		protected float reverseMultiplier;

		[Header("Color Settings")]
		[SerializeField]
		protected BodyMesh[] BodyMeshes;

		public EVehicleColor DefaultColor;

		private EVehicleColor DisplayedColor;

		[Header("Outline settings")]
		[SerializeField]
		protected List<GameObject> outlineRenderers;

		protected Outlinable outlineEffect;

		[Header("Control overrides")]
		public bool overrideControls;

		public float throttleOverride;

		public float steerOverride;

		[Header("Storage settings")]
		public StorageEntity Storage;

		private VehicleSeat localPlayerSeat;

		private List<float> previousSpeeds;

		private int previousSpeedsSampleSize;

		[SyncVar(Channel = Channel.Unreliable, SendRate = 0.05f, WritePermissions = WritePermission.ClientUnsynchronized)]
		public float currentSteerAngle;

		private float lastFrameSteerAngle;

		private float lastReplicatedSteerAngle;

		private bool justExitedVehicle;

		private Vector3 lastFramePosition;

		private Transform closestExitPoint;

		[HideInInspector]
		public ParkData CurrentParkData;

		private VehicleLoader loader;

		public VehiclePlayerEvent onPlayerEnterVehicle;

		public VehiclePlayerEvent onPlayerExitVehicle;

		public UnityEvent onVehicleStart;

		public UnityEvent onVehicleStop;

		public UnityEvent onHandbrakeApplied;

		public UnityEvent<Collision> onCollision;

		public SyncVar<float> syncVar___currentSteerAngle;

		public SyncVar<bool> syncVar____003CbrakesApplied_003Ek__BackingField;

		public SyncVar<bool> syncVar____003CisReversing_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002ELandVehicleAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002ELandVehicleAssembly_002DCSharp_002Edll_Excuted;

		public string VehicleName => null;

		public string VehicleCode => null;

		public float VehiclePrice => 0f;

		public bool IsPlayerOwned { get; protected set; }

		public bool IsVisible { get; protected set; }

		public Guid GUID { get; protected set; }

		public float DistanceToLocalCamera { get; private set; }

		public Vector3 boundingBoxDimensions => default(Vector3);

		public Transform driverEntryPoint => null;

		public Rigidbody Rb => null;

		public float ActualMaxSteeringAngle => 0f;

		public bool MaxSteerAngleOverridden { get; private set; }

		public float OverriddenMaxSteerAngle { get; private set; }

		public EVehicleColor OwnedColor { get; private set; }

		public int Capacity => 0;

		public int CurrentPlayerOccupancy => 0;

		public bool localPlayerIsDriver { get; protected set; }

		public bool localPlayerIsInVehicle { get; protected set; }

		public bool isOccupied { get; private set; }

		public Player DriverPlayer => null;

		public List<Player> OccupantPlayers => null;

		public NPC[] OccupantNPCs { get; protected set; }

		public float speed_Kmh { get; protected set; }

		public float speed_Ms => 0f;

		public float speed_Mph => 0f;

		public float currentThrottle { get; protected set; }

		[field: SyncVar(Channel = Channel.Unreliable, SendRate = 0.1f, WritePermissions = WritePermission.ClientUnsynchronized)]
		public bool brakesApplied { get; set; }

		[field: SyncVar(Channel = Channel.Unreliable, SendRate = 0.1f, WritePermissions = WritePermission.ClientUnsynchronized)]
		public bool isReversing { get; set; }

		public bool isStatic { get; protected set; }

		public bool handbrakeApplied { get; protected set; }

		public float boundingBaseOffset => 0f;

		public bool isParked => false;

		public ParkingLot CurrentParkingLot { get; protected set; }

		public ParkingSpot CurrentParkingSpot { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

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

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public override void OnStartClient()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetIsPlayerOwned(NetworkConnection conn, bool playerOwned)
		{
		}

		private void RefreshPoI()
		{
		}

		public void SetGUID(Guid guid)
		{
		}

		protected virtual void Start()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void GetNetworth(MoneyManager.FloatContainer container)
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

		protected virtual void OnMinPass()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		protected virtual void SetOwner(NetworkConnection conn)
		{
		}

		[ObserversRpc]
		protected virtual void OnOwnerChanged()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetTransform_Server(Vector3 pos, Quaternion rot)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetTransform(Vector3 pos, Quaternion rot)
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

		[ServerRpc(RequireOwnership = false)]
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

		public void AlignTo(Transform target, EParkingAlignment type, bool network = false)
		{
		}

		public Tuple<Vector3, Quaternion> GetAlignmentTransform(Transform target, EParkingAlignment type)
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

		public VehicleSeat GetFirstFreeSeat()
		{
			return null;
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSeatOccupant(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SetSeatOccupant_Server(int seatIndex, NetworkConnection conn)
		{
		}

		private void Hovered()
		{
		}

		private void Interacted()
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

		public Transform GetExitPoint(int seatIndex = 0)
		{
			return null;
		}

		private Transform GetClosestExitPoint(Vector3 pos)
		{
			return null;
		}

		private Transform GetValidExitPoint(List<Transform> possibleExitPoints)
		{
			return null;
		}

		public void AddNPCOccupant(NPC npc)
		{
		}

		public void RemoveNPCOccupant(NPC npc)
		{
		}

		public virtual bool CanBeRecovered()
		{
			return false;
		}

		public virtual void RecoverVehicle()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendOwnedColor(EVehicleColor col)
		{
		}

		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		protected virtual void SetOwnedColor(NetworkConnection conn, EVehicleColor col)
		{
		}

		public virtual void ApplyColor(EVehicleColor col)
		{
		}

		public void ApplyOwnedColor()
		{
		}

		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
		}

		public void HideOutline()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void Park_Networked(NetworkConnection conn, ParkData parkData)
		{
		}

		public void Park(NetworkConnection conn, ParkData parkData, bool network)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ExitPark_Networked(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		public void ExitPark(bool moveToExitPoint = true)
		{
		}

		public void SetVisible(bool vis)
		{
		}

		public List<ItemInstance> GetContents()
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public virtual void Load(VehicleData data, string containerPath)
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

		private void RpcWriter___Observers_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
		}

		public void RpcLogic___SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
		}

		private void RpcReader___Observers_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetIsPlayerOwned_214505783(NetworkConnection conn, bool playerOwned)
		{
		}

		private void RpcReader___Target_SetIsPlayerOwned_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
		}

		protected virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_OnOwnerChanged_2166136261()
		{
		}

		protected virtual void RpcLogic___OnOwnerChanged_2166136261()
		{
		}

		private void RpcReader___Observers_OnOwnerChanged_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		public void RpcLogic___SetTransform_Server_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		private void RpcReader___Server_SetTransform_Server_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		public void RpcLogic___SetTransform_3848837105(Vector3 pos, Quaternion rot)
		{
		}

		private void RpcReader___Observers_SetTransform_3848837105(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetSteeringAngle_431000436(float sa)
		{
		}

		private void RpcLogic___SetSteeringAngle_431000436(float sa)
		{
		}

		private void RpcReader___Server_SetSteeringAngle_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		private void RpcLogic___SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		private void RpcReader___Observers_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetSeatOccupant_3428404692(NetworkConnection conn, int seatIndex, NetworkConnection occupant)
		{
		}

		private void RpcReader___Target_SetSeatOccupant_3428404692(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
		}

		private void RpcLogic___SetSeatOccupant_Server_3266232555(int seatIndex, NetworkConnection conn)
		{
		}

		private void RpcReader___Server_SetSeatOccupant_Server_3266232555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendOwnedColor_911055161(EVehicleColor col)
		{
		}

		public void RpcLogic___SendOwnedColor_911055161(EVehicleColor col)
		{
		}

		private void RpcReader___Server_SendOwnedColor_911055161(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
		}

		protected virtual void RpcLogic___SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
		}

		private void RpcReader___Target_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetOwnedColor_1679996372(NetworkConnection conn, EVehicleColor col)
		{
		}

		private void RpcReader___Observers_SetOwnedColor_1679996372(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
		}

		private void RpcLogic___Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
		}

		private void RpcReader___Observers_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_Park_Networked_2633993806(NetworkConnection conn, ParkData parkData)
		{
		}

		private void RpcReader___Target_Park_Networked_2633993806(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		public void RpcLogic___ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		private void RpcReader___Observers_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ExitPark_Networked_214505783(NetworkConnection conn, bool moveToExitPoint = true)
		{
		}

		private void RpcReader___Target_ExitPark_Networked_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EVehicles_002ELandVehicle(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EVehicles_002ELandVehicle_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
