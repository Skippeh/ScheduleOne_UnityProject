using System;
using ScheduleOne.ItemFramework;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class PlaceableStorageData : GridItemData
	{
		public ItemSet Contents;

		public PlaceableStorageData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents)
			: base(default(Guid), null, 0, null, default(Vector2), 0)
		{
		}
	}
}
