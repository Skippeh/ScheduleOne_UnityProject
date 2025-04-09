using System;
using ScheduleOne.ItemFramework;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Persistence.Datas
{
	public class ToggleableItemData : GridItemData
	{
		public bool IsOn;

		public ToggleableItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, bool isOn)
			: base(default(Guid), null, 0, null, default(Vector2), 0)
		{
		}
	}
}
