using System.Collections.Generic;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	public class CornerObstacle : MonoBehaviour
	{
		public bool obstacleEnabled;

		public FootprintTile parentFootprint;

		public Vector2 coordinates;

		public List<Tile> GetNeighbourTiles(Tile pairedTile)
		{
			return null;
		}

		private bool ApproxEquals(float a, float b, float precision)
		{
			return false;
		}
	}
}
