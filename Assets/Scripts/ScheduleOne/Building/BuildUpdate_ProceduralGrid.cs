namespace ScheduleOne.Building
{
	public class BuildUpdate_ProceduralGrid : global::ScheduleOne.Building.BuildUpdate_Base
	{
		public class Intersection
		{
			public global::ScheduleOne.Tiles.FootprintTile footprintTile;

			public global::ScheduleOne.Tiles.ProceduralTile procTile;
		}

		public global::UnityEngine.GameObject GhostModel;

		public global::ScheduleOne.EntityFramework.ProceduralGridItem ItemClass;

		public global::ScheduleOne.ItemFramework.ItemInstance ItemInstance;

		[global::UnityEngine.Header("Settings")]
		public float detectionRange;

		public global::UnityEngine.LayerMask detectionMask;

		public float rotation_Smoothing;

		protected float currentRotation;

		protected bool validPosition;

		protected global::UnityEngine.Material currentGhostMaterial;

		protected global::ScheduleOne.Building.BuildUpdate_ProceduralGrid.Intersection bestIntersection;

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

		private bool IsMatchValid(global::ScheduleOne.Tiles.FootprintTile footprintTile, global::ScheduleOne.Tiles.ProceduralTile matchedTile)
		{
			return false;
		}

		protected void Place()
		{
		}

		private global::ScheduleOne.Tiles.ProceduralTile GetNearbyProcTile()
		{
			return null;
		}
	}
}
