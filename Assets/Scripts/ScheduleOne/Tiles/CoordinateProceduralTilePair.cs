using System;
using FishNet.Object;

namespace ScheduleOne.Tiles
{
	[Serializable]
	public struct CoordinateProceduralTilePair
	{
		public Coordinate coord;

		public NetworkObject tileParent;

		public int tileIndex;

		public ProceduralTile tile => null;
	}
}
