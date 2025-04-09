using System.Collections.Generic;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	public class StorageGrid : MonoBehaviour
	{
		public static float gridSize;

		public List<StorageTile> storageTiles;

		public List<StorageTile> freeTiles;

		public List<CoordinateStorageTilePair> coordinateStorageTilePairs;

		protected Dictionary<Coordinate, StorageTile> coordinateToTile;

		protected virtual void Awake()
		{
		}

		private void ProcessCoordinateTilePairs()
		{
		}

		public void RegisterTile(StorageTile tile)
		{
		}

		public void DeregisterTile(StorageTile tile)
		{
		}

		public bool IsItemPositionValid(StorageTile primaryTile, FootprintTile primaryFootprintTile, StoredItem item)
		{
			return false;
		}

		public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			return null;
		}

		public bool IsGridPositionValid(Coordinate gridCoord, FootprintTile tile)
		{
			return false;
		}

		public StorageTile GetTile(Coordinate coord)
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

		public bool TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation)
		{
			originCoordinate = null;
			rotation = default(float);
			return false;
		}
	}
}
