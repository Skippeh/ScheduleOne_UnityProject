using System;
using System.Collections.Generic;
using ScheduleOne.Levelling;
using ScheduleOne.StationFramework;
using ScheduleOne.Storage;
using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "StorableItemDefinition", menuName = "ScriptableObjects/StorableItemDefinition", order = 1)]
	public class StorableItemDefinition : ItemDefinition
	{
		[Header("Purchasing")]
		public float BasePurchasePrice;

		public List<ShopListing.CategoryInstance> ShopCategories;

		public bool RequiresLevelToPurchase;

		public FullRank RequiredRank;

		[Header("Reselling")]
		[Range(0f, 1f)]
		public float ResellMultiplier;

		[Header("Storable Item")]
		public StoredItem StoredItem;

		[Tooltip("Optional station item if this item can be used at a station.")]
		public StationItem StationItem;

		public bool IsPurchasable => false;

		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
