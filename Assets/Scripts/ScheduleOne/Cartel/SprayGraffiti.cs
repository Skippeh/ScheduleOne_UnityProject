namespace ScheduleOne.Cartel
{
	public class SprayGraffiti : global::ScheduleOne.Cartel.CartelActivity
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private float _minimumDistanceFromPlayers;

		private global::ScheduleOne.Graffiti.WorldSpraySurface _validSpraySurface;

		public override bool IsRegionValidForActivity(global::ScheduleOne.Map.EMapRegion region)
		{
			return false;
		}

		public void SetSpraySurface(global::ScheduleOne.Map.EMapRegion region, bool overrideExisting = true)
		{
		}

		public override void Activate(global::ScheduleOne.Map.EMapRegion region)
		{
		}
	}
}
