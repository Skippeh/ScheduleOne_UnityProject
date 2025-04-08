namespace ScheduleOne.Vehicles.AI
{
	[global::System.Serializable]
	public class DriveFlags
	{
		public enum EObstacleMode
		{
			Default = 0,
			IgnoreAll = 1,
			IgnoreOnlySquishy = 2
		}

		public bool OverrideSpeed;

		public float OverriddenSpeed;

		public float OverriddenReverseSpeed;

		public float SpeedLimitMultiplier;

		public bool IgnoreTrafficLights;

		public bool UseRoads;

		public bool StuckDetection;

		public global::ScheduleOne.Vehicles.AI.DriveFlags.EObstacleMode ObstacleMode;

		public bool AutoBrakeAtDestination;

		public bool TurnBasedSpeedReduction;

		public void ResetFlags()
		{
		}
	}
}
