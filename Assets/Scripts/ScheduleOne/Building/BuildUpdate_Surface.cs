namespace ScheduleOne.Building
{
	public class BuildUpdate_Surface : global::ScheduleOne.Building.BuildUpdate_Base
	{
		public global::UnityEngine.GameObject GhostModel;

		public global::ScheduleOne.EntityFramework.SurfaceItem BuildableItemClass;

		public global::ScheduleOne.ItemFramework.ItemInstance ItemInstance;

		public float CurrentRotation;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask DetectionMask;

		protected bool validPosition;

		protected global::UnityEngine.Material currentGhostMaterial;

		protected global::ScheduleOne.Building.Surface hoveredValidSurface;

		private float detectionRange => 0f;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward)
		{
		}

		private bool IsSurfaceValidForItem(global::ScheduleOne.Building.Surface surface, global::UnityEngine.Collider hitCollider, global::UnityEngine.Vector3 hitPoint)
		{
			return false;
		}

		protected void CheckRotation()
		{
		}

		protected void UpdateMaterials()
		{
		}

		protected virtual void Place()
		{
		}
	}
}
