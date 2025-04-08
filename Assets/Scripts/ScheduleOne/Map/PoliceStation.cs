namespace ScheduleOne.Map
{
	public class PoliceStation : global::ScheduleOne.Map.NPCEnterableBuilding
	{
		public enum EDispatchType
		{
			Auto = 0,
			UseVehicle = 1,
			OnFoot = 2
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.Map.PoliceStation> PoliceStations;

		public int VehicleLimit;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform SpawnPoint;

		public global::UnityEngine.Transform[] VehicleSpawnPoints;

		public global::UnityEngine.Transform[] PossessedVehicleSpawnPoints;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.Vehicles.LandVehicle[] PoliceVehiclePrefabs;

		public global::System.Collections.Generic.List<global::ScheduleOne.Police.PoliceOfficer> OfficerPool;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> deployedVehicles;

		public float TimeSinceLastDispatch { get; private set; }

		private int deployedVehicleCount => 0;

		protected override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void CleanVehicleList()
		{
		}

		public void Dispatch(int requestedOfficerCount, global::ScheduleOne.PlayerScripts.Player targetPlayer, global::ScheduleOne.Map.PoliceStation.EDispatchType type = global::ScheduleOne.Map.PoliceStation.EDispatchType.Auto, bool beginAsSighted = false)
		{
		}

		public global::ScheduleOne.Police.PoliceOfficer PullOfficer()
		{
			return null;
		}

		public global::ScheduleOne.Vehicles.LandVehicle CreateVehicle()
		{
			return null;
		}

		public override void NPCEnteredBuilding(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public override void NPCExitedBuilding(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public static global::ScheduleOne.Map.PoliceStation GetClosestPoliceStation(global::UnityEngine.Vector3 point)
		{
			return null;
		}
	}
}
