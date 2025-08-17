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

		public enum ERestockRate
		{
			Daily = 0,
			Weekly = 1,
			Never = 2
		}

		public string name;

		public global::ScheduleOne.ItemFramework.StorableItemDefinition Item;

		[global::UnityEngine.Header("Pricing")]
		[global::UnityEngine.SerializeField]
		protected bool OverridePrice;

		[global::UnityEngine.SerializeField]
		protected float OverriddenPrice;

		[global::UnityEngine.Header("Stock")]
		public bool LimitedStock;

		public int DefaultStock;

		public global::ScheduleOne.UI.Shop.ShopListing.ERestockRate RestockRate;

		public bool TieStockToNumberVariable;

		public string StockVariableName;

		[global::UnityEngine.Header("Purchase Tracking")]
		public bool TrackPurchases;

		public string PurchasedQuantityVariableName;

		[global::UnityEngine.Header("Settings")]
		public bool EnforceMinimumGameCreationVersion;

		public float MinimumGameCreationVersion;

		public bool CanBeDelivered;

		[global::UnityEngine.Header("Color")]
		public bool UseIconTint;

		public global::UnityEngine.Color IconTint;

		public global::System.Action onStockChanged;

		private global::ScheduleOne.Variables.NumberVariable stockVariable;

		private global::ScheduleOne.Variables.NumberVariable purchasedQuantityVariable;

		public bool IsInStock => false;

		public float Price => 0f;

		public bool IsUnlimitedStock => false;

		public global::ScheduleOne.UI.Shop.ShopInterface Shop { get; private set; }

		public int CurrentStock { get; protected set; }

		public int QuantityInCart { get; private set; }

		public int CurrentStockMinusCart => 0;

		public void Initialize(global::ScheduleOne.UI.Shop.ShopInterface shop)
		{
		}

		public void Restock(bool network)
		{
		}

		public void RemoveStock(int quantity)
		{
		}

		public void SetStock(int quantity, bool network = true)
		{
		}

		public void PullStockFromVariable()
		{
		}

		private void StockVariableChanged(float newValue)
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

		public void SetQuantityInCart(int quantity)
		{
		}
	}
}
