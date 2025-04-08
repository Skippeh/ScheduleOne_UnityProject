namespace ScheduleOne.Construction.ConstructionMethods
{
	public class ConstructUpdate_OutdoorGrid : global::ScheduleOne.Construction.ConstructionMethods.ConstructUpdate_Base
	{
		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask detectionMask;

		public global::ScheduleOne.ConstructableScripts.Constructable_GridBased ConstructableClass;

		public global::UnityEngine.Transform GhostModel;

		protected bool validPosition;

		public float currentRotation;

		protected global::UnityEngine.Material currentGhostMaterial;

		protected global::ScheduleOne.Construction.ConstructionManager.WorldIntersection closestIntersection;

		private float listingPrice;

		protected virtual void Start()
		{
		}

		protected override void Update()
		{
		}

		protected override void LateUpdate()
		{
		}

		protected void CheckRotation()
		{
		}

		protected void ApplyRotation()
		{
		}

		protected virtual void CheckTileIntersections()
		{
		}

		protected void UpdateMaterials()
		{
		}

		private bool AreMetaReqsMet()
		{
			return false;
		}

		protected virtual global::ScheduleOne.ConstructableScripts.Constructable_GridBased PlaceNewConstructable()
		{
			return null;
		}

		protected virtual void FinalizeMoveConstructable()
		{
		}

		private global::UnityEngine.Vector2 GetOriginCoordinate()
		{
			return default(global::UnityEngine.Vector2);
		}
	}
}
