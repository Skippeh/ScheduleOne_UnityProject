using System;
using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	public class Grid : MonoBehaviour, IGUIDRegisterable
	{
		public static float GridSideLength;

		public List<Tile> Tiles;

		public List<CoordinateTilePair> CoordinateTilePairs;

		public Transform Container;

		public bool IsStatic;

		public string StaticGUID;

		protected Dictionary<Coordinate, Tile> _coordinateToTile;

		public Guid GUID { get; protected set; }

		public void SetGUID(Guid guid)
		{
		}

		protected virtual void Awake()
		{
		}

		public virtual void DestroyGrid()
		{
		}

		private void ProcessCoordinateDataPairs()
		{
		}

		public void RegisterTile(Tile tile)
		{
		}

		public void DeregisterTile(Tile tile)
		{
		}

		public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			return null;
		}

		public bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, GridItem tileOwner = null)
		{
			return false;
		}

		public bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, Constructable_GridBased ignoreConstructable)
		{
			return false;
		}

		public Tile GetTile(Coordinate coord)
		{
			return null;
		}

		[Button]
		public void SetVisible()
		{
		}

		[Button]
		public void SetInvisible()
		{
		}
	}
}
