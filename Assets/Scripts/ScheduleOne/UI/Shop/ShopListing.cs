using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.UI.Shop
{
	[Serializable]
	public class ShopListing
	{
		[Serializable]
		public class CategoryInstance
		{
			public EShopCategory Category;
		}

		public enum ERestockRate
		{
			Daily = 0,
			Weekly = 1,
			Never = 2
		}

		public string name;

		public StorableItemDefinition Item;

		[Header("Pricing")]
		[SerializeField]
		protected bool OverridePrice;

		[SerializeField]
		protected float OverriddenPrice;

		[Header("Stock")]
		public bool LimitedStock;

		public int DefaultStock;

		public ERestockRate RestockRate;

		[Header("Settings")]
		public bool EnforceMinimumGameCreationVersion;

		public float MinimumGameCreationVersion;

		public bool CanBeDelivered;

		[Header("Color")]
		public bool UseIconTint;

		public Color IconTint;

		public Action onStockChanged;

		public bool IsInStock => false;

		public float Price => 0f;

		public bool IsUnlimitedStock => false;

		public ShopInterface Shop { get; private set; }

		public int CurrentStock { get; protected set; }

		public int QuantityInCart { get; private set; }

		public int CurrentStockMinusCart => 0;

		public void Initialize(ShopInterface shop)
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

		public virtual bool ShouldShow()
		{
			return false;
		}

		public virtual bool DoesListingMatchCategoryFilter(EShopCategory category)
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
