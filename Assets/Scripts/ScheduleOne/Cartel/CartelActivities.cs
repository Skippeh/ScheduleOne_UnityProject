namespace ScheduleOne.Cartel
{
	public class CartelActivities : global::FishNet.Object.NetworkBehaviour
	{
		public const int MAX_COOLDOWN_HOURS = 24;

		public const int MIN_COOLDOWN_HOURS = 6;

		[global::UnityEngine.Header("References")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Cartel.CartelActivity> GlobalActivities;

		public global::ScheduleOne.Cartel.CartelRegionActivities[] RegionalActivities;

		private bool NetworkInitialize___EarlyScheduleOne_002ECartel_002ECartelActivitiesAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ECartel_002ECartelActivitiesAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Cartel.CartelActivity CurrentGlobalActivity { get; private set; }

		public int HoursUntilNextGlobalActivity { get; set; }

		private void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public global::ScheduleOne.Cartel.CartelRegionActivities GetRegionalActivities(global::ScheduleOne.Map.EMapRegion region)
		{
			return null;
		}

		private void HourPass()
		{
		}

		private void TryStartActivity()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void StartGlobalActivity(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Map.EMapRegion region, int activityIndex)
		{
		}

		private void ActivityEnded()
		{
		}

		private bool CanNewActivityBegin()
		{
			return false;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Cartel.CartelActivity> GetActivitiesReadyToStart()
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Map.EMapRegion> GetValidRegionsForActivity()
		{
			return null;
		}

		public static int GetNewCooldown()
		{
			return 0;
		}

		private static float GetInfluenceFraction()
		{
			return 0f;
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

		private void RpcWriter___Observers_StartGlobalActivity_1796582335(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Map.EMapRegion region, int activityIndex)
		{
		}

		private void RpcLogic___StartGlobalActivity_1796582335(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Map.EMapRegion region, int activityIndex)
		{
		}

		private void RpcReader___Observers_StartGlobalActivity_1796582335(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_StartGlobalActivity_1796582335(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Map.EMapRegion region, int activityIndex)
		{
		}

		private void RpcReader___Target_StartGlobalActivity_1796582335(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
