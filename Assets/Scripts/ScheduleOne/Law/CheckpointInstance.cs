using System;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	[Serializable]
	public class CheckpointInstance
	{
		public const float MIN_ACTIVATION_DISTANCE = 50f;

		public CheckpointManager.ECheckpointLocation Location;

		public int Members;

		public int StartTime;

		public int EndTime;

		[Range(1f, 10f)]
		public int IntensityRequirement;

		public bool OnlyIfCurfewEnabled;

		private RoadCheckpoint checkPoint;

		public RoadCheckpoint activeCheckpoint { get; protected set; }

		public void Evaluate()
		{
		}

		public void EnableCheckpoint()
		{
		}

		private bool DistanceRequirementsMet()
		{
			return false;
		}

		private void MinPass()
		{
		}

		public void DisableCheckpoint()
		{
		}
	}
}
