using System;
using ScheduleOne.ItemFramework;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Persistence.Datas
{
	public class LabOvenData : GridItemData
	{
		public ItemSet InputContents;

		public ItemSet OutputContents;

		public string CurrentIngredientID;

		public int CurrentIngredientQuantity;

		public EQuality CurrentIngredientQuality;

		public string CurrentProductID;

		public int CurrentCookProgress;

		public LabOvenData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string ingredientID, int currentIngredientQuantity, EQuality ingredientQuality, string productID, int currentCookProgress)
			: base(default(Guid), null, 0, null, default(Vector2), 0)
		{
		}
	}
}
