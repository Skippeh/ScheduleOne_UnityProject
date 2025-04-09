using ScheduleOne.ConstructableScripts;
using UnityEngine;

namespace ScheduleOne.Construction.ConstructionMethods
{
	public class ConstructUpdate_OutdoorGrid : ConstructUpdate_Base
	{
		[Header("Settings")]
		public LayerMask detectionMask;

		public Constructable_GridBased ConstructableClass;

		public Transform GhostModel;

		protected bool validPosition;

		public float currentRotation;

		protected Material currentGhostMaterial;

		protected ConstructionManager.WorldIntersection closestIntersection;

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

		protected virtual Constructable_GridBased PlaceNewConstructable()
		{
			return null;
		}

		protected virtual void FinalizeMoveConstructable()
		{
		}

		private Vector2 GetOriginCoordinate()
		{
			return default(Vector2);
		}
	}
}
