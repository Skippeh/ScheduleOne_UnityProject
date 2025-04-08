namespace ScheduleOne.UI.Shop
{
	[global::System.Serializable]
	public class ShopListing
	{
		[global::System.Serializable]
		public class CategoryInstance
		{
			public global::ScheduleOne.UI.Shop.EShopCategory Category;
		}

		public string name;

		public global::ScheduleOne.ItemFramework.StorableItemDefinition Item;

		[global::UnityEngine.Header("Pricing")]
		[global::UnityEngine.SerializeField]
		protected bool OverridePrice;

		[global::UnityEngine.SerializeField]
		protected float OverriddenPrice;

		[global::UnityEngine.Header("Stock")]
		public int StockQuantity;

		[global::UnityEngine.Header("Settings")]
		public bool EnforceMinimumGameCreationVersion;

		public float MinimumGameCreationVersion;

		public bool CanBeDelivered;

		public global::System.Action onQuantityChanged;

		public bool IsInStock => false;

		public float Price => 0f;

		public int CurrentQuantity { get; protected set; }

		public void Restock()
		{
		}

		public virtual bool ShouldShow()
		{
			return false;
		}

		public virtual bool DoesListingMatchCategoryFilter(global::ScheduleOne.UI.Shop.EShopCategory category)
		{
			return false;
		}

		public virtual bool DoesListingMatchSearchTerm(string searchTerm)
		{
			return false;
		}
	}
}
