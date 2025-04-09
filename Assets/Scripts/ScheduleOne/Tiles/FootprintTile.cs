using System.Collections.Generic;
using ScheduleOne.Building;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	public class FootprintTile : MonoBehaviour
	{
		public TileAppearance tileAppearance;

		public TileDetector tileDetector;

		public int X;

		public int Y;

		public float RequiredOffset;

		public List<CornerObstacle> Corners;

		public Tile MatchedStandardTile { get; protected set; }

		protected virtual void Awake()
		{
		}

		public virtual void Initialize(Tile matchedTile)
		{
		}

		public bool AreCornerObstaclesBlocked(Tile proposedTile)
		{
			return false;
		}
	}
}
