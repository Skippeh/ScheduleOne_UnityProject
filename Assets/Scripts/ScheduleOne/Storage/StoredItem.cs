namespace ScheduleOne.Storage
{
	public class StoredItem : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform buildPoint;

		public global::System.Collections.Generic.List<global::ScheduleOne.Storage.CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs;

		private int footprintX;

		private int footprintY;

		protected global::ScheduleOne.Interaction.InteractableObject intObj;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinatePair> coordinatePairs;

		protected float rotation;

		public int xSize;

		public int ySize;

		public global::ScheduleOne.Storage.StorableItemInstance item { get; protected set; }

		public bool Destroyed { get; private set; }

		public global::ScheduleOne.Tiles.FootprintTile OriginFootprint => null;

		public int FootprintX => 0;

		public int FootprintY => 0;

		public global::ScheduleOne.Storage.IStorageEntity parentStorageEntity { get; protected set; }

		public global::ScheduleOne.Storage.StorageGrid parentGrid { get; protected set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinatePair> CoordinatePairs => null;

		public float Rotation => 0f;

		public int totalArea => 0;

		public bool canBePickedUp { get; protected set; }

		public string noPickupReason { get; protected set; }

		protected virtual void Awake()
		{
		}

		protected virtual void OnValidate()
		{
		}

		public virtual void InitializeStoredItem(global::ScheduleOne.Storage.StorableItemInstance _item, global::ScheduleOne.Storage.StorageGrid grid, global::UnityEngine.Vector2 _originCoordinate, float _rotation)
		{
		}

		private void RefreshTransform()
		{
		}

		protected virtual void InitializeIntObj()
		{
		}

		public virtual void Destroy_Internal()
		{
		}

		public void DestroyStoredItem()
		{
		}

		public void ClearFootprintOccupancy()
		{
		}

		public void SetCanBePickedUp(bool _canBePickedUp, string _noPickupReason = "")
		{
		}

		public static void SetLayerRecursively(global::UnityEngine.GameObject go, int layerNumber)
		{
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.Storage.StoredItem> RemoveReservedItems(global::System.Collections.Generic.List<global::ScheduleOne.Storage.StoredItem> itemList, global::ScheduleOne.Employees.Employee allowedReservant)
		{
			return null;
		}

		public virtual global::UnityEngine.GameObject CreateGhostModel(global::ScheduleOne.ItemFramework.ItemInstance _item, global::UnityEngine.Transform parent)
		{
			return null;
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

		public virtual void Hovered()
		{
		}

		public virtual void Interacted()
		{
		}
	}
}
