namespace ScheduleOne.ObjectScripts
{
	public class FloorRack : global::ScheduleOne.EntityFramework.GridItem, global::ScheduleOne.EntityFramework.IProceduralTileContainer
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform leg_BottomLeft;

		public global::UnityEngine.Transform leg_BottomRight;

		public global::UnityEngine.Transform leg_TopLeft;

		public global::UnityEngine.Transform leg_TopRight;

		public global::ScheduleOne.Building.CornerObstacle obs_BottomLeft;

		public global::ScheduleOne.Building.CornerObstacle obs_BottomRight;

		public global::ScheduleOne.Building.CornerObstacle obs_TopLeft;

		public global::ScheduleOne.Building.CornerObstacle obs_TopRight;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.ProceduralTile> procTiles;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EFloorRackAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EFloorRackAssembly_002DCSharp_002Edll_Excuted;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.ProceduralTile> ProceduralTiles => null;

		public virtual void UpdateLegVisibility()
		{
		}

		protected void CockAndBalls(global::UnityEngine.GameObject leg, global::ScheduleOne.Building.CornerObstacle obs, int xOffset, int yOffset)
		{
		}

		private global::ScheduleOne.ObjectScripts.FloorRack GetFloorRackFromOccupants(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.GridItem> occs)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.ObjectScripts.FloorRack> GetSurroundingRacks()
		{
			return null;
		}

		public override bool CanShareTileWith(global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.GridItem> obstacles)
		{
			return false;
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
