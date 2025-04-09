using System.Collections.Generic;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	public class ProceduralTile : MonoBehaviour
	{
		public enum EProceduralTileType
		{
			Rack = 0
		}

		[Header("Settings")]
		public EProceduralTileType TileType;

		[Header("References")]
		public BuildableItem ParentBuildableItem;

		public FootprintTile MatchedFootprintTile;

		[Header("Occupants")]
		public List<ProceduralGridItem> Occupants;

		public List<FootprintTile> OccupantTiles;

		protected virtual void Awake()
		{
		}

		public void AddOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
		}

		public void RemoveOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
		}
	}
}
