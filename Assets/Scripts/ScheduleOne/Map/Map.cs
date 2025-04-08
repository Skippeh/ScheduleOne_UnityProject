namespace ScheduleOne.Map
{
	public class Map : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Map.Map>
	{
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

		protected override void OnDestroy()
		{
		}

		public global::ScheduleOne.Map.MapRegionData GetRegionData(global::ScheduleOne.Map.EMapRegion region)
		{
			return null;
		}

		private void GameLoaded()
		{
		}

		private void OnRankUp(global::ScheduleOne.Levelling.FullRank oldRank, global::ScheduleOne.Levelling.FullRank newRank)
		{
		}
	}
}
