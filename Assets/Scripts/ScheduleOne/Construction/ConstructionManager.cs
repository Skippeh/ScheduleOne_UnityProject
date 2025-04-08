namespace ScheduleOne.Construction
{
	public class ConstructionManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Construction.ConstructionManager>
	{
		public class WorldIntersection
		{
			public global::ScheduleOne.Tiles.FootprintTile footprint;

			public global::ScheduleOne.Tiles.Tile tile;
		}

		public delegate void ConstructableNotification(global::ScheduleOne.ConstructableScripts.Constructable c);

		public global::FishNet.Object.NetworkObject networkObject;

		public global::System.Action onConstructionModeEnabled;

		public global::System.Action onConstructionModeDisabled;

		public global::UnityEngine.GameObject constructHandler;

		public global::ScheduleOne.Construction.ConstructionManager.ConstructableNotification onNewConstructableBuilt;

		public global::ScheduleOne.Construction.ConstructionManager.ConstructableNotification onConstructableMoved;

		public global::ScheduleOne.Property.Property currentProperty;

		public bool constructionModeEnabled { get; protected set; }

		public bool isDeployingConstructable { get; protected set; }

		public bool isMovingConstructable { get; protected set; }

		protected override void Start()
		{
		}

		public void EnterConstructionMode(global::ScheduleOne.Property.Property prop)
		{
		}

		public void ExitConstructionMode()
		{
		}

		public void DeployConstructable(global::ScheduleOne.UI.Construction.ConstructionMenu.ConstructionMenuListing listing)
		{
		}

		public void StopConstructableDeploy()
		{
		}

		public void MoveConstructable(global::ScheduleOne.ConstructableScripts.Constructable_GridBased c)
		{
		}

		public void StopMovingConstructable()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		public global::ScheduleOne.ConstructableScripts.Constructable_GridBased CreateConstructable_GridBased(string ID, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, float rotation)
		{
			return null;
		}

		public global::ScheduleOne.ConstructableScripts.Constructable CreateConstructable(string prefabID)
		{
			return null;
		}
	}
}
