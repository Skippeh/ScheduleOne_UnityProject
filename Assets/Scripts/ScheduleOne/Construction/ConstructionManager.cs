using System;
using FishNet.Object;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Construction;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Construction
{
	public class ConstructionManager : Singleton<ConstructionManager>
	{
		public class WorldIntersection
		{
			public FootprintTile footprint;

			public Tile tile;
		}

		public delegate void ConstructableNotification(Constructable c);

		public NetworkObject networkObject;

		public Action onConstructionModeEnabled;

		public Action onConstructionModeDisabled;

		public GameObject constructHandler;

		public ConstructableNotification onNewConstructableBuilt;

		public ConstructableNotification onConstructableMoved;

		public ScheduleOne.Property.Property currentProperty;

		public bool constructionModeEnabled { get; protected set; }

		public bool isDeployingConstructable { get; protected set; }

		public bool isMovingConstructable { get; protected set; }

		protected override void Start()
		{
		}

		public void EnterConstructionMode(ScheduleOne.Property.Property prop)
		{
		}

		public void ExitConstructionMode()
		{
		}

		public void DeployConstructable(ConstructionMenu.ConstructionMenuListing listing)
		{
		}

		public void StopConstructableDeploy()
		{
		}

		public void MoveConstructable(Constructable_GridBased c)
		{
		}

		public void StopMovingConstructable()
		{
		}

		private void Exit(ExitAction exit)
		{
		}

		public Constructable_GridBased CreateConstructable_GridBased(string ID, Grid grid, Vector2 originCoordinate, float rotation)
		{
			return null;
		}

		public Constructable CreateConstructable(string prefabID)
		{
			return null;
		}
	}
}
