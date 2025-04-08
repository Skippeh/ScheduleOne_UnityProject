namespace ScheduleOne.Building
{
	public class BuildUpdate_Grid : global::ScheduleOne.Building.BuildUpdate_Base
	{
		public global::UnityEngine.GameObject GhostModel;

		public global::ScheduleOne.EntityFramework.GridItem BuildableItemClass;

		public global::ScheduleOne.ItemFramework.ItemInstance ItemInstance;

		public float CurrentRotation;

		[global::UnityEngine.Header("Settings")]
		public float detectionRange;

		public global::UnityEngine.LayerMask detectionMask;

		public float rotation_Smoothing;

		public bool AllowRotation;

		protected bool validPosition;

		protected global::UnityEngine.Material currentGhostMaterial;

		protected global::ScheduleOne.Building.TileIntersection closestIntersection;

		private float verticalOffset;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward, bool buildPointAsOrigin)
		{
		}

		protected void CheckRotation()
		{
		}

		protected void ApplyRotation()
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Building.TileIntersection> GetRelevantIntersections(global::ScheduleOne.Tiles.FootprintTile tile)
		{
			return null;
		}

		protected virtual void CheckIntersections()
		{
		}

		protected void UpdateMaterials()
		{
		}

		protected virtual void Place()
		{
		}

		private global::UnityEngine.Vector2 GetOriginCoordinate()
		{
			return default(global::UnityEngine.Vector2);
		}

		private global::ScheduleOne.Tiles.Grid GetHoveredGrid()
		{
			return null;
		}
	}
}
