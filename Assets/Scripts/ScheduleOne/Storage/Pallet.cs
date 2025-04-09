using System;
using System.Collections.Generic;
using FishNet.Component.Transforming;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Employees;
using ScheduleOne.Tiles;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	public class Pallet : NetworkBehaviour, IStorageEntity
	{
		public static List<Pallet> palletsOwnedByLocalPlayer;

		public static int sizeX;

		public static int sizeY;

		[Header("Reference")]
		public Transform _storedItemContainer;

		public Rigidbody rb;

		public StorageGrid storageGrid;

		public NetworkTransform networkTransform;

		protected List<Forklift> forkliftsInContact;

		public Guid currentSlotGUID;

		private PalletSlot currentSlot;

		private float timeSinceSlotCheck;

		private float timeBoundToSlot;

		private float rb_Mass;

		private float rb_Drag;

		private float rb_AngularDrag;

		protected Dictionary<StoredItem, Employee> _reservedItems;

		private List<string> completedJobs;

		private bool NetworkInitialize___EarlyScheduleOne_002EStorage_002EPalletAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EStorage_002EPalletAssembly_002DCSharp_002Edll_Excuted;

		public bool isEmpty => false;

		protected bool carriedByForklift => false;

		public Transform storedItemContainer => null;

		public Dictionary<StoredItem, Employee> reservedItems => null;

		public virtual void Awake()
		{
		}

		public override void OnStartServer()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		protected virtual void SetOwner(NetworkConnection conn)
		{
		}

		public override void OnOwnershipClient(NetworkConnection prevOwner)
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		private void SendItemsToClient(NetworkConnection connection)
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

		private void SetPosition(Vector3 position)
		{
		}

		private void UpdateOwnership()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void BindToSlot_Server(Guid slotGuid)
		{
		}

		[ObserversRpc]
		[TargetRpc]
		private void BindToSlot(NetworkConnection conn, Guid slotGuid)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void ExitSlot_Server()
		{
		}

		[ObserversRpc]
		private void ExitSlot()
		{
		}

		public void TriggerStay(Collider other)
		{
		}

		public List<StoredItem> GetStoredItems()
		{
			return null;
		}

		public List<StorageGrid> GetStorageGrids()
		{
			return null;
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void CreateStoredItem(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void CreateStoredItem_Server(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
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

		private void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
		}

		protected virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_BindToSlot_Server_1272046255(Guid slotGuid)
		{
		}

		public void RpcLogic___BindToSlot_Server_1272046255(Guid slotGuid)
		{
		}

		private void RpcReader___Server_BindToSlot_Server_1272046255(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
		}

		private void RpcLogic___BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
		}

		private void RpcReader___Observers_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_BindToSlot_454078614(NetworkConnection conn, Guid slotGuid)
		{
		}

		private void RpcReader___Target_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_ExitSlot_Server_2166136261()
		{
		}

		public void RpcLogic___ExitSlot_Server_2166136261()
		{
		}

		private void RpcReader___Server_ExitSlot_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ExitSlot_2166136261()
		{
		}

		private void RpcLogic___ExitSlot_2166136261()
		{
		}

		private void RpcReader___Observers_ExitSlot_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		public void RpcLogic___CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		private void RpcReader___Observers_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
		}

		private void RpcReader___Target_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
		}

		private void RpcLogic___CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
		}

		private void RpcReader___Server_CreateStoredItem_Server_1890711751(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		public void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
		}

		private void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
		}

		private void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
		}

		private void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EStorage_002EPallet_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
