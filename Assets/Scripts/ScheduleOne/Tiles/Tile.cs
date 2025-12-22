namespace ScheduleOne.Tiles
{
	[global::System.Serializable]
	public class Tile : global::UnityEngine.MonoBehaviour
	{
		public delegate void TileChange(global::ScheduleOne.Tiles.Tile thisTile);

		public int x;

		public int y;

		[global::UnityEngine.Header("Settings")]
		public float AvailableOffset;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Tiles.Grid OwnerGrid;

		public global::ScheduleOne.Lighting.LightExposureNode LightExposureNode;

		[global::UnityEngine.Header("Occupants")]
		public global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.GridItem> BuildableOccupants;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.FootprintTile> OccupantTiles;

		public global::ScheduleOne.Tiles.Tile.TileChange onTileChanged;

		public global::System.Action<global::ScheduleOne.Tiles.Tile, float> onTileTemperatureChanged;

		private float _cosmeticTileTemperature;

		private global::ScheduleOne.Temperature.TemperatureEmitterInfo[] _cachedCosmeticTemperatureEmitters;

		private float _tileTemperature;

		private global::ScheduleOne.Temperature.TemperatureEmitterInfo[] _cachedTemperatureEmitters;

		public float CosmeticTileTemperature => 0f;

		public float TileTemperature => 0f;

		public void InitializePropertyTile(int _x, int _y, float _available_Offset, global::ScheduleOne.Tiles.Grid _ownerGrid)
		{
		}

		private void Awake()
		{
		}

		public void AddOccupant(global::ScheduleOne.EntityFramework.GridItem occ, global::ScheduleOne.Tiles.FootprintTile tile)
		{
		}

		public void RemoveOccupant(global::ScheduleOne.EntityFramework.GridItem occ, global::ScheduleOne.Tiles.FootprintTile tile)
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

		private void OnCosmeticTemperatureEmittersChanged(string propertyCode, global::ScheduleOne.Temperature.TemperatureEmitterInfo[] emitters)
		{
		}

		private void OnTemperatureEmittersChanged(global::ScheduleOne.Temperature.TemperatureEmitterInfo[] emitters)
		{
		}
	}
}
