using System;

namespace ScheduleOne.Law
{
	[Serializable]
	public class LawActivitySettings
	{
		public PatrolInstance[] Patrols;

		public CheckpointInstance[] Checkpoints;

		public CurfewInstance[] Curfews;

		public VehiclePatrolInstance[] VehiclePatrols;

		public SentryInstance[] Sentries;

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
