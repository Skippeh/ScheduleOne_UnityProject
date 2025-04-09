using System.Collections.Generic;
using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	public class DeliveryShop : MonoBehaviour
	{
		public const int DELIVERY_VEHICLE_SLOT_CAPACITY = 16;

		public const int DELIVERY_TIME_MIN = 60;

		public const int DELIVERY_TIME_MAX = 360;

		public const int DELIVERY_TIME_ITEM_COUNT_DIVISOR = 160;

		[Header("References")]
		public Image HeaderImage;

		public Button HeaderButton;

		public RectTransform ContentsContainer;

		public RectTransform ListingContainer;

		public Text DeliveryFeeLabel;

		public Text ItemTotalLabel;

		public Text OrderTotalLabel;

		public Button OrderButton;

		public Text OrderButtonNote;

		public Dropdown DestinationDropdown;

		public Dropdown LoadingDockDropdown;

		[Header("Settings")]
		public string MatchingShopInterfaceName;

		public float DeliveryFee;

		public bool AvailableByDefault;

		public ListingEntry ListingEntryPrefab;

		public Sprite HeaderImage_Hidden;

		public Sprite HeaderImage_Expanded;

		public RectTransform HeaderArrow;

		private List<ListingEntry> listingEntries;

		private ScheduleOne.Property.Property destinationProperty;

		private int loadingDockIndex;

		public ShopInterface MatchingShop { get; private set; }

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

		private List<ScheduleOne.Property.Property> GetPotentialDestinations()
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
