namespace ScheduleOne.ObjectScripts
{
	[global::System.Serializable]
	public class OvenCookOperation
	{
		[global::FishNet.Serializing.Helping.CodegenExclude]
		private global::ScheduleOne.ItemFramework.StorableItemDefinition _itemDefinition;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		private global::ScheduleOne.ItemFramework.StorableItemDefinition _productionDefinition;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		private global::ScheduleOne.StationFramework.CookableModule _cookable;

		public string IngredientID;

		public global::ScheduleOne.ItemFramework.EQuality IngredientQuality;

		public int IngredientQuantity;

		public string ProductID;

		public int CookProgress;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		private int cookDuration;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.ItemFramework.StorableItemDefinition Ingredient => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.ItemFramework.StorableItemDefinition Product => null;

		[global::FishNet.Serializing.Helping.CodegenExclude]
		public global::ScheduleOne.StationFramework.CookableModule Cookable => null;

		public OvenCookOperation(string ingredientID, global::ScheduleOne.ItemFramework.EQuality ingredientQuality, int ingredientQuantity, string productID)
		{
		}

		public OvenCookOperation(string ingredientID, global::ScheduleOne.ItemFramework.EQuality ingredientQuality, int ingredientQuantity, string productID, int progress)
		{
		}

		public OvenCookOperation()
		{
		}

		public void UpdateCookProgress(int change)
		{
		}

		public int GetCookDuration()
		{
			return 0;
		}

		public bool IsComplete()
		{
			return false;
		}

		public global::ScheduleOne.ItemFramework.ItemInstance GetProductItem(int quantity)
		{
			return null;
		}

		public bool IsReady()
		{
			return false;
		}
	}
}
