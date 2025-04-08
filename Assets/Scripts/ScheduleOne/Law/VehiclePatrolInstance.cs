namespace ScheduleOne.Law
{
	[global::System.Serializable]
	public class VehiclePatrolInstance
	{
		public global::ScheduleOne.NPCs.Behaviour.VehiclePatrolRoute Route;

		public int StartTime;

		[global::UnityEngine.Range(1f, 10f)]
		public int IntensityRequirement;

		public bool OnlyIfCurfewEnabled;

		private global::ScheduleOne.Police.PoliceOfficer activeOfficer;

		private int latestStartTime;

		private bool startedThisCycle;

		private global::ScheduleOne.Map.PoliceStation nearestStation => null;

		public void Evaluate()
		{
		}

		private void CheckEnd()
		{
		}

		public void StartPatrol()
		{
		}
	}
}
