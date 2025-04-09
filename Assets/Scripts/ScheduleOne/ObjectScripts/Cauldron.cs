using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Misc;
using ScheduleOne.PlayerTasks;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.UI.Management;
using UnityEngine;
using UnityEngine.Events;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.ObjectScripts
{
	public class Cauldron : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		public enum EState
		{
			MissingIngredients = 0,
			Ready = 1,
			Cooking = 2,
			OutputFull = 3
		}

		public const int INGREDIENT_SLOT_COUNT = 4;

		public const int COCA_LEAF_REQUIRED = 20;

		public ItemSlot[] IngredientSlots;

		public ItemSlot LiquidSlot;

		public ItemSlot OutputSlot;

		public int CookTime;

		[Header("References")]
		public Transform CameraPosition;

		public Transform CameraPosition_CombineIngredients;

		public Transform CameraPosition_StartMachine;

		public InteractableObject IntObj;

		public Transform[] accessPoints;

		public Transform StandPoint;

		public Transform uiPoint;

		public StorageVisualizer LiquidVisuals;

		public StorageVisualizer OutputVisuals;

		public CauldronDisplayTub PrimaryTub;

		public CauldronDisplayTub SecondaryTub;

		public Transform ItemContainer;

		public Transform GasolineSpawnPoint;

		public Transform TubSpawnPoint;

		public Transform[] LeafSpawns;

		public Light OverheadLight;

		public Fillable CauldronFillable;

		public Clickable StartButtonClickable;

		public DigitalAlarm Alarm;

		public ToggleableLight Light;

		public ConfigurationReplicator configReplicator;

		public BoxCollider TrashSpawnVolume;

		[Header("Prefabs")]
		public StationItem CocaLeafPrefab;

		public StationItem GasolinePrefab;

		public Draggable TubPrefab;

		public QualityItemDefinition CocaineBaseDefinition;

		[Header("UI")]
		public CauldronUIElement WorldspaceUIPrefab;

		public Sprite typeIcon;

		public UnityEvent onStartButtonClicked;

		public UnityEvent onCookStart;

		public UnityEvent onCookEnd;

		public int RemainingCookTime;

		public EQuality InputQuality;

		public SyncVar<NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ECauldronAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ECauldronAssembly_002DCSharp_002Edll_Excuted;

		public bool isOpen => false;

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

		protected CauldronConfiguration cauldronConfiguration { get; set; }

		public ConfigurationReplicator ConfigReplicator => null;

		public EConfigurableType ConfigurableType => default(EConfigurableType);

		public WorldspaceUIElement WorldspaceUI { get; set; }

		[field: SyncVar]
		public NetworkObject CurrentPlayerConfigurer { get; set; }

		public Sprite TypeIcon => null;

		public Transform Transform => null;

		public Transform UIPoint => null;

		public bool CanBeSelected => false;

		private bool isCooking => false;

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

		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		protected override void Start()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		public override void DestroyItem(bool callOnServer = true)
		{
		}

		private void MinPass()
		{
		}

		private void TimeSkipped(int minsPassed)
		{
		}

		private void Exit(ExitAction action)
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		private void UpdateIngredientVisuals()
		{
		}

		public void GetMainInputs(out ItemInstance primaryItem, out int primaryItemQuantity, out ItemInstance secondaryItem, out int secondaryItemQuantity)
		{
			primaryItem = null;
			primaryItemQuantity = default(int);
			secondaryItem = null;
			secondaryItemQuantity = default(int);
		}

		public EState GetState()
		{
			return default(EState);
		}

		public bool HasOutputSpace()
		{
			return false;
		}

		public EQuality RemoveIngredients()
		{
			return default(EQuality);
		}

		public bool HasIngredients()
		{
			return false;
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendCookOperation(int remainingCookTime, EQuality quality)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void StartCookOperation(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		[ObserversRpc]
		public void FinishCookOperation()
		{
		}

		private void ButtonClicked(RaycastHit hit)
		{
		}

		public void CreateTrash(List<StationItem> mixerItems)
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

		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		public void DestroyWorldspaceUI()
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

		private void RpcWriter___Server_SendCookOperation_3536682170(int remainingCookTime, EQuality quality)
		{
		}

		public void RpcLogic___SendCookOperation_3536682170(int remainingCookTime, EQuality quality)
		{
		}

		private void RpcReader___Server_SendCookOperation_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		public void RpcLogic___StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		private void RpcReader___Observers_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_StartCookOperation_4210838825(NetworkConnection conn, int remainingCookTime, EQuality quality)
		{
		}

		private void RpcReader___Target_StartCookOperation_4210838825(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_FinishCookOperation_2166136261()
		{
		}

		public void RpcLogic___FinishCookOperation_2166136261()
		{
		}

		private void RpcReader___Observers_FinishCookOperation_2166136261(PooledReader PooledReader0, Channel channel)
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

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002ECauldron(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002ECauldron_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
