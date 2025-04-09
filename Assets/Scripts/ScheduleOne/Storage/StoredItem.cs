using System.Collections.Generic;
using ScheduleOne.Employees;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Storage
{
	public class StoredItem : MonoBehaviour
	{
		[Header("References")]
		public Transform buildPoint;

		public List<CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs;

		private int footprintX;

		private int footprintY;

		protected InteractableObject intObj;

		protected List<CoordinatePair> coordinatePairs;

		protected float rotation;

		public int xSize;

		public int ySize;

		public StorableItemInstance item { get; protected set; }

		public bool Destroyed { get; private set; }

		public FootprintTile OriginFootprint => null;

		public int FootprintX => 0;

		public int FootprintY => 0;

		public IStorageEntity parentStorageEntity { get; protected set; }

		public StorageGrid parentGrid { get; protected set; }

		public List<CoordinatePair> CoordinatePairs => null;

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

		public virtual void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
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

		public static void SetLayerRecursively(GameObject go, int layerNumber)
		{
		}

		public static List<StoredItem> RemoveReservedItems(List<StoredItem> itemList, Employee allowedReservant)
		{
			return null;
		}

		public virtual GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			return null;
		}

		public void SetFootprintTileVisiblity(bool visible)
		{
		}

		public void CalculateFootprintTileIntersections()
		{
		}

		public FootprintTile GetTile(Coordinate coord)
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
