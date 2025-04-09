using System;
using System.Collections.Generic;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	[Serializable]
	public class SentryInstance
	{
		public SentryLocation Location;

		public int Members;

		[Header("Timing")]
		public int StartTime;

		public int EndTime;

		[Range(1f, 10f)]
		public int IntensityRequirement;

		public bool OnlyIfCurfewEnabled;

		private List<PoliceOfficer> officers;

		public void Evaluate()
		{
		}

		public void StartEntry()
		{
		}

		private void MinPass()
		{
		}

		public void EndSentry()
		{
		}
	}
}
