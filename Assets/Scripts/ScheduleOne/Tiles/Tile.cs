namespace ScheduleOne.Tiles
{
	[global::System.Serializable]
	public class Tile : global::UnityEngine.MonoBehaviour
	{
		public delegate void TileChange(global::ScheduleOne.Tiles.Tile thisTile);

		public static float TileSize;

		public int x;

		public int y;

		[global::UnityEngine.Header("Settings")]
		public float AvailableOffset;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Tiles.Grid OwnerGrid;

		public global::ScheduleOne.Lighting.LightExposureNode LightExposureNode;

		[global::UnityEngine.Header("Occupants")]
		public global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.GridItem> BuildableOccupants;

		public global::System.Collections.Generic.List<global::ScheduleOne.ConstructableScripts.Constructable_GridBased> ConstructableOccupants;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.FootprintTile> OccupantTiles;

		public global::ScheduleOne.Tiles.Tile.TileChange onTileChanged;

		public void InitializePropertyTile(int _x, int _y, float _available_Offset, global::ScheduleOne.Tiles.Grid _ownerGrid)
		{
		}

		public void AddOccupant(global::ScheduleOne.EntityFramework.GridItem occ, global::ScheduleOne.Tiles.FootprintTile tile)
		{
		}

		public void AddOccupant(global::ScheduleOne.ConstructableScripts.Constructable_GridBased occ, global::ScheduleOne.Tiles.FootprintTile tile)
		{
		}

		public void RemoveOccupant(global::ScheduleOne.EntityFramework.GridItem occ, global::ScheduleOne.Tiles.FootprintTile tile)
		{
		}

		public void RemoveOccupant(global::ScheduleOne.ConstructableScripts.Constructable_GridBased occ, global::ScheduleOne.Tiles.FootprintTile tile)
		{
		}

		public virtual bool CanBeBuiltOn()
		{
			return false;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.Tile> GetSurroundingTiles()
		{
			return null;
		}

		public virtual bool IsIndoorTile()
		{
			return false;
		}

		public void SetVisible(bool vis)
		{
		}
	}
}
