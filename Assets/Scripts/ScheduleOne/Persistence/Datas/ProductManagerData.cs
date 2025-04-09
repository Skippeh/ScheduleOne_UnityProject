using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class ProductManagerData : SaveData
	{
		public string[] DiscoveredProducts;

		public string[] ListedProducts;

		public NewMixOperation ActiveMixOperation;

		public bool IsMixComplete;

		public MixRecipeData[] MixRecipes;

		public StringIntPair[] ProductPrices;

		public string[] FavouritedProducts;

		public ProductManagerData(string[] discoveredProducts, string[] listedProducts, NewMixOperation activeOperation, bool isMixComplete, MixRecipeData[] mixRecipes, StringIntPair[] productPrices, string[] favouritedProducts)
		{
		}
	}
}
