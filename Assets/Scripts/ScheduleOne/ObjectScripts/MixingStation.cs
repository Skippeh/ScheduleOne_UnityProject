using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Misc;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.ObjectScripts
{
	public class MixingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		public ItemSlot ProductSlot;

		public ItemSlot MixerSlot;

		public ItemSlot OutputSlot;

		public bool RequiresIngredientInsertion;

		[Header("Settings")]
		public int MixTimePerItem;

		public int MaxMixQuantity;

		[Header("Prefabs")]
		public GameObject JugPrefab;

		[Header("References")]
		public InteractableObject IntObj;

		public Transform CameraPosition;

		public Transform CameraPosition_CombineIngredients;

		public Transform CameraPosition_StartMachine;

		public StorageVisualizer InputVisuals;

		public StorageVisualizer OutputVisuals;

		public DigitalAlarm Clock;

		public ToggleableLight Light;

		public NewMixDiscoveryBox DiscoveryBox;

		public Transform ItemContainer;

		public Transform[] IngredientTransforms;

		public Fillable BowlFillable;

		public Clickable StartButton;

		public Transform JugAlignment;

		public Rigidbody Anchor;

		public BoxCollider TrashSpawnVolume;

		public Transform uiPoint;

		public Transform[] accessPoints;

		public ConfigurationReplicator configReplicator;

		[Header("Sounds")]
		public StartLoopStopAudio MachineSound;

		public AudioSourceController StartSound;

		public AudioSourceController StopSound;

		[Header("Mix Timing")]
		[Header("UI")]
		public MixingStationUIElement WorldspaceUIPrefab;

		public Sprite typeIcon;

		public UnityEvent onMixStart;

		public UnityEvent onMixDone;

		public UnityEvent onOutputCollected;

		public UnityEvent onStartButtonClicked;

		public SyncVar<NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EMixingStationAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EMixingStationAssembly_002DCSharp_002Edll_Excuted;

		public bool IsOpen { get; private set; }

		public MixOperation CurrentMixOperation { get; set; }

		public bool IsMixingDone => false;

		public int CurrentMixTime { get; protected set; }

		public List<ItemSlot> ItemSlots { get; set; }

		[field: HideInInspector]
		[field: SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public NetworkObject NPCUserObject { get; set; }

		[field: HideInInspector]
		[field: SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
		public NetworkObject PlayerUserObject { get; set; }

		public string Name => null;

		public List<ItemSlot> InputSlots { get; set; }

		public List<ItemSlot> OutputSlots { get; set; }

		public Transform LinkOrigin => null;

		public Transform[] AccessPoints => null;

		public bool Selectable { get; }

		public bool IsAcceptingItems { get; set; }

		public EntityConfiguration Configuration => null;

		protected MixingStationConfiguration stationConfiguration { get; set; }

		public ConfigurationReplicator ConfigReplicator => null;

		public EConfigurableType ConfigurableType => default(EConfigurableType);

		public WorldspaceUIElement WorldspaceUI { get; set; }

		[field: SyncVar]
		public NetworkObject CurrentPlayerConfigurer { get; set; }

		public Sprite TypeIcon => null;

		public Transform Transform => null;

		public Transform UIPoint => null;

		public bool CanBeSelected => false;

		public Vector3 DiscoveryBoxOffset { get; private set; }

		public Quaternion DiscoveryBoxRotation { get; private set; }

		public NetworkObject SyncAccessor__003CNPCUserObject_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NetworkObject SyncAccessor__003CPlayerUserObject_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NetworkObject SyncAccessor__003CCurrentPlayerConfigurer_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public override void DestroyItem(bool callOnServer = true)
		{
		}

		private void TimeSkipped(int minsPassed)
		{
		}

		protected virtual void MinPass()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixingOperation(MixOperation operation, int mixTime)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void SetMixOperation(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
		}

		public virtual void MixingStart()
		{
		}

		[ObserversRpc]
		public void MixingDone_Networked()
		{
		}

		public virtual void MixingDone()
		{
		}

		public bool DoesOutputHaveSpace(StationRecipe recipe)
		{
			return false;
		}

		public List<ItemInstance> GetIngredients()
		{
			return null;
		}

		public int GetMixQuantity()
		{
			return 0;
		}

		public bool CanStartMix()
		{
			return false;
		}

		public ProductDefinition GetProduct()
		{
			return null;
		}

		public PropertyItemDefinition GetMixer()
		{
			return null;
		}

		public int GetMixTimeForCurrentOperation()
		{
			return 0;
		}

		[ServerRpc(RequireOwnership = false)]
		public void TryCreateOutputItems()
		{
		}

		public void SetStartButtonClickable(bool clickable)
		{
		}

		private void OutputChanged()
		{
		}

		private void StartButtonClicked(RaycastHit hit)
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		public void DestroyWorldspaceUI()
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
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

		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendMixingOperation_2669582547(MixOperation operation, int mixTime)
		{
		}

		public void RpcLogic___SendMixingOperation_2669582547(MixOperation operation, int mixTime)
		{
		}

		private void RpcReader___Server_SendMixingOperation_2669582547(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
		}

		public virtual void RpcLogic___SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
		}

		private void RpcReader___Observers_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetMixOperation_1073078804(NetworkConnection conn, MixOperation operation, int mixTIme)
		{
		}

		private void RpcReader___Target_SetMixOperation_1073078804(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_MixingDone_Networked_2166136261()
		{
		}

		public void RpcLogic___MixingDone_Networked_2166136261()
		{
		}

		private void RpcReader___Observers_MixingDone_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_TryCreateOutputItems_2166136261()
		{
		}

		public void RpcLogic___TryCreateOutputItems_2166136261()
		{
		}

		private void RpcReader___Server_TryCreateOutputItems_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002EMixingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EMixingStation_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
