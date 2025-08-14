namespace ScheduleOne.Trash
{
	public class TrashManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Trash.TrashManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		[global::System.Serializable]
		public class TrashItemData
		{
			public global::ScheduleOne.Trash.TrashItem Item;

			[global::UnityEngine.Range(0f, 1f)]
			public float GenerationChance;
		}

		public const int TRASH_ITEM_LIMIT = 2000;

		public global::ScheduleOne.Trash.TrashItem[] TrashPrefabs;

		public global::ScheduleOne.Trash.TrashItem TrashBagPrefab;

		public global::ScheduleOne.Trash.TrashManager.TrashItemData[] GenerateableTrashItems;

		private global::System.Collections.Generic.List<global::ScheduleOne.Trash.TrashItem> trashItems;

		public float TrashForceMultiplier;

		private global::ScheduleOne.Persistence.Loaders.TrashLoader loader;

		private global::System.Collections.Generic.List<string> writtenItemFiles;

		private bool NetworkInitialize___EarlyScheduleOne_002ETrash_002ETrashManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ETrash_002ETrashManagerAssembly_002DCSharp_002Edll_Excuted;

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		protected override void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void ReplicateTransformData(global::ScheduleOne.Trash.TrashItem trash)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendTransformData(string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity, global::FishNet.Connection.NetworkConnection sender)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveTransformData(string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity, global::FishNet.Connection.NetworkConnection sender)
		{
		}

		public global::ScheduleOne.Trash.TrashItem CreateTrashItem(string id, global::UnityEngine.Vector3 posiiton, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 initialVelocity = default(global::UnityEngine.Vector3), string guid = "", bool startKinematic = false)
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendTrashItem(string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void CreateTrashItem(global::FishNet.Connection.NetworkConnection conn, string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private global::ScheduleOne.Trash.TrashItem CreateAndReturnTrashItem(string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 initialVelocity, string guid, bool startKinematic)
		{
			return null;
		}

		public global::ScheduleOne.Trash.TrashItem CreateTrashBag(string id, global::UnityEngine.Vector3 posiiton, global::UnityEngine.Quaternion rotation, global::ScheduleOne.Persistence.TrashContentData content, global::UnityEngine.Vector3 initialVelocity = default(global::UnityEngine.Vector3), string guid = "", bool startKinematic = false)
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendTrashBag(string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::ScheduleOne.Persistence.TrashContentData content, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void CreateTrashBag(global::FishNet.Connection.NetworkConnection conn, string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::ScheduleOne.Persistence.TrashContentData content, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private global::ScheduleOne.Trash.TrashItem CreateAndReturnTrashBag(string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::ScheduleOne.Persistence.TrashContentData content, global::UnityEngine.Vector3 initialVelocity, string guid, bool startKinematic)
		{
			return null;
		}

		public void DestroyAllTrash()
		{
		}

		public void DestroyTrash(global::ScheduleOne.Trash.TrashItem trash)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendDestroyTrash(string guid)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void DestroyTrash(string guid)
		{
		}

		public global::ScheduleOne.Trash.TrashItem GetTrashPrefab(string id)
		{
			return null;
		}

		public global::ScheduleOne.Trash.TrashItem GetRandomGeneratableTrashPrefab()
		{
			return null;
		}

		public virtual string GetSaveString()
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

		private void RpcWriter___Server_SendTransformData_2990100769(string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity, global::FishNet.Connection.NetworkConnection sender)
		{
		}

		private void RpcLogic___SendTransformData_2990100769(string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity, global::FishNet.Connection.NetworkConnection sender)
		{
		}

		private void RpcReader___Server_SendTransformData_2990100769(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveTransformData_2990100769(string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity, global::FishNet.Connection.NetworkConnection sender)
		{
		}

		private void RpcLogic___ReceiveTransformData_2990100769(string guid, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 velocity, global::FishNet.Connection.NetworkConnection sender)
		{
		}

		private void RpcReader___Observers_ReceiveTransformData_2990100769(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendTrashItem_478112418(string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcLogic___SendTrashItem_478112418(string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcReader___Server_SendTrashItem_478112418(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_CreateTrashItem_2385526393(global::FishNet.Connection.NetworkConnection conn, string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcLogic___CreateTrashItem_2385526393(global::FishNet.Connection.NetworkConnection conn, string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcReader___Observers_CreateTrashItem_2385526393(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_CreateTrashItem_2385526393(global::FishNet.Connection.NetworkConnection conn, string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcReader___Target_CreateTrashItem_2385526393(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendTrashBag_3965031115(string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::ScheduleOne.Persistence.TrashContentData content, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcLogic___SendTrashBag_3965031115(string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::ScheduleOne.Persistence.TrashContentData content, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcReader___Server_SendTrashBag_3965031115(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_CreateTrashBag_680856992(global::FishNet.Connection.NetworkConnection conn, string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::ScheduleOne.Persistence.TrashContentData content, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcLogic___CreateTrashBag_680856992(global::FishNet.Connection.NetworkConnection conn, string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::ScheduleOne.Persistence.TrashContentData content, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcReader___Observers_CreateTrashBag_680856992(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_CreateTrashBag_680856992(global::FishNet.Connection.NetworkConnection conn, string id, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::ScheduleOne.Persistence.TrashContentData content, global::UnityEngine.Vector3 initialVelocity, global::FishNet.Connection.NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		private void RpcReader___Target_CreateTrashBag_680856992(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendDestroyTrash_3615296227(string guid)
		{
		}

		private void RpcLogic___SendDestroyTrash_3615296227(string guid)
		{
		}

		private void RpcReader___Server_SendDestroyTrash_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_DestroyTrash_3615296227(string guid)
		{
		}

		private void RpcLogic___DestroyTrash_3615296227(string guid)
		{
		}

		private void RpcReader___Observers_DestroyTrash_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
