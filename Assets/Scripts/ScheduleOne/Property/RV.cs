namespace ScheduleOne.Property
{
	public class RV : global::ScheduleOne.Property.Property
	{
		public global::UnityEngine.Transform ModelContainer;

		public global::UnityEngine.Transform FXContainer;

		public global::UnityEngine.Events.UnityEvent onExplode;

		public global::UnityEngine.Events.UnityEvent onDestroyedState;

		private bool _exploded;

		private bool NetworkInitialize___EarlyScheduleOne_002EProperty_002ERVAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProperty_002ERVAssembly_002DCSharp_002Edll_Excuted;

		public bool IsDestroyed { get; private set; }

		protected override void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void UpdateVariables()
		{
		}

		public override bool ShouldSave()
		{
			return false;
		}

		[global::EasyButtons.Button]
		public void BlowUp()
		{
		}

		[global::FishNet.Object.TargetRpc]
		private void SetDestroyed_Client(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public void SetDestroyed()
		{
		}

		private void OnSleep()
		{
		}

		public override bool CanDeliverToProperty()
		{
			return false;
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

		private void RpcWriter___Target_SetDestroyed_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcLogic___SetDestroyed_Client_328543758(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcReader___Target_SetDestroyed_Client_328543758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
