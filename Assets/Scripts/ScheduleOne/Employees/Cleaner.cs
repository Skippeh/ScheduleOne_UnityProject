using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Management;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Employees
{
	public class Cleaner : Employee, IConfigurable
	{
		public const int MAX_ASSIGNED_BINS = 3;

		public TrashGrabberDefinition TrashGrabberDef;

		[Header("References")]
		public PickUpTrashBehaviour PickUpTrashBehaviour;

		public EmptyTrashGrabberBehaviour EmptyTrashGrabberBehaviour;

		public BagTrashCanBehaviour BagTrashCanBehaviour;

		public DisposeTrashBagBehaviour DisposeTrashBagBehaviour;

		public Sprite typeIcon;

		[SerializeField]
		protected ConfigurationReplicator configReplicator;

		[Header("UI")]
		public CleanerUIElement WorldspaceUIPrefab;

		public Transform uiPoint;

		public SyncVar<NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002ECleanerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002ECleanerAssembly_002DCSharp_002Edll_Excuted;

		public TrashGrabberInstance trashGrabberInstance { get; private set; }

		public EntityConfiguration Configuration => null;

		protected CleanerConfiguration configuration { get; set; }

		public ConfigurationReplicator ConfigReplicator => null;

		public EConfigurableType ConfigurableType => default(EConfigurableType);

		public WorldspaceUIElement WorldspaceUI { get; set; }

		[field: SyncVar]
		public NetworkObject CurrentPlayerConfigurer { get; set; }

		public Sprite TypeIcon => null;

		public Transform Transform => null;

		public Transform UIPoint => null;

		public bool CanBeSelected => false;

		public ScheduleOne.Property.Property ParentProperty => null;

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

		protected override void AssignProperty(ScheduleOne.Property.Property prop)
		{
		}

		protected override void Fire()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		protected override void MinPass()
		{
		}

		private void TryStartNewTask()
		{
		}

		private TrashContainerItem GetFirstNonFullBin(TrashContainerItem[] bins)
		{
			return null;
		}

		public override void SetIdle(bool idle)
		{
		}

		private TrashContainerItem[] GetTrashContainersOrderedByDistance()
		{
			return null;
		}

		public override BedItem GetBed()
		{
			return null;
		}

		private void EnsureTrashGrabberInInventory()
		{
		}

		private bool AnyWorkInProgress()
		{
			return false;
		}

		private int GetTrashGrabberAmount()
		{
			return 0;
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

		public virtual bool ReadSyncVar___ScheduleOne_002EEmployees_002ECleaner(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
