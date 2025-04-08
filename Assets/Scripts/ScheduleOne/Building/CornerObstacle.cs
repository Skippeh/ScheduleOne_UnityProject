namespace ScheduleOne.Building
{
	public class CornerObstacle : global::UnityEngine.MonoBehaviour
	{
		public bool obstacleEnabled;

		public global::ScheduleOne.Tiles.FootprintTile parentFootprint;

		public global::UnityEngine.Vector2 coordinates;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.Tile> GetNeighbourTiles(global::ScheduleOne.Tiles.Tile pairedTile)
		{
			return null;
		}

		private bool ApproxEquals(float a, float b, float precision)
		{
			return false;
		}
	}
}
