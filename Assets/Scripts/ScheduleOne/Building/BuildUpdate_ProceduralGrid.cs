using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	public class BuildUpdate_ProceduralGrid : BuildUpdate_Base
	{
		public class Intersection
		{
			public FootprintTile footprintTile;

			public ProceduralTile procTile;
		}

		public GameObject GhostModel;

		public ProceduralGridItem ItemClass;

		public ItemInstance ItemInstance;

		[Header("Settings")]
		public float detectionRange;

		public LayerMask detectionMask;

		public float rotation_Smoothing;

		protected float currentRotation;

		protected bool validPosition;

		protected Material currentGhostMaterial;

		protected Intersection bestIntersection;

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

		private bool IsMatchValid(FootprintTile footprintTile, ProceduralTile matchedTile)
		{
			return false;
		}

		protected void Place()
		{
		}

		private ProceduralTile GetNearbyProcTile()
		{
			return null;
		}
	}
}
