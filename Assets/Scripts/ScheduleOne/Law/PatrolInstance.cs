namespace ScheduleOne.Law
{
	[global::System.Serializable]
	public class PatrolInstance
	{
		public global::ScheduleOne.NPCs.Behaviour.FootPatrolRoute Route;

		public int Members;

		public int StartTime;

		public int EndTime;

		[global::UnityEngine.Range(1f, 10f)]
		public int IntensityRequirement;

		public bool OnlyIfCurfewEnabled;

		public global::ScheduleOne.NPCs.Behaviour.PatrolGroup ActiveGroup { get; protected set; }

		public void Evaluate()
		{
		}

		public void StartPatrol()
		{
		}

		private void MinPass()
		{
		}

		public void EndPatrol()
		{
		}
	}
}
