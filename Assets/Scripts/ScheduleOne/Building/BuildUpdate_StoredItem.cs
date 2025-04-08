namespace ScheduleOne.Building
{
	public class BuildUpdate_StoredItem : global::ScheduleOne.Building.BuildUpdate_Base
	{
		public class StorageTileIntersection
		{
			public global::ScheduleOne.Tiles.FootprintTile footprintTile;

			public global::ScheduleOne.Storage.StorageTile storageTile;
		}

		public global::ScheduleOne.Storage.StorableItemInstance itemInstance;

		public global::UnityEngine.GameObject ghostModel;

		public global::ScheduleOne.Storage.StoredItem storedItemClass;

		protected global::ScheduleOne.Building.BuildUpdate_StoredItem.StorageTileIntersection bestIntersection;

		[global::UnityEngine.Header("Settings")]
		public float detectionRange;

		public global::UnityEngine.LayerMask detectionMask;

		public float storedItemHoldDistance;

		public float currentRotation;

		protected bool validPosition;

		protected global::UnityEngine.Material currentGhostMaterial;

		protected bool mouseUpSinceStart;

		protected bool mouseUpSincePlace;

		private global::UnityEngine.Vector3 positionDuringLastValidPosition;

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

		protected global::UnityEngine.Vector2 GetOriginCoordinate()
		{
			return default(global::UnityEngine.Vector2);
		}
	}
}
