namespace ScheduleOne.Employees
{
	public class Cleaner : global::ScheduleOne.Employees.Employee, global::ScheduleOne.Management.IConfigurable
	{
		public const int MAX_ASSIGNED_BINS = 3;

		public global::ScheduleOne.ObjectScripts.WateringCan.TrashGrabberDefinition TrashGrabberDef;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.NPCs.Behaviour.PickUpTrashBehaviour PickUpTrashBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviour EmptyTrashGrabberBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.BagTrashCanBehaviour BagTrashCanBehaviour;

		public global::ScheduleOne.NPCs.Behaviour.DisposeTrashBagBehaviour DisposeTrashBagBehaviour;

		public global::UnityEngine.Sprite typeIcon;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Management.ConfigurationReplicator configReplicator;

		[global::UnityEngine.Header("UI")]
		public global::ScheduleOne.UI.Management.CleanerUIElement WorldspaceUIPrefab;

		public global::UnityEngine.Transform uiPoint;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EEmployees_002ECleanerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEmployees_002ECleanerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ObjectScripts.WateringCan.TrashGrabberInstance trashGrabberInstance { get; private set; }

		public global::ScheduleOne.Management.EntityConfiguration Configuration => null;

		protected global::ScheduleOne.Management.CleanerConfiguration configuration { get; set; }

		public global::ScheduleOne.Management.ConfigurationReplicator ConfigReplicator => null;

		public global::ScheduleOne.Management.EConfigurableType ConfigurableType => default(global::ScheduleOne.Management.EConfigurableType);

		public global::ScheduleOne.UI.Management.WorldspaceUIElement WorldspaceUI { get; set; }

		public global::FishNet.Object.NetworkObject CurrentPlayerConfigurer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		public global::UnityEngine.Sprite TypeIcon => null;

		public global::UnityEngine.Transform Transform => null;

		public global::UnityEngine.Transform UIPoint => null;

		public bool CanBeSelected => false;

		public global::ScheduleOne.Property.Property ParentProperty => null;

		public global::FishNet.Object.NetworkObject SyncAccessor__003CCurrentPlayerConfigurer_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(global::FishNet.Object.NetworkObject player)
		{
		}

		protected override void AssignProperty(global::ScheduleOne.Property.Property prop, bool warp)
		{
		}

		protected override void UnassignProperty()
		{
		}

		protected override void ResetConfiguration()
		{
		}

		protected override void Fire()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected override void UpdateBehaviour()
		{
		}

		private void TryStartNewTask()
		{
		}

		private global::ScheduleOne.ObjectScripts.TrashContainerItem GetFirstNonFullBin(global::ScheduleOne.ObjectScripts.TrashContainerItem[] bins)
		{
			return null;
		}

		public override void SetIdle(bool idle)
		{
		}

		private global::ScheduleOne.ObjectScripts.TrashContainerItem[] GetTrashContainersOrderedByDistance()
		{
			return null;
		}

		public override global::ScheduleOne.Employees.EmployeeHome GetHome()
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

		public global::ScheduleOne.UI.Management.WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		public void DestroyWorldspaceUI()
		{
		}

		public override global::ScheduleOne.Persistence.Datas.NPCData GetNPCData()
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.DynamicSaveData GetSaveData()
		{
			return null;
		}

		public override global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
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

		private void RpcWriter___Server_SetConfigurer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		public void RpcLogic___SetConfigurer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Server_SetConfigurer_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EEmployees_002ECleaner(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
