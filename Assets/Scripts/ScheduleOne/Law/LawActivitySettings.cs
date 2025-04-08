namespace ScheduleOne.Law
{
	[global::System.Serializable]
	public class LawActivitySettings
	{
		public global::ScheduleOne.Law.PatrolInstance[] Patrols;

		public global::ScheduleOne.Law.CheckpointInstance[] Checkpoints;

		public global::ScheduleOne.Law.CurfewInstance[] Curfews;

		public global::ScheduleOne.Law.VehiclePatrolInstance[] VehiclePatrols;

		public global::ScheduleOne.Law.SentryInstance[] Sentries;

		public void Evaluate()
		{
		}

		public void End()
		{
		}

		public void OnLoaded()
		{
		}
	}
}
