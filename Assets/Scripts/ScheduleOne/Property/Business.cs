namespace ScheduleOne.Property
{
	public class Business : global::ScheduleOne.Property.Property, global::ScheduleOne.Persistence.ISaveable
	{
		public static global::System.Collections.Generic.List<global::ScheduleOne.Property.Business> Businesses;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Property.Business> UnownedBusinesses;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Property.Business> OwnedBusinesses;

		[global::UnityEngine.Header("Settings")]
		public float LaunderCapacity;

		public global::System.Collections.Generic.List<global::ScheduleOne.Property.LaunderingOperation> LaunderingOperations;

		public static global::System.Action<global::ScheduleOne.Property.LaunderingOperation> onOperationStarted;

		public static global::System.Action<global::ScheduleOne.Property.LaunderingOperation> onOperationFinished;

		private global::ScheduleOne.Persistence.Loaders.BusinessLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002EBusinessAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002EBusinessAssembly_002DCSharp_002Edll_Excuted;

		public float currentLaunderTotal => 0f;

		public float appliedLaunderLimit => 0f;

		public new global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void GetNetworth(global::ScheduleOne.Money.MoneyManager.FloatContainer container)
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		protected virtual void MinPass()
		{
		}

		protected virtual void MinsPass(int mins)
		{
		}

		private void TimeSkipped(int minsPassed)
		{
		}

		public override string GetSaveString()
		{
			return null;
		}

		public override void Load(global::ScheduleOne.Persistence.Datas.PropertyData propertyData, string dataString)
		{
		}

		protected override void RecieveOwned()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void StartLaunderingOperation(float amount, int minutesSinceStarted = 0)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc]
		private void ReceiveLaunderingOperation(global::FishNet.Connection.NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		protected void CompleteOperation(global::ScheduleOne.Property.LaunderingOperation op)
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

		private void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
		}

		public void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
		}

		private void RpcReader___Server_StartLaunderingOperation_1481775633(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(global::FishNet.Connection.NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		private void RpcLogic___ReceiveLaunderingOperation_1001022388(global::FishNet.Connection.NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		private void RpcReader___Target_ReceiveLaunderingOperation_1001022388(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(global::FishNet.Connection.NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		private void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EProperty_002EBusiness_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
