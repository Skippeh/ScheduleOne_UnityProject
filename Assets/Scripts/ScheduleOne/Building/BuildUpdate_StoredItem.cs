using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	public class BuildUpdate_StoredItem : BuildUpdate_Base
	{
		public class StorageTileIntersection
		{
			public FootprintTile footprintTile;

			public StorageTile storageTile;
		}

		public StorableItemInstance itemInstance;

		public GameObject ghostModel;

		public StoredItem storedItemClass;

		protected StorageTileIntersection bestIntersection;

		[Header("Settings")]
		public float detectionRange;

		public LayerMask detectionMask;

		public float storedItemHoldDistance;

		public float currentRotation;

		protected bool validPosition;

		protected Material currentGhostMaterial;

		protected bool mouseUpSinceStart;

		protected bool mouseUpSincePlace;

		private Vector3 positionDuringLastValidPosition;

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected void CheckRotation()
		{
		}

		protected void ApplyRotation()
		{
		}

		protected virtual void CheckGridIntersections()
		{
		}

		protected void UpdateMaterials()
		{
		}

		protected virtual void Place()
		{
		}

		protected virtual void PostPlace()
		{
		}

		protected Vector2 GetOriginCoordinate()
		{
			return default(Vector2);
		}
	}
}
