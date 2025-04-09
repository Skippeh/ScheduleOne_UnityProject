using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Decoration;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.UI.Management;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.ObjectScripts
{
	public class PackagingStation : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		public enum EMode
		{
			Package = 0,
			Unpackage = 1
		}

		public enum EState
		{
			CanBegin = 0,
			MissingItems = 1,
			InsufficentProduct = 2,
			OutputSlotFull = 3,
			Mismatch = 4,
			PackageSlotFull = 5,
			ProductSlotFull = 6
		}

		[Header("References")]
		public Light OverheadLight;

		public MeshRenderer OverheadLightMeshRend;

		public RockerSwitch Switch;

		public Transform CameraPosition;

		public Transform CameraPosition_Task;

		public InteractableObject IntObj;

		public Transform ActivePackagingAlignent;

		public Transform[] ActiveProductAlignments;

		public Transform Container;

		public Collider OutputCollider;

		public Transform Hatch;

		public Transform[] PackagingAlignments;

		public Transform[] ProductAlignments;

		public Transform uiPoint;

		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		public Transform StandPoint;

		public Transform[] accessPoints;

		public AudioSourceController HatchOpenSound;

		public AudioSourceController HatchCloseSound;

		[Header("UI")]
		public PackagingStationUIElement WorldspaceUIPrefab;

		public Sprite typeIcon;

		[Header("Slot Display Points")]
		public Transform PackagingSlotPosition;

		public Transform ProductSlotPosition;

		public Transform OutputSlotPosition;

		[Header("Materials")]
		public Material LightMeshOnMat;

		public Material LightMeshOffMat;

		[Header("Settings")]
		public float PackagerEmployeeSpeedMultiplier;

		public Vector3 HatchClosedRotation;

		public Vector3 HatchOpenRotation;

		public float HatchLerpTime;

		public ItemSlot PackagingSlot;

		public ItemSlot ProductSlot;

		public ItemSlot OutputSlot;

		private bool hatchOpen;

		private Coroutine hatchRoutine;

		private List<string> PackagingSlotModelID;

		private List<string> ProductSlotModelID;

		private bool visualsLocked;

		public SyncVar<NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		public SyncVar<NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EPackagingStationAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EPackagingStationAssembly_002DCSharp_002Edll_Excuted;

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

		protected PackagingStationConfiguration stationConfiguration { get; set; }

		public ConfigurationReplicator ConfigReplicator => null;

		public EConfigurableType ConfigurableType => default(EConfigurableType);

		public WorldspaceUIElement WorldspaceUI { get; set; }

		[field: SyncVar]
		public NetworkObject CurrentPlayerConfigurer { get; set; }

		public Sprite TypeIcon => null;

		public Transform Transform => null;

		public Transform UIPoint => null;

		public bool CanBeSelected => false;

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

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		private void Exit(ExitAction action)
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

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
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

		public EState GetState(EMode mode)
		{
			return default(EState);
		}

		public void Unpack()
		{
		}

		public void PackSingleInstance()
		{
		}

		public void SetHatchOpen(bool open)
		{
		}

		public void UpdatePackagingVisuals()
		{
		}

		public void SetVisualsLocked(bool locked)
		{
		}

		public void UpdatePackagingVisuals(int quantity)
		{
		}

		public void UpdateProductVisuals()
		{
		}

		public void UpdateProductVisuals(int quantity)
		{
		}

		public virtual void StartTask()
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

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002EPackagingStation(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EPackagingStation_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
