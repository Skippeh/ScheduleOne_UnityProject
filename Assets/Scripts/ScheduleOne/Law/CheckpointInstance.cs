namespace ScheduleOne.Law
{
	[global::System.Serializable]
	public class CheckpointInstance
	{
		public const float MIN_ACTIVATION_DISTANCE = 50f;

		public global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation Location;

		public int Members;

		public int StartTime;

		public int EndTime;

		[global::UnityEngine.Range(1f, 10f)]
		public int IntensityRequirement;

		public bool OnlyIfCurfewEnabled;

		private global::ScheduleOne.Police.RoadCheckpoint checkPoint;

		public global::ScheduleOne.Police.RoadCheckpoint activeCheckpoint { get; protected set; }

		public void Evaluate()
		{
		}

		public void EnableCheckpoint()
		{
		}

		private bool DistanceRequirementsMet()
		{
			return false;
		}

		private void MinPass()
		{
		}

		public void DisableCheckpoint()
		{
		}
	}
}
