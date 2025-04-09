using System;
using System.Collections.Generic;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.UI.Phone.ProductManagerApp
{
	public class ProductManagerApp : App<ProductManagerApp>
	{
		[Serializable]
		public class ProductTypeContainer
		{
			public EDrugType DrugType;

			public RectTransform Container;

			public RectTransform NoneDisplay;

			public void RefreshNoneDisplay()
			{
			}
		}

		[Header("References")]
		public ProductTypeContainer FavouritesContainer;

		public List<ProductTypeContainer> ProductTypeContainers;

		public ProductAppDetailPanel DetailPanel;

		public RectTransform SelectionIndicator;

		public GameObject EntryPrefab;

		private List<ProductEntry> favouriteEntries;

		private List<ProductEntry> entries;

		private ProductEntry selectedEntry;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public virtual void CreateEntry(ProductDefinition definition)
		{
		}

		private void ProductFavourited(ProductDefinition product)
		{
		}

		private void ProductUnfavourited(ProductDefinition product)
		{
		}

		private void CreateFavouriteEntry(ProductDefinition definition)
		{
		}

		private void RemoveFavouriteEntry(ProductDefinition definition)
		{
		}

		private void DelayedRebuildLayout()
		{
		}

		public void SelectProduct(ProductEntry entry)
		{
		}

		public override void SetOpen(bool open)
		{
		}
	}
}
