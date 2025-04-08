namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class ProductManagerData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string[] DiscoveredProducts;

		public string[] ListedProducts;

		public global::ScheduleOne.Product.NewMixOperation ActiveMixOperation;

		public bool IsMixComplete;

		public global::ScheduleOne.Product.MixRecipeData[] MixRecipes;

		public global::ScheduleOne.DevUtilities.StringIntPair[] ProductPrices;

		public string[] FavouritedProducts;

		public ProductManagerData(string[] discoveredProducts, string[] listedProducts, global::ScheduleOne.Product.NewMixOperation activeOperation, bool isMixComplete, global::ScheduleOne.Product.MixRecipeData[] mixRecipes, global::ScheduleOne.DevUtilities.StringIntPair[] productPrices, string[] favouritedProducts)
		{
		}
	}
}
