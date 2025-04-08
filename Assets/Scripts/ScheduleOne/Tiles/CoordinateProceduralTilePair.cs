namespace ScheduleOne.Tiles
{
	[global::System.Serializable]
	public struct CoordinateProceduralTilePair
	{
		public global::ScheduleOne.Tiles.Coordinate coord;

		public global::FishNet.Object.NetworkObject tileParent;

		public int tileIndex;

		public global::ScheduleOne.Tiles.ProceduralTile tile => null;
	}
}
