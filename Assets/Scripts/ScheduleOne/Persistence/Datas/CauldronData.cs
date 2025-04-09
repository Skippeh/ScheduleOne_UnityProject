using System;
using ScheduleOne.ItemFramework;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Persistence.Datas
{
	public class CauldronData : GridItemData
	{
		public ItemSet Ingredients;

		public ItemSet Liquid;

		public ItemSet Output;

		public int RemainingCookTime;

		public EQuality InputQuality;

		public CauldronData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet ingredients, ItemSet liquid, ItemSet output, int remainingCookTime, EQuality inputQuality)
			: base(default(Guid), null, 0, null, default(Vector2), 0)
		{
		}
	}
}
