namespace ScheduleOne.Trash
{
	public class TrashContainer : global::FishNet.Object.NetworkBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Range(1f, 50f)]
		public int TrashCapacity;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Transform TrashBagDropLocation;

		public global::UnityEngine.Events.UnityEvent<string> onTrashAdded;

		public global::UnityEngine.Events.UnityEvent onTrashLevelChanged;

		private bool NetworkInitialize___EarlyScheduleOne_002ETrash_002ETrashContainerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ETrash_002ETrashContainerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Trash.TrashContent Content { get; protected set; }

		public int TrashLevel => 0;

		public float NormalizedTrashLevel => 0f;

		public virtual void AddTrash(global::ScheduleOne.Trash.TrashItem item)
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendTrash(string trashID, int quantity)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void AddTrash(global::FishNet.Connection.NetworkConnection conn, string trashID, int quantity)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendClear()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void Clear()
		{
		}

		[global::FishNet.Object.TargetRpc]
		private void LoadContent(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.TrashContentData data)
		{
		}

		public void TriggerEnter(global::UnityEngine.Collider other)
		{
		}

		public bool CanBeBagged()
		{
			return false;
		}

		public void BagTrash()
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

		private void RpcWriter___Server_SendTrash_3643459082(string trashID, int quantity)
		{
		}

		private void RpcLogic___SendTrash_3643459082(string trashID, int quantity)
		{
		}

		private void RpcReader___Server_SendTrash_3643459082(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_AddTrash_3905681115(global::FishNet.Connection.NetworkConnection conn, string trashID, int quantity)
		{
		}

		private void RpcLogic___AddTrash_3905681115(global::FishNet.Connection.NetworkConnection conn, string trashID, int quantity)
		{
		}

		private void RpcReader___Observers_AddTrash_3905681115(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_AddTrash_3905681115(global::FishNet.Connection.NetworkConnection conn, string trashID, int quantity)
		{
		}

		private void RpcReader___Target_AddTrash_3905681115(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendClear_2166136261()
		{
		}

		private void RpcLogic___SendClear_2166136261()
		{
		}

		private void RpcReader___Server_SendClear_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Clear_2166136261()
		{
		}

		private void RpcLogic___Clear_2166136261()
		{
		}

		private void RpcReader___Observers_Clear_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_LoadContent_189522235(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.TrashContentData data)
		{
		}

		private void RpcLogic___LoadContent_189522235(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.TrashContentData data)
		{
		}

		private void RpcReader___Target_LoadContent_189522235(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
