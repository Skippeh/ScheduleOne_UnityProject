using System;
using ScheduleOne.ItemFramework;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class GridItemData : BuildableItemData
	{
		public string GridGUID;

		public Vector2 OriginCoordinate;

		public int Rotation;

		public GridItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation)
			: base(default(Guid), null, 0)
		{
		}
	}
}
