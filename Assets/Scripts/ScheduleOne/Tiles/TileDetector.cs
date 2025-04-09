using System.Collections.Generic;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	public class TileDetector : MonoBehaviour
	{
		public float detectionRadius;

		public ETileDetectionMode tileDetectionMode;

		public List<Tile> intersectedTiles;

		public List<Tile> intersectedOutdoorTiles;

		public List<Tile> intersectedIndoorTiles;

		public List<StorageTile> intersectedStorageTiles;

		public List<ProceduralTile> intersectedProceduralTiles;

		public virtual void CheckIntersections(bool sort = true)
		{
		}

		public List<T> OrderList<T>(List<T> list) where T : MonoBehaviour
		{
			return null;
		}

		public Tile GetClosestTile()
		{
			return null;
		}

		public ProceduralTile GetClosestProceduralTile()
		{
			return null;
		}
	}
}
