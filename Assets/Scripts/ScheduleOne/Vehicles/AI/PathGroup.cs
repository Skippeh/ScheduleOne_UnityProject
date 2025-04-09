using Pathfinding;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	public class PathGroup
	{
		public Vector3 entryPoint;

		public Path startToEntryPath;

		public Path entryToExitPath;

		public Path exitToDestinationPath;
	}
}
