namespace ScheduleOne.Storage
{
	public class StorageGrid : global::UnityEngine.MonoBehaviour
	{
		public static float gridSize;

		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.StorageTile> storageTiles;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.CoordinateStorageTilePair> coordinateStorageTilePairs;

		private int _unoccupiedTileCount;

		private bool _unoccupiedTileCountDirty;

		public int UnoccupiedTileCount => 0;

		private void Awake()
		{
		}

		public void RegisterTile(global::ScheduleOne.Storage.StorageTile tile)
		{
		}

		public void DeregisterTile(global::ScheduleOne.Storage.StorageTile tile)
		{
		}

		public global::ScheduleOne.Tiles.Coordinate GetMatchedCoordinate(global::ScheduleOne.Tiles.FootprintTile tileToMatch)
		{
			return null;
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

		private int CalculateUnoccupiedTileCount()
		{
			return 0;
		}

		private void TileOccupantChanged()
		{
		}
	}
}
