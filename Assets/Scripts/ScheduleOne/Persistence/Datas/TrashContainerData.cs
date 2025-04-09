using System;
using ScheduleOne.ItemFramework;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Persistence.Datas
{
	public class TrashContainerData : GridItemData
	{
		public TrashContentData ContentData;

		public TrashContainerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, TrashContentData contentData)
			: base(default(Guid), null, 0, null, default(Vector2), 0)
		{
		}
	}
}
