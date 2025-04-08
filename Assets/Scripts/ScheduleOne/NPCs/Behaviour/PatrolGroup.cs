namespace ScheduleOne.NPCs.Behaviour
{
	public class PatrolGroup
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.NPC> Members;

		public global::ScheduleOne.NPCs.Behaviour.FootPatrolRoute Route;

		public int CurrentWaypoint;

		public PatrolGroup(global::ScheduleOne.NPCs.Behaviour.FootPatrolRoute route)
		{
		}

		public global::UnityEngine.Vector3 GetDestination(global::ScheduleOne.NPCs.NPC member)
		{
			return default(global::UnityEngine.Vector3);
		}

		public void DisbandGroup()
		{
		}

		public void AdvanceGroup()
		{
		}

		private global::UnityEngine.Vector3 GetMemberOffset(global::ScheduleOne.NPCs.NPC member)
		{
			return default(global::UnityEngine.Vector3);
		}

		public bool IsGroupReadyToAdvance()
		{
			return false;
		}

		public bool IsPaused()
		{
			return false;
		}
	}
}
