using System;
using ScheduleOne.ItemFramework;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Persistence.Datas
{
	public class PotData : GridItemData
	{
		public string SoilID;

		public float SoilLevel;

		public int RemainingSoilUses;

		public float WaterLevel;

		public string[] AppliedAdditives;

		public PlantData PlantData;

		public PotData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, string[] appliedAdditives, PlantData plantData)
			: base(default(Guid), null, 0, null, default(Vector2), 0)
		{
		}
	}
}
