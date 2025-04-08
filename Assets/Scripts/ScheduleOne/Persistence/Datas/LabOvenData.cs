namespace ScheduleOne.Persistence.Datas
{
	public class LabOvenData : global::ScheduleOne.Persistence.Datas.GridItemData
	{
		public global::ScheduleOne.Persistence.Datas.ItemSet InputContents;

		public global::ScheduleOne.Persistence.Datas.ItemSet OutputContents;

		public string CurrentIngredientID;

		public int CurrentIngredientQuantity;

		public global::ScheduleOne.ItemFramework.EQuality CurrentIngredientQuality;

		public string CurrentProductID;

		public int CurrentCookProgress;

		public LabOvenData(global::System.Guid guid, global::ScheduleOne.ItemFramework.ItemInstance item, int loadOrder, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, global::ScheduleOne.Persistence.Datas.ItemSet inputContents, global::ScheduleOne.Persistence.Datas.ItemSet outputContents, string ingredientID, int currentIngredientQuantity, global::ScheduleOne.ItemFramework.EQuality ingredientQuality, string productID, int currentCookProgress)
			: base(default(global::System.Guid), null, 0, null, default(global::UnityEngine.Vector2), 0)
		{
		}
	}
}
