using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.Audio;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Storage;
using ScheduleOne.Vehicles;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	public class ShopInterface : MonoBehaviour, ISaveable
	{
		public enum EPaymentType
		{
			Cash = 0,
			Online = 1,
			PreferCash = 2,
			PreferOnline = 3
		}

		public static List<ShopInterface> AllShops;

		public const int MAX_ITEM_QUANTITY = 999;

		[Header("Settings")]
		public string ShopName;

		public string ShopCode;

		public EPaymentType PaymentType;

		public bool ShowCurrencyHint;

		[Header("Listings")]
		public List<ShopListing> Listings;

		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public RectTransform ListingContainer;

		public TextMeshProUGUI StoreNameLabel;

		public Cart Cart;

		public StorageEntity[] DeliveryBays;

		public VehicleDetector LoadingBayDetector;

		public ShopInterfaceDetailPanel DetailPanel;

		public ScrollRect ListingScrollRect;

		public ShopAmountSelector AmountSelector;

		public DeliveryVehicle DeliveryVehicle;

		[Header("Audio")]
		public AudioSourceController AddItemSound;

		public AudioSourceController RemoveItemSound;

		public AudioSourceController CheckoutSound;

		[Header("Prefabs")]
		public ListingUI ListingUIPrefab;

		public UnityEvent onOrderCompleted;

		[SerializeField]
		private List<CategoryButton> categoryButtons;

		private EShopCategory categoryFilter;

		private string searchTerm;

		private List<ListingUI> listingUI;

		private ListingUI selectedListing;

		private bool dropdownMouseUp;

		private ShopLoader loader;

		public bool IsOpen { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}

		protected virtual void Update()
		{
		}

		protected void OnDayPass()
		{
		}

		protected void OnWeekPass()
		{
		}

		[Button]
		public void Open()
		{
		}

		public virtual void SetIsOpen(bool isOpen)
		{
		}

		private void Hint()
		{
		}

		protected virtual void Exit(ExitAction action)
		{
		}

		private void CreateListingUI(ShopListing listing)
		{
		}

		public void SelectCategory(EShopCategory category)
		{
		}

		public virtual void ListingClicked(ListingUI listingUI)
		{
		}

		private void ShowCartAnimation(ListingUI listing)
		{
		}

		public void CategorySelected(EShopCategory category)
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

		public bool CanCartFitItem(ShopListing listing)
		{
			return false;
		}

		public bool WillCartFit()
		{
			return false;
		}

		public bool WillCartFit(List<ItemSlot> availableSlots)
		{
			return false;
		}

		public virtual bool HandoverItems()
		{
			return false;
		}

		public List<ItemSlot> GetAvailableSlots()
		{
			return null;
		}

		public LandVehicle GetLoadingBayVehicle()
		{
			return null;
		}

		public void PlaceItemInDeliveryBay(ItemInstance item)
		{
		}

		public void QuantitySelected(int amount)
		{
		}

		public void OpenAmountSelector(ListingUI listing)
		{
		}

		private void DropdownClicked(ListingUI listing)
		{
		}

		private void EntryHovered(ListingUI listing)
		{
		}

		private void EntryUnhovered()
		{
		}

		public void Load(ShopData data)
		{
		}

		public bool ShouldSave()
		{
			return false;
		}

		public ShopListing GetListing(string itemID)
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}
	}
}
