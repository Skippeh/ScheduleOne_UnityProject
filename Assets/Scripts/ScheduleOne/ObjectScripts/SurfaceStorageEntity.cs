namespace ScheduleOne.ObjectScripts
{
	public class SurfaceStorageEntity : global::ScheduleOne.EntityFramework.SurfaceItem, global::ScheduleOne.Storage.IStorageEntity, global::ScheduleOne.Management.IUsable
	{
		[global::UnityEngine.Header("Reference")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform _storedItemContainer;

		public global::ScheduleOne.Storage.StorageEntity StorageEntity;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Storage.StorageGrid> storageGrids;

		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.Storage.StoredItem, global::ScheduleOne.Employees.Employee> _reservedItems;

		private global::System.Collections.Generic.List<string> completedJobs;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CNPCUserObject_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CPlayerUserObject_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ESurfaceStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ESurfaceStorageEntityAssembly_002DCSharp_002Edll_Excuted;

		public global::UnityEngine.Transform storedItemContainer => null;

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Storage.StoredItem, global::ScheduleOne.Employees.Employee> reservedItems
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::FishNet.Object.NetworkObject NPCUserObject
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

		public global::FishNet.Object.NetworkObject PlayerUserObject
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

		public bool Selectable { get; }

		public bool IsAcceptingItems { get; set; }

		public global::FishNet.Object.NetworkObject SyncAccessor__003CNPCUserObject_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::FishNet.Object.NetworkObject SyncAccessor__003CPlayerUserObject_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.StoredItem> GetStoredItems()
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.StorageGrid> GetStorageGrids()
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void DestroyStoredItem(int gridIndex, global::ScheduleOne.Tiles.Coordinate coord, string jobID = "", bool network = true)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void DestroyStoredItem_Server(int gridIndex, global::ScheduleOne.Tiles.Coordinate coord, string jobID)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
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

		private void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, global::ScheduleOne.Tiles.Coordinate coord, string jobID = "", bool network = true)
		{
		}

		public void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, global::ScheduleOne.Tiles.Coordinate coord, string jobID = "", bool network = true)
		{
		}

		private void RpcReader___Observers_DestroyStoredItem_3261517793(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, global::ScheduleOne.Tiles.Coordinate coord, string jobID)
		{
		}

		private void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, global::ScheduleOne.Tiles.Coordinate coord, string jobID)
		{
		}

		private void RpcReader___Server_DestroyStoredItem_Server_3952619116(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetPlayerUser_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		public void RpcLogic___SetPlayerUser_3323014238(global::FishNet.Object.NetworkObject playerObject)
		{
		}

		private void RpcReader___Server_SetPlayerUser_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetNPCUser_3323014238(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		public void RpcLogic___SetNPCUser_3323014238(global::FishNet.Object.NetworkObject npcObject)
		{
		}

		private void RpcReader___Server_SetNPCUser_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002ESurfaceStorageEntity(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
