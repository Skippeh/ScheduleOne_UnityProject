using System;
using ScheduleOne.Map;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	[Serializable]
	public class VehiclePatrolInstance
	{
		public VehiclePatrolRoute Route;

		public int StartTime;

		[Range(1f, 10f)]
		public int IntensityRequirement;

		public bool OnlyIfCurfewEnabled;

		private PoliceOfficer activeOfficer;

		private int latestStartTime;

		private bool startedThisCycle;

		private PoliceStation nearestStation => null;

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
