using System;
using UnityEngine;

namespace ScheduleOne.Dialogue
{
	[Serializable]
	public class BranchNodeData
	{
		public string Guid;

		public string BranchLabel;

		public Vector2 Position;

		public BranchOptionData[] options;
	}
}
