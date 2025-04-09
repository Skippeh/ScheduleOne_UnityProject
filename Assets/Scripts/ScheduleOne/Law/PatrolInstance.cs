using System;
using ScheduleOne.NPCs.Behaviour;
using UnityEngine;

namespace ScheduleOne.Law
{
	[Serializable]
	public class PatrolInstance
	{
		public FootPatrolRoute Route;

		public int Members;

		public int StartTime;

		public int EndTime;

		[Range(1f, 10f)]
		public int IntensityRequirement;

		public bool OnlyIfCurfewEnabled;

		public PatrolGroup ActiveGroup { get; protected set; }

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
