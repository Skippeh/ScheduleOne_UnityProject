namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "StorableItemDefinition", menuName = "ScriptableObjects/StorableItemDefinition", order = 1)]
	public class StorableItemDefinition : global::ScheduleOne.ItemFramework.ItemDefinition
	{
		[global::UnityEngine.Header("Purchasing")]
		public float BasePurchasePrice;

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.Shop.ShopListing.CategoryInstance> ShopCategories;

		public bool RequiresLevelToPurchase;

		public global::ScheduleOne.Levelling.FullRank RequiredRank;

		[global::UnityEngine.Header("Reselling")]
		[global::UnityEngine.Range(0f, 1f)]
		public float ResellMultiplier;

		[global::UnityEngine.Header("Storable Item")]
		public global::ScheduleOne.Storage.StoredItem StoredItem;

		[global::UnityEngine.Tooltip("Optional station item if this item can be used at a station.")]
		public global::ScheduleOne.StationFramework.StationItem StationItem;

		[global::UnityEngine.Header("Other Settings")]
		[global::UnityEngine.Range(0f, 1f)]
		public float CombatUtilityForNPCs;

		public bool IsPurchasable => false;

		public override global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
