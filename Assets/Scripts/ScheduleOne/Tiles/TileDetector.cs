namespace ScheduleOne.Tiles
{
	public class TileDetector : global::UnityEngine.MonoBehaviour
	{
		public float detectionRadius;

		public global::ScheduleOne.Tiles.ETileDetectionMode tileDetectionMode;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.Tile> intersectedTiles;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.Tile> intersectedOutdoorTiles;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.Tile> intersectedIndoorTiles;

		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.StorageTile> intersectedStorageTiles;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.ProceduralTile> intersectedProceduralTiles;

		public virtual void CheckIntersections(bool sort = true)
		{
		}

		public global::System.Collections.Generic.List<T> OrderList<T>(global::System.Collections.Generic.List<T> list) where T : global::UnityEngine.MonoBehaviour
		{
			return null;
		}

		public global::ScheduleOne.Tiles.Tile GetClosestTile()
		{
			return null;
		}

		public global::ScheduleOne.Tiles.ProceduralTile GetClosestProceduralTile()
		{
			return null;
		}
	}
}
