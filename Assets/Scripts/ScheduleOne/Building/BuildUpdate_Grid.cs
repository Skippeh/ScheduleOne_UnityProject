namespace ScheduleOne.Building
{
	public class BuildUpdate_Grid : global::ScheduleOne.Building.BuildUpdate_Base
	{
		[global::UnityEngine.Header("Settings")]
		public float detectionRange;

		public global::UnityEngine.LayerMask detectionMask;

		public float rotation_Smoothing;

		public bool AllowRotation;

		[global::UnityEngine.Header("Temperature")]
		[global::UnityEngine.SerializeField]
		private bool showTemperaturesByDefault;

		[global::UnityEngine.SerializeField]
		private bool allowToggleShowTemperatures;

		protected bool _validPosition;

		protected global::UnityEngine.Material _currentGhostMaterial;

		protected float _rotation;

		private global::ScheduleOne.Building.TileIntersection _closestIntersection;

		private float verticalOffset;

		protected bool _showTemperatures;

		public global::UnityEngine.GameObject GhostModel { get; private set; }

		public global::ScheduleOne.EntityFramework.GridItem BuildableItemClass { get; private set; }

		public global::ScheduleOne.ItemFramework.ItemInstance ItemInstance { get; private set; }

		public bool AllowToggleShowTemperatures => false;

		protected global::ScheduleOne.Building.TileIntersection closestIntersection
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void Initialize(global::ScheduleOne.EntityFramework.GridItem buildableItemClass, global::ScheduleOne.ItemFramework.ItemInstance itemInstance, global::UnityEngine.GameObject ghostModel)
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void CheckToggleTemperatureDisplay()
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

		protected virtual global::ScheduleOne.EntityFramework.GridItem Place()
		{
			return null;
		}

		protected virtual void OnPlacedObjectPreSpawn(global::ScheduleOne.EntityFramework.GridItem item)
		{
		}

		protected virtual void OnClosestIntersectionChanged(global::ScheduleOne.Building.TileIntersection previous, global::ScheduleOne.Building.TileIntersection current)
		{
		}

		protected virtual void SetShowTemperatures(bool show, global::ScheduleOne.Property.Property property)
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
