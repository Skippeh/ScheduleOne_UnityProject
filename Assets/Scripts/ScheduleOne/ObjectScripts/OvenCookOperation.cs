using System;
using FishNet.Serializing.Helping;
using ScheduleOne.ItemFramework;
using ScheduleOne.StationFramework;

namespace ScheduleOne.ObjectScripts
{
	[Serializable]
	public class OvenCookOperation
	{
		[CodegenExclude]
		private StorableItemDefinition _itemDefinition;

		[CodegenExclude]
		private StorableItemDefinition _productionDefinition;

		[CodegenExclude]
		private CookableModule _cookable;

		public string IngredientID;

		public EQuality IngredientQuality;

		public int IngredientQuantity;

		public string ProductID;

		public int CookProgress;

		[CodegenExclude]
		private int cookDuration;

		[CodegenExclude]
		public StorableItemDefinition Ingredient => null;

		[CodegenExclude]
		public StorableItemDefinition Product => null;

		[CodegenExclude]
		public CookableModule Cookable => null;

		public OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID)
		{
		}

		public OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID, int progress)
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

		public ItemInstance GetProductItem(int quantity)
		{
			return null;
		}

		public bool IsReady()
		{
			return false;
		}
	}
}
