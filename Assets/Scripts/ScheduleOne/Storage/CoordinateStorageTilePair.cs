using System;
using ScheduleOne.Tiles;

namespace ScheduleOne.Storage
{
	[Serializable]
	public struct CoordinateStorageTilePair
	{
		public Coordinate coord;

		public StorageTile tile;
	}
}
