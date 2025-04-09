using System;
using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.EntityFramework;
using ScheduleOne.Lighting;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	[Serializable]
	public class Tile : MonoBehaviour
	{
		public delegate void TileChange(Tile thisTile);

		public static float TileSize;

		public int x;

		public int y;

		[Header("Settings")]
		public float AvailableOffset;

		[Header("References")]
		public Grid OwnerGrid;

		public LightExposureNode LightExposureNode;

		[Header("Occupants")]
		public List<GridItem> BuildableOccupants;

		public List<Constructable_GridBased> ConstructableOccupants;

		public List<FootprintTile> OccupantTiles;

		public TileChange onTileChanged;

		public void InitializePropertyTile(int _x, int _y, float _available_Offset, Grid _ownerGrid)
		{
		}

		public void AddOccupant(GridItem occ, FootprintTile tile)
		{
		}

		public void AddOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
		}

		public void RemoveOccupant(GridItem occ, FootprintTile tile)
		{
		}

		public void RemoveOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
		}

		public virtual bool CanBeBuiltOn()
		{
			return false;
		}

		public List<Tile> GetSurroundingTiles()
		{
			return null;
		}

		public virtual bool IsIndoorTile()
		{
			return false;
		}

		public void SetVisible(bool vis)
		{
		}
	}
}
