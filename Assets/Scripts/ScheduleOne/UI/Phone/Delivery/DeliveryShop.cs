namespace ScheduleOne.UI.Phone.Delivery
{
	public class DeliveryShop : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Button BackButton;

		public global::UnityEngine.RectTransform ListingContainer;

		public global::UnityEngine.UI.Text DeliveryFeeLabel;

		public global::UnityEngine.UI.Text ItemTotalLabel;

		public global::UnityEngine.UI.Text OrderTotalLabel;

		public global::UnityEngine.UI.Text DeliveryTimeLabel;

		public global::UnityEngine.UI.Button OrderButton;

		public global::UnityEngine.UI.Text OrderButtonNote;

		public global::UnityEngine.UI.Dropdown DestinationDropdown;

		public global::UnityEngine.UI.Dropdown LoadingDockDropdown;

		[global::UnityEngine.Header("Settings")]
		public string MatchingShopInterfaceName;

		public global::UnityEngine.Color ShopColor;

		public bool AvailableByDefault;

		public global::ScheduleOne.UI.Phone.Delivery.ListingEntry ListingEntryPrefab;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Delivery.ListingEntry> listingEntries;

		private global::ScheduleOne.Property.Property destinationProperty;

		private int loadingDockIndex;

		private global::System.Action<global::ScheduleOne.UI.Phone.Delivery.DeliveryShop> _onSelect;

		public global::ScheduleOne.UI.Shop.ShopInterface MatchingShop { get; private set; }

		public bool IsOpen { get; private set; }

		public global::System.Action<global::ScheduleOne.UI.Phone.Delivery.DeliveryShop> OnSelect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Initialize()
		{
		}

		private void FixedUpdate()
		{
		}

		public void Open()
		{
		}

		public void Close()
		{
		}

		public void SubmitOrder(string originalDeliveryID)
		{
		}

		private int GetDeliveryTime(int itemCount)
		{
			return 0;
		}

		public void Reorder(global::ScheduleOne.Delivery.DeliveryReceipt receipt)
		{
		}

		public bool CanReorder(global::ScheduleOne.Delivery.DeliveryReceipt receipt, out string reason)
		{
			reason = null;
			return false;
		}

		public float GetDeliveryCost(global::ScheduleOne.Delivery.DeliveryReceipt receipt)
		{
			return 0f;
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

		private float GetDeliveryFee()
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
