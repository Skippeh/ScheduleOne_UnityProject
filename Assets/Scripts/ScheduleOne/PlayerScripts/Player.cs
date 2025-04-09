using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Combat;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Map;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts.Health;
using ScheduleOne.Product;
using ScheduleOne.Property;
using ScheduleOne.Skating;
using ScheduleOne.Stealth;
using ScheduleOne.Tools;
using ScheduleOne.UI;
using ScheduleOne.Variables;
using ScheduleOne.Vehicles;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerScripts
{
	public class Player : NetworkBehaviour, ISaveable, IDamageable
	{
		public delegate void VehicleEvent(LandVehicle vehicle);

		public delegate void VehicleTransformEvent(LandVehicle vehicle, Transform exitPoint);

		public const string OWNER_PLAYER_CODE = "Local";

		public const float CapColDefaultHeight = 2f;

		public List<NetworkObject> objectsTemporarilyOwnedByPlayer;

		public static Action onLocalPlayerSpawned;

		public static Action<Player> onPlayerSpawned;

		public static Action<Player> onPlayerDespawned;

		public static Player Local;

		public static List<Player> PlayerList;

		[Header("References")]
		public GameObject LocalGameObject;

		public ScheduleOne.AvatarFramework.Avatar Avatar;

		public AvatarAnimation Anim;

		public SmoothedVelocityCalculator VelocityCalculator;

		public Vector3 EyePosition;

		public AvatarSettings TestAvatarSettings;

		public PlayerVisualState VisualState;

		public PlayerVisibility Visibility;

		public CapsuleCollider CapCol;

		public POI PoI;

		public PlayerHealth Health;

		public PlayerCrimeData CrimeData;

		public PlayerEnergy Energy;

		public Transform MimicCamera;

		public AvatarFootstepDetector FootstepDetector;

		public LocalPlayerFootstepGenerator LocalFootstepDetector;

		public CharacterController CharacterController;

		public AudioSourceController PunchSound;

		public OptimizedLight ThirdPersonFlashlight;

		public WorldspaceDialogueRenderer NameLabel;

		public PlayerClothing Clothing;

		[Header("Settings")]
		public LayerMask GroundDetectionMask;

		public float AvatarOffset_Standing;

		public float AvatarOffset_Crouched;

		[Header("Movement mapping")]
		public AnimationCurve WalkingMapCurve;

		public AnimationCurve CrouchWalkMapCurve;

		public NetworkConnection Connection;

		public VehicleEvent onEnterVehicle;

		public VehicleTransformEvent onExitVehicle;

		public LandVehicle LastDrivenVehicle;

		public Action<Skateboard> onSkateboardMounted;

		public Action onSkateboardDismounted;

		public bool HasCompletedIntro;

		public ItemSlot[] Inventory;

		[Header("Appearance debugging")]
		public BasicAvatarSettings DebugAvatarSettings;

		private PlayerLoader loader;

		public UnityEvent onRagdoll;

		public UnityEvent onRagdollEnd;

		public UnityEvent onArrested;

		public UnityEvent onFreed;

		public UnityEvent onTased;

		public UnityEvent onTasedEnd;

		public UnityEvent onPassedOut;

		public UnityEvent onPassOutRecovery;

		public List<BaseVariable> PlayerVariables;

		public Dictionary<string, BaseVariable> VariableDict;

		private float standingScale;

		private float timeAirborne;

		private Coroutine taseCoroutine;

		private List<ConstantForce> ragdollForceComponents;

		private List<int> impactHistory;

		private List<Quaternion> seizureRotations;

		private List<int> equippableMessageIDHistory;

		private Coroutine lerpScaleRoutine;

		public SyncVar<string> syncVar____003CPlayerName_003Ek__BackingField;

		public SyncVar<string> syncVar____003CPlayerCode_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CCurrentVehicle_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CCurrentBed_003Ek__BackingField;

		public SyncVar<bool> syncVar____003CIsReadyToSleep_003Ek__BackingField;

		public SyncVar<Vector3> syncVar____003CCameraPosition_003Ek__BackingField;

		public SyncVar<Quaternion> syncVar____003CCameraRotation_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EPlayerScripts_002EPlayerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPlayerScripts_002EPlayerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsLocalPlayer => false;

		[field: SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public string PlayerName { get; protected set; }

		[field: SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public string PlayerCode { get; protected set; }

		[field: SyncVar(OnChange = "CurrentVehicleChanged")]
		public NetworkObject CurrentVehicle
		{
			get; [ServerRpc(RunLocally = true)]
			set;
		}

		public float TimeSinceVehicleExit { get; protected set; }

		public bool Crouched { get; private set; }

		[field: SyncVar]
		public NetworkObject CurrentBed
		{
			get; [ServerRpc]
			set;
		}

		[field: SyncVar]
		public bool IsReadyToSleep { get; private set; }

		public bool IsSkating
		{
			get; [ServerRpc]
			set;
		}

		public Skateboard ActiveSkateboard { get; private set; }

		public bool IsSleeping { get; protected set; }

		public bool IsRagdolled { get; protected set; }

		public bool IsArrested { get; protected set; }

		public bool IsTased { get; protected set; }

		public bool IsUnconscious { get; protected set; }

		public float Scale { get; private set; }

		public ScheduleOne.Property.Property CurrentProperty { get; protected set; }

		public ScheduleOne.Property.Property LastVisitedProperty { get; protected set; }

		public Business CurrentBusiness { get; protected set; }

		public Vector3 PlayerBasePosition => default(Vector3);

		[field: SyncVar(Channel = Channel.Unreliable, SendRate = 0.1f)]
		public Vector3 CameraPosition
		{
			get; [ServerRpc]
			set;
		}

		[field: SyncVar(Channel = Channel.Unreliable, SendRate = 0.1f)]
		public Quaternion CameraRotation
		{
			get; [ServerRpc]
			set;
		}

		public BasicAvatarSettings CurrentAvatarSettings { get; protected set; }

		public ProductItemInstance ConsumedProduct { get; private set; }

		public int TimeSinceProductConsumed { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public bool avatarVisibleToLocalPlayer { get; private set; }

		public bool playerDataRetrieveReturned { get; private set; }

		public bool playerSaveRequestReturned { get; private set; }

		public bool PlayerInitializedOverNetwork { get; private set; }

		public bool Paranoid { get; set; }

		public bool Sneaky { get; set; }

		public bool Disoriented { get; set; }

		public bool Seizure { get; set; }

		public bool Slippery { get; set; }

		public bool Schizophrenic { get; set; }

		public string SyncAccessor__003CPlayerName_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SyncAccessor__003CPlayerCode_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NetworkObject SyncAccessor__003CCurrentVehicle_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NetworkObject SyncAccessor__003CCurrentBed_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool SyncAccessor__003CIsReadyToSleep_003Ek__BackingField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector3 SyncAccessor__003CCameraPosition_003Ek__BackingField
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion SyncAccessor__003CCameraRotation_003Ek__BackingField
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		[Button]
		public void LoadDebugAvatarSettings()
		{
		}

		public static Player GetPlayer(NetworkConnection conn)
		{
			return null;
		}

		public static Player GetRandomPlayer(bool excludeArrestedOrDead = true, bool excludeSleeping = true)
		{
			return null;
		}

		public static Player GetPlayer(string playerCode)
		{
			return null;
		}

		public virtual void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public override void OnStartClient()
		{
		}

		private void PlayerLoaded()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void RequestSavePlayer()
		{
		}

		[ObserversRpc]
		[TargetRpc]
		private void ReturnSaveRequest(NetworkConnection conn, bool successful)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void HostExitedGame()
		{
		}

		private void ClientConnectionStateChanged(ClientConnectionStateArgs args)
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SendPlayerNameData(string playerName, ulong id)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void RequestPlayerData(string playerCode)
		{
		}

		[ServerRpc(RunLocally = true)]
		public void MarkPlayerInitialized()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ReceivePlayerData(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		public void SetGravityMultiplier(float multiplier)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void ReceivePlayerNameData(NetworkConnection conn, string playerName, string id)
		{
		}

		public void SendFlashlightOn(bool on)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendFlashlightOnNetworked(bool on)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetFlashlightOn(bool on)
		{
		}

		public override void OnStopClient()
		{
		}

		public override void OnStartServer()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void MinPass()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void RecalculateCurrentProperty()
		{
		}

		private void FixedUpdate()
		{
		}

		private void ApplyMovementVisuals()
		{
		}

		public void SetVisible(bool vis, bool network = false)
		{
		}

		[ObserversRpc]
		public void PlayJumpAnimation()
		{
		}

		public bool GetIsGrounded()
		{
			return false;
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendCrouched(bool crouched)
		{
		}

		public void SetCrouchedLocal(bool crouched)
		{
		}

		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void ReceiveCrouched(NetworkConnection conn, bool crouched)
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SendAvatarSettings(AvatarSettings settings)
		{
		}

		[ObserversRpc(BufferLast = true, RunLocally = true)]
		public void SetAvatarSettings(AvatarSettings settings)
		{
		}

		[ObserversRpc]
		private void SetVisible_Networked(bool vis)
		{
		}

		public void EnterVehicle(LandVehicle vehicle)
		{
		}

		public void ExitVehicle(Transform exitPoint)
		{
		}

		private void PreDestroyClientObjects(NetworkConnection conn)
		{
		}

		private void CurrentVehicleChanged(NetworkObject oldVeh, NetworkObject newVeh, bool asServer)
		{
		}

		public static bool AreAllPlayersReadyToSleep()
		{
			return false;
		}

		private void SleepStart()
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetReadyToSleep(bool ready)
		{
		}

		private void SleepEnd(int minsSlept)
		{
		}

		public static void Activate()
		{
		}

		public static void Deactivate(bool freeMouse)
		{
		}

		public void ExitAll()
		{
		}

		public void SetVisibleToLocalPlayer(bool vis)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetPlayerCode(string code)
		{
		}

		[ServerRpc]
		public void SendPunch()
		{
		}

		[ObserversRpc]
		private void Punch()
		{
		}

		[ServerRpc(RunLocally = true)]
		private void MarkIntroCompleted(BasicAvatarSettings appearance)
		{
		}

		public bool IsPointVisibleToPlayer(Vector3 point, float maxDistance_Visible = 30f, float minDistance_Invisible = 5f)
		{
			return false;
		}

		public static Player GetClosestPlayer(Vector3 point, out float distance, List<Player> exclude = null)
		{
			distance = default(float);
			return null;
		}

		public void SetCapsuleColliderHeight(float normalizedHeight)
		{
		}

		public void SetScale(float scale)
		{
		}

		public void SetScale(float scale, float lerpTime)
		{
		}

		protected virtual void ApplyScale()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public PlayerData GetPlayerData()
		{
			return null;
		}

		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public string GetInventoryString()
		{
			return null;
		}

		public string GetAppearanceString()
		{
			return null;
		}

		public string GetClothingString()
		{
			return null;
		}

		public virtual void Load(PlayerData data, string containerPath)
		{
		}

		public virtual void Load(PlayerData data)
		{
		}

		public virtual void LoadInventory(string contentsString)
		{
		}

		public virtual void LoadAppearance(string appearanceString)
		{
		}

		public virtual void LoadClothing(string contentsString)
		{
		}

		public void SetRagdolled(bool ragdolled)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void SendImpact(Impact impact)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public virtual void ReceiveImpact(Impact impact)
		{
		}

		public virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
		}

		public virtual void OnDied()
		{
		}

		public virtual void OnRevived()
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void Arrest()
		{
		}

		public void Free()
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SendPassOut()
		{
		}

		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void PassOut()
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SendPassOutRecovery()
		{
		}

		[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void PassOutRecovery()
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendEquippable_Networked(string assetPath)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetEquippable_Networked(string assetPath)
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SendEquippableMessage_Networked(string message, int receipt)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void ReceiveEquippableMessage_Networked(string message, int receipt)
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SendEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void ReceiveEquippableMessage_Networked_Vector(string message, int receipt, Vector3 data)
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SendAnimationTrigger(string trigger)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		public void SetAnimationTrigger(string trigger)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		public void ResetAnimationTrigger(string trigger)
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SendAnimationBool(string name, bool val)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetAnimationBool(string name, bool val)
		{
		}

		[ObserversRpc]
		public void Taze()
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SetInventoryItem(int index, ItemInstance item)
		{
		}

		private void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		[ServerRpc(RunLocally = true)]
		public void SendAppearance(BasicAvatarSettings settings)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetAppearance(BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		public void MountSkateboard(Skateboard board)
		{
		}

		[ServerRpc(RunLocally = true)]
		private void SendMountedSkateboard(NetworkObject skateboardObj)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetMountedSkateboard(NetworkObject skateboardObj)
		{
		}

		public void DismountSkateboard()
		{
		}

		public void ConsumeProduct(ProductItemInstance product)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendConsumeProduct(ProductItemInstance product)
		{
		}

		[ObserversRpc]
		private void ReceiveConsumeProduct(ProductItemInstance product)
		{
		}

		private void ConsumeProductInternal(ProductItemInstance product)
		{
		}

		public void ClearProduct()
		{
		}

		private void CreatePlayerVariables()
		{
		}

		public BaseVariable GetVariable(string variableName)
		{
			return null;
		}

		public T GetValue<T>(string variableName)
		{
			return default(T);
		}

		public void SetVariableValue(string variableName, string value, bool network = true)
		{
		}

		public void AddVariable(BaseVariable variable)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendValue(string variableName, string value, bool sendToOwner)
		{
		}

		[TargetRpc]
		private void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
		}

		private void ReceiveValue(string variableName, string value)
		{
		}

		public void LoadVariable(VariableData data)
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

		private void RpcWriter___Server_set_CurrentVehicle_3323014238(NetworkObject value)
		{
		}

		[SpecialName]
		public void RpcLogic___set_CurrentVehicle_3323014238(NetworkObject value)
		{
		}

		private void RpcReader___Server_set_CurrentVehicle_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_CurrentBed_3323014238(NetworkObject value)
		{
		}

		[SpecialName]
		public void RpcLogic___set_CurrentBed_3323014238(NetworkObject value)
		{
		}

		private void RpcReader___Server_set_CurrentBed_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_IsSkating_1140765316(bool value)
		{
		}

		[SpecialName]
		public void RpcLogic___set_IsSkating_1140765316(bool value)
		{
		}

		private void RpcReader___Server_set_IsSkating_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_CameraPosition_4276783012(Vector3 value)
		{
		}

		[SpecialName]
		public void RpcLogic___set_CameraPosition_4276783012(Vector3 value)
		{
		}

		private void RpcReader___Server_set_CameraPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_CameraRotation_3429297120(Quaternion value)
		{
		}

		[SpecialName]
		public void RpcLogic___set_CameraRotation_3429297120(Quaternion value)
		{
		}

		private void RpcReader___Server_set_CameraRotation_3429297120(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RequestSavePlayer_2166136261()
		{
		}

		public void RpcLogic___RequestSavePlayer_2166136261()
		{
		}

		private void RpcReader___Server_RequestSavePlayer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
		}

		private void RpcLogic___ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
		}

		private void RpcReader___Observers_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReturnSaveRequest_214505783(NetworkConnection conn, bool successful)
		{
		}

		private void RpcReader___Target_ReturnSaveRequest_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_HostExitedGame_2166136261()
		{
		}

		public void RpcLogic___HostExitedGame_2166136261()
		{
		}

		private void RpcReader___Observers_HostExitedGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendPlayerNameData_586648380(string playerName, ulong id)
		{
		}

		public void RpcLogic___SendPlayerNameData_586648380(string playerName, ulong id)
		{
		}

		private void RpcReader___Server_SendPlayerNameData_586648380(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RequestPlayerData_3615296227(string playerCode)
		{
		}

		public void RpcLogic___RequestPlayerData_3615296227(string playerCode)
		{
		}

		private void RpcReader___Server_RequestPlayerData_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_MarkPlayerInitialized_2166136261()
		{
		}

		public void RpcLogic___MarkPlayerInitialized_2166136261()
		{
		}

		private void RpcReader___Server_MarkPlayerInitialized_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		public void RpcLogic___ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		private void RpcReader___Observers_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceivePlayerData_3244732873(NetworkConnection conn, PlayerData data, string inventoryString, string appearanceString, string clothigString, VariableData[] vars)
		{
		}

		private void RpcReader___Target_ReceivePlayerData_3244732873(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
		}

		private void RpcLogic___ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
		}

		private void RpcReader___Observers_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceivePlayerNameData_3895153758(NetworkConnection conn, string playerName, string id)
		{
		}

		private void RpcReader___Target_ReceivePlayerNameData_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendFlashlightOnNetworked_1140765316(bool on)
		{
		}

		private void RpcLogic___SendFlashlightOnNetworked_1140765316(bool on)
		{
		}

		private void RpcReader___Server_SendFlashlightOnNetworked_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetFlashlightOn_1140765316(bool on)
		{
		}

		private void RpcLogic___SetFlashlightOn_1140765316(bool on)
		{
		}

		private void RpcReader___Observers_SetFlashlightOn_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_PlayJumpAnimation_2166136261()
		{
		}

		public void RpcLogic___PlayJumpAnimation_2166136261()
		{
		}

		private void RpcReader___Observers_PlayJumpAnimation_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendCrouched_1140765316(bool crouched)
		{
		}

		public void RpcLogic___SendCrouched_1140765316(bool crouched)
		{
		}

		private void RpcReader___Server_SendCrouched_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
		}

		private void RpcLogic___ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
		}

		private void RpcReader___Target_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ReceiveCrouched_214505783(NetworkConnection conn, bool crouched)
		{
		}

		private void RpcReader___Observers_ReceiveCrouched_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		public void RpcLogic___SendAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		private void RpcReader___Server_SendAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		public void RpcLogic___SetAvatarSettings_4281687581(AvatarSettings settings)
		{
		}

		private void RpcReader___Observers_SetAvatarSettings_4281687581(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetVisible_Networked_1140765316(bool vis)
		{
		}

		private void RpcLogic___SetVisible_Networked_1140765316(bool vis)
		{
		}

		private void RpcReader___Observers_SetVisible_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetReadyToSleep_1140765316(bool ready)
		{
		}

		public void RpcLogic___SetReadyToSleep_1140765316(bool ready)
		{
		}

		private void RpcReader___Server_SetReadyToSleep_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetPlayerCode_3615296227(string code)
		{
		}

		public void RpcLogic___SetPlayerCode_3615296227(string code)
		{
		}

		private void RpcReader___Observers_SetPlayerCode_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendPunch_2166136261()
		{
		}

		public void RpcLogic___SendPunch_2166136261()
		{
		}

		private void RpcReader___Server_SendPunch_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Punch_2166136261()
		{
		}

		private void RpcLogic___Punch_2166136261()
		{
		}

		private void RpcReader___Observers_Punch_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
		}

		private void RpcLogic___MarkIntroCompleted_3281254764(BasicAvatarSettings appearance)
		{
		}

		private void RpcReader___Server_MarkIntroCompleted_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendImpact_427288424(Impact impact)
		{
		}

		public virtual void RpcLogic___SendImpact_427288424(Impact impact)
		{
		}

		private void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
		{
		}

		public virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
		{
		}

		private void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_Arrest_2166136261()
		{
		}

		public void RpcLogic___Arrest_2166136261()
		{
		}

		private void RpcReader___Observers_Arrest_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendPassOut_2166136261()
		{
		}

		public void RpcLogic___SendPassOut_2166136261()
		{
		}

		private void RpcReader___Server_SendPassOut_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PassOut_2166136261()
		{
		}

		public void RpcLogic___PassOut_2166136261()
		{
		}

		private void RpcReader___Observers_PassOut_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendPassOutRecovery_2166136261()
		{
		}

		public void RpcLogic___SendPassOutRecovery_2166136261()
		{
		}

		private void RpcReader___Server_SendPassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PassOutRecovery_2166136261()
		{
		}

		public void RpcLogic___PassOutRecovery_2166136261()
		{
		}

		private void RpcReader___Observers_PassOutRecovery_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendEquippable_Networked_3615296227(string assetPath)
		{
		}

		public void RpcLogic___SendEquippable_Networked_3615296227(string assetPath)
		{
		}

		private void RpcReader___Server_SendEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetEquippable_Networked_3615296227(string assetPath)
		{
		}

		private void RpcLogic___SetEquippable_Networked_3615296227(string assetPath)
		{
		}

		private void RpcReader___Observers_SetEquippable_Networked_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		public void RpcLogic___SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		private void RpcReader___Server_SendEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		private void RpcLogic___ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		private void RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		public void RpcLogic___SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		private void RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		private void RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, Vector3 data)
		{
		}

		private void RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
		}

		public void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
		}

		private void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		public void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		public void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendAnimationBool_310431262(string name, bool val)
		{
		}

		public void RpcLogic___SendAnimationBool_310431262(string name, bool val)
		{
		}

		private void RpcReader___Server_SendAnimationBool_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAnimationBool_310431262(string name, bool val)
		{
		}

		public void RpcLogic___SetAnimationBool_310431262(string name, bool val)
		{
		}

		private void RpcReader___Observers_SetAnimationBool_310431262(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_Taze_2166136261()
		{
		}

		public void RpcLogic___Taze_2166136261()
		{
		}

		private void RpcReader___Observers_Taze_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetInventoryItem_2317364410(int index, ItemInstance item)
		{
		}

		public void RpcLogic___SetInventoryItem_2317364410(int index, ItemInstance item)
		{
		}

		private void RpcReader___Server_SetInventoryItem_2317364410(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendAppearance_3281254764(BasicAvatarSettings settings)
		{
		}

		public void RpcLogic___SendAppearance_3281254764(BasicAvatarSettings settings)
		{
		}

		private void RpcReader___Server_SendAppearance_3281254764(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		public void RpcLogic___SetAppearance_2139595489(BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		private void RpcReader___Observers_SetAppearance_2139595489(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		private void RpcLogic___SendMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		private void RpcReader___Server_SendMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		private void RpcLogic___SetMountedSkateboard_3323014238(NetworkObject skateboardObj)
		{
		}

		private void RpcReader___Observers_SetMountedSkateboard_3323014238(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		private void RpcLogic___SendConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		private void RpcReader___Server_SendConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		private void RpcLogic___ReceiveConsumeProduct_2622925554(ProductItemInstance product)
		{
		}

		private void RpcReader___Observers_ReceiveConsumeProduct_2622925554(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
		}

		public void RpcLogic___SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
		}

		private void RpcReader___Server_SendValue_3589193952(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EPlayerScripts_002EPlayer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EPlayerScripts_002EPlayer_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
