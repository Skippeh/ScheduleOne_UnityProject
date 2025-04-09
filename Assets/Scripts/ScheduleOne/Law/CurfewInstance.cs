using System;
using UnityEngine;

namespace ScheduleOne.Law
{
	[Serializable]
	public class CurfewInstance
	{
		public static CurfewInstance ActiveInstance;

		[Range(1f, 10f)]
		public int IntensityRequirement;

		[HideInInspector]
		public bool shouldDisable;

		public bool Enabled { get; protected set; }

		public void Evaluate(bool ignoreSleepReq = false)
		{
		}

		private void MinPass()
		{
		}

		public void Enable()
		{
		}

		public void Disable()
		{
		}
	}
}
