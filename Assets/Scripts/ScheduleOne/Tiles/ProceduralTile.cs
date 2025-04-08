namespace ScheduleOne.Tiles
{
	public class ProceduralTile : global::UnityEngine.MonoBehaviour
	{
		public enum EProceduralTileType
		{
			Rack = 0
		}

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Tiles.ProceduralTile.EProceduralTileType TileType;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.EntityFramework.BuildableItem ParentBuildableItem;

		public global::ScheduleOne.Tiles.FootprintTile MatchedFootprintTile;

		[global::UnityEngine.Header("Occupants")]
		public global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.ProceduralGridItem> Occupants;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.FootprintTile> OccupantTiles;

		protected virtual void Awake()
		{
		}

		public void AddOccupant(global::ScheduleOne.Tiles.FootprintTile footprint, global::ScheduleOne.EntityFramework.ProceduralGridItem item)
		{
		}

		public void RemoveOccupant(global::ScheduleOne.Tiles.FootprintTile footprint, global::ScheduleOne.EntityFramework.ProceduralGridItem item)
		{
		}
	}
}
