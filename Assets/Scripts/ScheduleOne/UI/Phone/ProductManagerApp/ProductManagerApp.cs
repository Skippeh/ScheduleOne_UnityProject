namespace ScheduleOne.UI.Phone.ProductManagerApp
{
	public class ProductManagerApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp>
	{
		[global::System.Serializable]
		public class ProductTypeContainer
		{
			public global::ScheduleOne.Product.EDrugType DrugType;

			public global::UnityEngine.RectTransform Container;

			public global::UnityEngine.RectTransform NoneDisplay;

			public void RefreshNoneDisplay()
			{
			}
		}

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp.ProductTypeContainer FavouritesContainer;

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp.ProductTypeContainer> ProductTypeContainers;

		public global::ScheduleOne.UI.Phone.ProductManagerApp.ProductAppDetailPanel DetailPanel;

		public global::UnityEngine.RectTransform SelectionIndicator;

		public global::UnityEngine.GameObject EntryPrefab;

		private global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductEntry> favouriteEntries;

		private global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductEntry> entries;

		private global::ScheduleOne.Product.ProductEntry selectedEntry;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public virtual void CreateEntry(global::ScheduleOne.Product.ProductDefinition definition)
		{
		}

		private void ProductFavourited(global::ScheduleOne.Product.ProductDefinition product)
		{
		}

		private void ProductUnfavourited(global::ScheduleOne.Product.ProductDefinition product)
		{
		}

		private void CreateFavouriteEntry(global::ScheduleOne.Product.ProductDefinition definition)
		{
		}

		private void RemoveFavouriteEntry(global::ScheduleOne.Product.ProductDefinition definition)
		{
		}

		private void DelayedRebuildLayout()
		{
		}

		public void SelectProduct(global::ScheduleOne.Product.ProductEntry entry)
		{
		}

		public override void SetOpen(bool open)
		{
		}
	}
}
