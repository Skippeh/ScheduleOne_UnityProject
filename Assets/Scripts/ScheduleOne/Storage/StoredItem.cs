namespace ScheduleOne.Storage
{
	public class StoredItem : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform buildPoint;

		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs;

		private int footprintX;

		private int footprintY;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinatePair> coordinatePairs;

		protected float rotation;

		public int xSize;

		public int ySize;

		public global::ScheduleOne.Storage.StorableItemInstance item { get; protected set; }

		public bool Destroyed { get; private set; }

		public global::ScheduleOne.Tiles.FootprintTile OriginFootprint => null;

		public int FootprintX => 0;

		public int FootprintY => 0;

		public global::ScheduleOne.Storage.StorageGrid parentGrid { get; protected set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinatePair> CoordinatePairs => null;

		public float Rotation => 0f;

		public int totalArea => 0;

		protected virtual void Awake()
		{
		}

		public virtual void InitializeStoredItem(global::ScheduleOne.Storage.StorableItemInstance _item, global::ScheduleOne.Storage.StorageGrid grid, global::UnityEngine.Vector2 _originCoordinate, float _rotation)
		{
		}

		private void RefreshTransform()
		{
		}

		public virtual void Destroy()
		{
		}

		public void ClearFootprintOccupancy()
		{
		}

		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		public void CalculateFootprintTileIntersections()
		{
		}

		public global::ScheduleOne.Tiles.FootprintTile GetTile(global::ScheduleOne.Tiles.Coordinate coord)
		{
			return null;
		}
	}
}
