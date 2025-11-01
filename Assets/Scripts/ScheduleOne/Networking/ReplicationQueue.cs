namespace ScheduleOne.Networking
{
	public class ReplicationQueue : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Networking.ReplicationQueue>
	{
		public class ReplicationRequest
		{
			public string TaskName;

			public global::FishNet.Connection.NetworkConnection Target;

			public global::System.Action<global::FishNet.Connection.NetworkConnection> Callback;

			public int ApproximateSizeBytes;

			public bool IsValid()
			{
				return false;
			}
		}

		public const int RATE_LIMIT_BYTES_PER_SECOND = 102400;

		private global::System.Collections.Generic.Dictionary<global::FishNet.Connection.NetworkConnection, global::System.Collections.Generic.List<global::ScheduleOne.Networking.ReplicationQueue.ReplicationRequest>> requestsByConnection;

		private global::System.Collections.Generic.List<global::ScheduleOne.Networking.ReplicationQueue.ReplicationRequest> queue;

		private int currentByteBudget;

		private float timeOnLastReplicationTaskRPC;

		private bool NetworkInitialize___EarlyScheduleOne_002ENetworking_002EReplicationQueueAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENetworking_002EReplicationQueueAssembly_002DCSharp_002Edll_Excuted;

		public bool ReplicationDoneForLocalPlayer { get; private set; }

		public string CurrentReplicationTask { get; private set; }

		public static void Enqueue(string taskName, global::FishNet.Connection.NetworkConnection target, global::System.Action<global::FishNet.Connection.NetworkConnection> callback, int approximateSizeBytes = 32)
		{
		}

		public static float GetReplicationDuration(int approximateSizeBytes)
		{
			return 0f;
		}

		public override void OnStartServer()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.TargetRpc]
		private void SetReplicationDone(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.TargetRpc]
		private void SetReplicationTask(global::FishNet.Connection.NetworkConnection conn, string task)
		{
		}

		private void Enqueue_(string taskName, global::FishNet.Connection.NetworkConnection target, global::System.Action<global::FishNet.Connection.NetworkConnection> callback, int approximateSizeBytes = 32)
		{
		}

		private void Update()
		{
		}

		private void NotifyActiveReplicationTask(global::ScheduleOne.Networking.ReplicationQueue.ReplicationRequest request)
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Networking.ReplicationQueue.ReplicationRequest> GetRequestsForConnection(global::FishNet.Connection.NetworkConnection conn)
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

		private void RpcWriter___Target_SetReplicationDone_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___SetReplicationDone_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_SetReplicationDone_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetReplicationTask_2971853958(global::FishNet.Connection.NetworkConnection conn, string task)
		{
		}

		private void RpcLogic___SetReplicationTask_2971853958(global::FishNet.Connection.NetworkConnection conn, string task)
		{
		}

		private void RpcReader___Target_SetReplicationTask_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
