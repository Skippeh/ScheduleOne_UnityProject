namespace ScheduleOne.Tiles
{
	public class Grid : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		public static float GridSideLength;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.Tile> Tiles;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateTilePair> CoordinateTilePairs;

		public global::UnityEngine.Transform Container;

		public bool IsStatic;

		public string StaticGUID;

		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.Tiles.Coordinate, global::ScheduleOne.Tiles.Tile> _coordinateToTile;

		public global::System.Guid GUID { get; protected set; }

		public void SetGUID(global::System.Guid guid)
		{
		}

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		protected virtual void Awake()
		{
		}

		public virtual void DestroyGrid()
		{
		}

		private void ProcessCoordinateDataPairs()
		{
		}

		public void RegisterTile(global::ScheduleOne.Tiles.Tile tile)
		{
		}

		public void DeregisterTile(global::ScheduleOne.Tiles.Tile tile)
		{
		}

		public global::ScheduleOne.Tiles.Coordinate GetMatchedCoordinate(global::ScheduleOne.Tiles.FootprintTile tileToMatch)
		{
			return null;
		}

		public bool IsTileValidAtCoordinate(global::ScheduleOne.Tiles.Coordinate gridCoord, global::ScheduleOne.Tiles.FootprintTile tile, global::ScheduleOne.EntityFramework.GridItem tileOwner = null)
		{
			return false;
		}

		public bool IsTileValidAtCoordinate(global::ScheduleOne.Tiles.Coordinate gridCoord, global::ScheduleOne.Tiles.FootprintTile tile, global::ScheduleOne.ConstructableScripts.Constructable_GridBased ignoreConstructable)
		{
			return false;
		}

		public global::ScheduleOne.Tiles.Tile GetTile(global::ScheduleOne.Tiles.Coordinate coord)
		{
			return null;
		}

		[global::EasyButtons.Button]
		public void SetVisible()
		{
		}

		[global::EasyButtons.Button]
		public void SetInvisible()
		{
		}
	}
}
