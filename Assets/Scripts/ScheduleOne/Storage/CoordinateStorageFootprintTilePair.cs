using System;
using ScheduleOne.Tiles;

namespace ScheduleOne.Storage
{
	[Serializable]
	public struct CoordinateStorageFootprintTilePair
	{
		public Coordinate coord;

		public FootprintTile tile;
	}
}
