namespace ScheduleOne.Cartel
{
	public class CartelRegionActivities : global::FishNet.Object.NetworkBehaviour
	{
		public const int MIN_COOLDOWN = 12;

		public const int MAX_COOLDOWN = 48;

		public bool TEST_MODE;

		[global::UnityEngine.Header("Settings")]
		public bool Active;

		public global::ScheduleOne.Map.EMapRegion Region;

		public global::System.Collections.Generic.List<global::ScheduleOne.Cartel.CartelActivity> Activities;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Cartel.CartelAmbushLocation[] AmbushLocations;

		public global::ScheduleOne.Cartel.CartelDealer CartelDealer;

		[global::UnityEngine.Header("Development & Debugging")]
		public int _debugActivityIndex;

		private bool NetworkInitialize___EarlyScheduleOne_002ECartel_002ECartelRegionActivitiesAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECartel_002ECartelRegionActivitiesAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Cartel.CartelActivity CurrentActivity { get; private set; }

		public int HoursUntilNextActivity { get; set; }

		protected override void OnValidate()
		{
		}

		private void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void HourPass()
		{
		}

		private void TryStartActivity()
		{
		}

		[global::EasyButtons.Button]
		public void StartActivity()
		{
		}

		private void StartAcivity(int activityIndex)
		{
		}

		[global::EasyButtons.Button]
		public void ActivateDeal()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void StartActivity(global::FishNet.Connection.NetworkConnection conn, int activityIndex)
		{
		}

		private void ActivityEnded()
		{
		}

		public global::ScheduleOne.Persistence.CartelRegionalActivityData GetData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.CartelRegionalActivityData data)
		{
		}

		public static int GetNewCooldown(global::ScheduleOne.Map.EMapRegion region)
		{
			return 0;
		}

		private void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus)
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

		private void RpcWriter___Observers_StartActivity_2681120339(global::FishNet.Connection.NetworkConnection conn, int activityIndex)
		{
		}

		private void RpcLogic___StartActivity_2681120339(global::FishNet.Connection.NetworkConnection conn, int activityIndex)
		{
		}

		private void RpcReader___Observers_StartActivity_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_StartActivity_2681120339(global::FishNet.Connection.NetworkConnection conn, int activityIndex)
		{
		}

		private void RpcReader___Target_StartActivity_2681120339(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
