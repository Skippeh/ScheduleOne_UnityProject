namespace ScheduleOne.Storage
{
	public class Pallet : global::FishNet.Object.NetworkBehaviour
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.Storage.Pallet> palletsOwnedByLocalPlayer;

		public static int sizeX;

		public static int sizeY;

		[global::UnityEngine.Header("Reference")]
		public global::UnityEngine.Transform _storedItemContainer;

		public global::UnityEngine.Rigidbody rb;

		public global::ScheduleOne.Storage.StorageGrid storageGrid;

		public global::FishNet.Component.Transforming.NetworkTransform networkTransform;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.Forklift> forkliftsInContact;

		public global::System.Guid currentSlotGUID;

		private global::ScheduleOne.Storage.PalletSlot currentSlot;

		private float timeSinceSlotCheck;

		private float timeBoundToSlot;

		private float rb_Mass;

		private float rb_Drag;

		private float rb_AngularDrag;

		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.Storage.StoredItem, global::ScheduleOne.Employees.Employee> _reservedItems;

		private global::System.Collections.Generic.List<string> completedJobs;

		private bool NetworkInitialize___EarlyScheduleOne_002EStorage_002EPalletAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EStorage_002EPalletAssembly_002DCSharp_002Edll_Excuted;

		public bool isEmpty => false;

		protected bool carriedByForklift => false;

		public global::UnityEngine.Transform storedItemContainer => null;

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Storage.StoredItem, global::ScheduleOne.Employees.Employee> reservedItems => null;

		public virtual void Awake()
		{
		}

		public override void OnStartServer()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		protected virtual void SetOwner(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public override void OnOwnershipClient(global::FishNet.Connection.NetworkConnection prevOwner)
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void SendItemsToClient(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public virtual void DestroyPallet()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		private void SetPosition(global::UnityEngine.Vector3 position)
		{
		}

		private void UpdateOwnership()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void BindToSlot_Server(global::System.Guid slotGuid)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void BindToSlot(global::FishNet.Connection.NetworkConnection conn, global::System.Guid slotGuid)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ExitSlot_Server()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ExitSlot()
		{
		}

		public void TriggerStay(global::UnityEngine.Collider other)
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
		[global::FishNet.Object.TargetRpc]
		public void CreateStoredItem(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Storage.StorableItemInstance item, int gridIndex, global::UnityEngine.Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void CreateStoredItem_Server(global::ScheduleOne.Storage.StorableItemInstance data, int gridIndex, global::UnityEngine.Vector2 originCoord, float rotation, string jobID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void DestroyStoredItem(int gridIndex, global::ScheduleOne.Tiles.Coordinate coord, string jobID = "", bool network = true)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void DestroyStoredItem_Server(int gridIndex, global::ScheduleOne.Tiles.Coordinate coord, string jobID)
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

		private void RpcWriter___Server_SetOwner_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void RpcLogic___SetOwner_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Server_SetOwner_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_BindToSlot_Server_1272046255(global::System.Guid slotGuid)
		{
		}

		public void RpcLogic___BindToSlot_Server_1272046255(global::System.Guid slotGuid)
		{
		}

		private void RpcReader___Server_BindToSlot_Server_1272046255(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_BindToSlot_454078614(global::FishNet.Connection.NetworkConnection conn, global::System.Guid slotGuid)
		{
		}

		private void RpcLogic___BindToSlot_454078614(global::FishNet.Connection.NetworkConnection conn, global::System.Guid slotGuid)
		{
		}

		private void RpcReader___Observers_BindToSlot_454078614(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_BindToSlot_454078614(global::FishNet.Connection.NetworkConnection conn, global::System.Guid slotGuid)
		{
		}

		private void RpcReader___Target_BindToSlot_454078614(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ExitSlot_Server_2166136261()
		{
		}

		public void RpcLogic___ExitSlot_Server_2166136261()
		{
		}

		private void RpcReader___Server_ExitSlot_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ExitSlot_2166136261()
		{
		}

		private void RpcLogic___ExitSlot_2166136261()
		{
		}

		private void RpcReader___Observers_ExitSlot_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateStoredItem_913707843(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Storage.StorableItemInstance item, int gridIndex, global::UnityEngine.Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		public void RpcLogic___CreateStoredItem_913707843(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Storage.StorableItemInstance item, int gridIndex, global::UnityEngine.Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		private void RpcReader___Observers_CreateStoredItem_913707843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_CreateStoredItem_913707843(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Storage.StorableItemInstance item, int gridIndex, global::UnityEngine.Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		private void RpcReader___Target_CreateStoredItem_913707843(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_CreateStoredItem_Server_1890711751(global::ScheduleOne.Storage.StorableItemInstance data, int gridIndex, global::UnityEngine.Vector2 originCoord, float rotation, string jobID)
		{
		}

		private void RpcLogic___CreateStoredItem_Server_1890711751(global::ScheduleOne.Storage.StorableItemInstance data, int gridIndex, global::UnityEngine.Vector2 originCoord, float rotation, string jobID)
		{
		}

		private void RpcReader___Server_CreateStoredItem_Server_1890711751(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
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

		protected virtual void Awake_UserLogic_ScheduleOne_002EStorage_002EPallet_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
