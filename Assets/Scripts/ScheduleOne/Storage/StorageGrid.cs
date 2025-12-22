namespace ScheduleOne.Storage
{
	public class StorageGrid : global::UnityEngine.MonoBehaviour
	{
		public static float gridSize;

		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.StorageTile> storageTiles;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.StorageTile> freeTiles;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.CoordinateStorageTilePair> coordinateStorageTilePairs;

		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.Tiles.Coordinate, global::ScheduleOne.Storage.StorageTile> coordinateToTile;

		protected virtual void Awake()
		{
		}

		private void ProcessCoordinateTilePairs()
		{
		}

		public void RegisterTile(global::ScheduleOne.Storage.StorageTile tile)
		{
		}

		public void DeregisterTile(global::ScheduleOne.Storage.StorageTile tile)
		{
		}

		public bool IsItemPositionValid(global::ScheduleOne.Storage.StorageTile primaryTile, global::ScheduleOne.Tiles.FootprintTile primaryFootprintTile, global::ScheduleOne.Storage.StoredItem item)
		{
			return false;
		}

		public global::ScheduleOne.Tiles.Coordinate GetMatchedCoordinate(global::ScheduleOne.Tiles.FootprintTile tileToMatch)
		{
			return null;
		}

		public bool IsGridPositionValid(global::ScheduleOne.Tiles.Coordinate gridCoord, global::ScheduleOne.Tiles.FootprintTile tile)
		{
			return false;
		}

		public global::ScheduleOne.Storage.StorageTile GetTile(global::ScheduleOne.Tiles.Coordinate coord)
		{
			return null;
		}

		public int GetUserEndCapacity()
		{
			return 0;
		}

		public int GetActualY()
		{
			return 0;
		}

		public int GetActualX()
		{
			return 0;
		}

		public int GetTotalFootprintSize()
		{
			return 0;
		}

		public bool TryFitItem(int sizeX, int sizeY, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.Coordinate> lockedCoordinates, out global::ScheduleOne.Tiles.Coordinate originCoordinate, out float rotation)
		{
			originCoordinate = null;
			rotation = default(float);
			return false;
		}
	}
}
