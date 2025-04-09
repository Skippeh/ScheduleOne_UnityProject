using ScheduleOne.ConstructableScripts;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	public class ConstructStart_OutdoorGrid : ConstructStart_Base
	{
		private Constructable_GridBased constructable;

		private Transform ghostModel;

		public override void StartConstruction(string constructableID, Constructable_GridBased movedConstructable = null)
		{
		}

		private void GenerateGhostModel(string id)
		{
		}
	}
}
