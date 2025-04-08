namespace ScheduleOne.Vehicles.AI
{
	public class PathGroup
	{
		public global::UnityEngine.Vector3 entryPoint;

		public global::Pathfinding.Path startToEntryPath;

		public global::Pathfinding.Path entryToExitPath;

		public global::Pathfinding.Path exitToDestinationPath;
	}
}
