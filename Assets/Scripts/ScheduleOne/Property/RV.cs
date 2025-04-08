namespace ScheduleOne.Property
{
	public class RV : global::ScheduleOne.Property.Property
	{
		public global::UnityEngine.Transform ModelContainer;

		public global::UnityEngine.Transform FXContainer;

		public global::UnityEngine.Events.UnityEvent onSetExploded;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002ERVAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002ERVAssembly_002DCSharp_002Edll_Excuted;

		public bool _isExploded { get; private set; }

		protected override void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void UpdateVariables()
		{
		}

		public void Ransack()
		{
		}

		public override bool ShouldSave()
		{
			return false;
		}

		[global::FishNet.Object.TargetRpc]
		public void SetExploded(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public void SetExploded()
		{
		}

		private void OnSleep()
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

		private void RpcWriter___Target_SetExploded_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public void RpcLogic___SetExploded_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_SetExploded_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
