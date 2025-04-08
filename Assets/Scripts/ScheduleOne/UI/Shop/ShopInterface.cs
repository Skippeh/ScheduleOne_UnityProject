namespace ScheduleOne.UI.Shop
{
	public class ShopInterface : global::UnityEngine.MonoBehaviour
	{
		public enum EPaymentType
		{
			Cash = 0,
			Online = 1,
			PreferCash = 2,
			PreferOnline = 3
		}

		public const int MAX_ITEM_QUANTITY = 999;

		[global::UnityEngine.Header("Settings")]
		public string ShopName;

		public global::ScheduleOne.UI.Shop.ShopInterface.EPaymentType PaymentType;

		public bool ShowCurrencyHint;

		[global::UnityEngine.Header("Listings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.UI.Shop.ShopListing> Listings;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.RectTransform ListingContainer;

		public global::TMPro.TextMeshProUGUI StoreNameLabel;

		public global::ScheduleOne.UI.Shop.Cart Cart;

		public global::ScheduleOne.Storage.StorageEntity[] DeliveryBays;

		public global::ScheduleOne.DevUtilities.VehicleDetector LoadingBayDetector;

		public global::ScheduleOne.UI.Shop.ShopInterfaceDetailPanel DetailPanel;

		public global::UnityEngine.UI.ScrollRect ListingScrollRect;

		public global::ScheduleOne.UI.Shop.ShopAmountSelector AmountSelector;

		public global::ScheduleOne.Delivery.DeliveryVehicle DeliveryVehicle;

		[global::UnityEngine.Header("Audio")]
		public global::ScheduleOne.Audio.AudioSourceController AddItemSound;

		public global::ScheduleOne.Audio.AudioSourceController RemoveItemSound;

		public global::ScheduleOne.Audio.AudioSourceController CheckoutSound;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.UI.Shop.ListingUI ListingUIPrefab;

		public global::UnityEngine.Events.UnityEvent onOrderCompleted;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Shop.CategoryButton> categoryButtons;

		private global::ScheduleOne.UI.Shop.EShopCategory categoryFilter;

		private string searchTerm;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Shop.ListingUI> listingUI;

		private global::ScheduleOne.UI.Shop.ListingUI selectedListing;

		private bool dropdownMouseUp;

		public bool IsOpen { get; protected set; }

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnValidate()
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void SetIsOpen(bool isOpen)
		{
		}

		private void Hint()
		{
		}

		protected virtual void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void CreateListingUI(global::ScheduleOne.UI.Shop.ShopListing listing)
		{
		}

		public void SelectCategory(global::ScheduleOne.UI.Shop.EShopCategory category)
		{
		}

		public virtual void ListingClicked(global::ScheduleOne.UI.Shop.ListingUI listingUI)
		{
		}

		private void ShowCartAnimation(global::ScheduleOne.UI.Shop.ListingUI listing)
		{
		}

		public void CategorySelected(global::ScheduleOne.UI.Shop.EShopCategory category)
		{
		}

		private void DeselectCurrentCategory()
		{
		}

		private void RefreshShownItems()
		{
		}

		private void RefreshUnlockStatus()
		{
		}

		private void RestockAllListings()
		{
		}

		public bool CanCartFitItem(global::ScheduleOne.UI.Shop.ShopListing listing)
		{
			return false;
		}

		public bool WillCartFit()
		{
			return false;
		}

		public bool WillCartFit(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> availableSlots)
		{
			return false;
		}

		public virtual bool HandoverItems()
		{
			return false;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> GetAvailableSlots()
		{
			return null;
		}

		public global::ScheduleOne.Vehicles.LandVehicle GetLoadingBayVehicle()
		{
			return null;
		}

		public void PlaceItemInDeliveryBay(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public void QuantitySelected(int amount)
		{
		}

		public void OpenAmountSelector(global::ScheduleOne.UI.Shop.ListingUI listing)
		{
		}

		private void DropdownClicked(global::ScheduleOne.UI.Shop.ListingUI listing)
		{
		}

		private void EntryHovered(global::ScheduleOne.UI.Shop.ListingUI listing)
		{
		}

		private void EntryUnhovered()
		{
		}
	}
}
