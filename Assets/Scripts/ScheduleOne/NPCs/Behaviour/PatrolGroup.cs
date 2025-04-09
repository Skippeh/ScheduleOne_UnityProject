using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class PatrolGroup
	{
		public List<NPC> Members;

		public FootPatrolRoute Route;

		public int CurrentWaypoint;

		public PatrolGroup(FootPatrolRoute route)
		{
		}

		public Vector3 GetDestination(NPC member)
		{
			return default(Vector3);
		}

		public void DisbandGroup()
		{
		}

		public void AdvanceGroup()
		{
		}

		private Vector3 GetMemberOffset(NPC member)
		{
			return default(Vector3);
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
