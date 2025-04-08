namespace ScheduleOne.Tiles
{
	public class FootprintTile : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Tiles.TileAppearance tileAppearance;

		public global::ScheduleOne.Tiles.TileDetector tileDetector;

		public int X;

		public int Y;

		public float RequiredOffset;

		public global::System.Collections.Generic.List<global::ScheduleOne.Building.CornerObstacle> Corners;

		public global::ScheduleOne.Tiles.Tile MatchedStandardTile { get; protected set; }

		protected virtual void Awake()
		{
		}

		public virtual void Initialize(global::ScheduleOne.Tiles.Tile matchedTile)
		{
		}

		public bool AreCornerObstaclesBlocked(global::ScheduleOne.Tiles.Tile proposedTile)
		{
			return false;
		}
	}
}
