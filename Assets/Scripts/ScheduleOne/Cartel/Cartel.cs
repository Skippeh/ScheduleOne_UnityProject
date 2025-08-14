namespace ScheduleOne.Cartel
{
	public class Cartel : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Cartel.Cartel>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public bool TEST_MODE;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Cartel.CartelActivities Activities;

		public global::ScheduleOne.Cartel.CartelInfluence Influence;

		public global::ScheduleOne.Cartel.GoonPool GoonPool;

		public global::ScheduleOne.Cartel.CartelDealManager DealManager;

		public global::System.Action<ECartelStatus, ECartelStatus> OnStatusChange;

		private global::ScheduleOne.Persistence.Loaders.CartelLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002ECartel_002ECartelAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECartel_002ECartelAssembly_002DCSharp_002Edll_Excuted;

		public ECartelStatus Status { get; private set; }

		public int HoursSinceStatusChange { get; private set; }

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

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void HourPass()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.CartelData data)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SetStatus_Server(ECartelStatus status, bool resetStatusChangedTimer)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetStatus(global::FishNet.Connection.NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
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

		private void RpcWriter___Server_SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer)
		{
		}

		public void RpcLogic___SetStatus_Server_2366206100(ECartelStatus status, bool resetStatusChangedTimer)
		{
		}

		private void RpcReader___Server_SetStatus_Server_2366206100(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetStatus_3666943613(global::FishNet.Connection.NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		public void RpcLogic___SetStatus_3666943613(global::FishNet.Connection.NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		private void RpcReader___Observers_SetStatus_3666943613(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetStatus_3666943613(global::FishNet.Connection.NetworkConnection conn, ECartelStatus newStatus, bool resetStatusChangeTimer)
		{
		}

		private void RpcReader___Target_SetStatus_3666943613(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
