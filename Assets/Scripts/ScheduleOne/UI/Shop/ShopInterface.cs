namespace ScheduleOne.UI.Shop
{
	public class ShopInterface : global::UnityEngine.MonoBehaviour, global::ScheduleOne.Persistence.ISaveable
	{
		public enum EPaymentType
		{
			Cash = 0,
			Online = 1,
			PreferCash = 2,
			PreferOnline = 3
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRefreshShownItemsNextFrame_003Ed__86 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Shop.ShopInterface _003C_003E4__this;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CRefreshShownItemsNextFrame_003Ed__86(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		public static global::System.Collections.Generic.List<global::ScheduleOne.UI.Shop.ShopInterface> AllShops;

		public const int MAX_ITEM_QUANTITY = 999;

		[global::UnityEngine.Header("Settings")]
		public string ShopName;

		public string ShopCode;

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

		[global::UnityEngine.Header("Custom UI")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UIScreen shopScreen;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UIPanel listingPanel;

		[global::UnityEngine.Header("Add To Cart Popup Values")]
		[global::UnityEngine.SerializeField]
		private int defaultAddToCartAmount;

		[global::UnityEngine.SerializeField]
		private int minAddToCartAmount;

		[global::UnityEngine.SerializeField]
		private int addToCartTier1Amount;

		[global::UnityEngine.SerializeField]
		private int addToCartTier2Amount;

		[global::UnityEngine.SerializeField]
		private int addToCartTier3Amount;

		[global::UnityEngine.Header("Modify Cart Popup Values")]
		public int minModifyAmount;

		public int modifyTier1Amount;

		public int modifyTier2Amount;

		public int modifyTier3Amount;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Shop.CategoryButton> categoryButtons;

		private global::ScheduleOne.UI.Shop.EShopCategory categoryFilter;

		private string searchTerm;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Shop.ListingUI> listingUI;

		private global::ScheduleOne.UI.Shop.ListingUI selectedListing;

		private bool amountSelectorMouseUp;

		private global::ScheduleOne.Persistence.Loaders.ShopLoader loader;

		public bool IsOpen { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

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

		[global::ScheduleOne.Core.Button]
		public void Open()
		{
		}

		public virtual void SetIsOpen(bool isOpen)
		{
		}

		private void Exit()
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

		public void CategorySelected(global::ScheduleOne.UI.Shop.EShopCategory category)
		{
		}

		private void PullStockVariables()
		{
		}

		private void DeselectCurrentCategory()
		{
		}

		private void RefreshShownItems()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Shop.ShopInterface._003CRefreshShownItemsNextFrame_003Ed__86))]
		private global::System.Collections.IEnumerator RefreshShownItemsNextFrame()
		{
			return null;
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

		private void QuantitySelectedNew(int amount)
		{
		}

		private void EntryHovered(global::ScheduleOne.UI.Shop.ListingUI listing)
		{
		}

		private void EntryUnhovered()
		{
		}

		public void Load(global::ScheduleOne.Persistence.Datas.ShopData data)
		{
		}

		public bool ShouldSave()
		{
			return false;
		}

		public global::ScheduleOne.UI.Shop.ShopListing GetListing(string itemID)
		{
			return null;
		}

		public virtual global::ScheduleOne.Persistence.Datas.ShopData GetSaveData()
		{
			return null;
		}

		public string GetSaveString()
		{
			return null;
		}
	}
}
