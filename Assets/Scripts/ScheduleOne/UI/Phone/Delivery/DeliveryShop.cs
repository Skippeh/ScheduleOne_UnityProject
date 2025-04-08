namespace ScheduleOne.UI.Phone.Delivery
{
	public class DeliveryShop : global::UnityEngine.MonoBehaviour
	{
		public const int DELIVERY_VEHICLE_SLOT_CAPACITY = 16;

		public const int DELIVERY_TIME_MIN = 60;

		public const int DELIVERY_TIME_MAX = 360;

		public const int DELIVERY_TIME_ITEM_COUNT_DIVISOR = 160;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image HeaderImage;

		public global::UnityEngine.UI.Button HeaderButton;

		public global::UnityEngine.RectTransform ContentsContainer;

		public global::UnityEngine.RectTransform ListingContainer;

		public global::UnityEngine.UI.Text DeliveryFeeLabel;

		public global::UnityEngine.UI.Text ItemTotalLabel;

		public global::UnityEngine.UI.Text OrderTotalLabel;

		public global::UnityEngine.UI.Button OrderButton;

		public global::UnityEngine.UI.Text OrderButtonNote;

		public global::UnityEngine.UI.Dropdown DestinationDropdown;

		public global::UnityEngine.UI.Dropdown LoadingDockDropdown;

		[global::UnityEngine.Header("Settings")]
		public string MatchingShopInterfaceName;

		public float DeliveryFee;

		public bool AvailableByDefault;

		public global::ScheduleOne.UI.Phone.Delivery.ListingEntry ListingEntryPrefab;

		public global::UnityEngine.Sprite HeaderImage_Hidden;

		public global::UnityEngine.Sprite HeaderImage_Expanded;

		public global::UnityEngine.RectTransform HeaderArrow;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Delivery.ListingEntry> listingEntries;

		private global::ScheduleOne.Property.Property destinationProperty;

		private int loadingDockIndex;

		public global::ScheduleOne.UI.Shop.ShopInterface MatchingShop { get; private set; }

		public bool IsExpanded { get; private set; }

		public bool IsAvailable { get; private set; }

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		public void SetIsExpanded(bool expanded)
		{
		}

		public void SetIsAvailable()
		{
		}

		public void OrderPressed()
		{
		}

		public void RefreshShop()
		{
		}

		public void ResetCart()
		{
		}

		private void RefreshCart()
		{
		}

		private void RefreshOrderButton()
		{
		}

		public bool CanOrder(out string reason)
		{
			reason = null;
			return false;
		}

		public bool HasActiveDelivery()
		{
			return false;
		}

		public bool WillCartFitInVehicle()
		{
			return false;
		}

		public void RefreshDestinationUI()
		{
		}

		private void DestinationDropdownSelected(int index)
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Property.Property> GetPotentialDestinations()
		{
			return null;
		}

		public void RefreshLoadingDockUI()
		{
		}

		private void LoadingDockDropdownSelected(int index)
		{
		}

		private float GetCartCost()
		{
			return 0f;
		}

		private float GetOrderTotal()
		{
			return 0f;
		}

		private int GetOrderItemCount()
		{
			return 0;
		}

		private void RefreshEntryOrder()
		{
		}

		private void RefreshEntriesLocked()
		{
		}
	}
}
