namespace ScheduleOne.Map
{
	public class Map : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Map.Map>
	{
		public const global::ScheduleOne.Map.EMapRegion FINAL_REGION = global::ScheduleOne.Map.EMapRegion.Uptown;

		public bool UNLOCK_ALL_REGIONS;

		public global::ScheduleOne.Map.MapRegionData[] Regions;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Map.PoliceStation PoliceStation;

		public global::ScheduleOne.Map.MedicalCentre MedicalCentre;

		public global::UnityEngine.Transform TreeBounds;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public global::ScheduleOne.Map.MapRegionData GetRegionData(global::ScheduleOne.Map.EMapRegion region)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Map.EMapRegion> GetUnlockedRegions()
		{
			return null;
		}
	}
}
