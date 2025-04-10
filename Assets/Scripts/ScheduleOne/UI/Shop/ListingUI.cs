namespace ScheduleOne.UI.Shop
{
	public class ListingUI : global::UnityEngine.MonoBehaviour
	{
		public static global::UnityEngine.Color32 PriceLabelColor_Normal;

		public static global::UnityEngine.Color32 PriceLabelColor_NoStock;

		[global::UnityEngine.Header("Colors")]
		public global::UnityEngine.Color32 StockLabelDefault;

		public global::UnityEngine.Color32 StockLabelNone;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image Icon;

		public global::TMPro.TextMeshProUGUI NameLabel;

		public global::TMPro.TextMeshProUGUI PriceLabel;

		public global::TMPro.TextMeshProUGUI StockLabel;

		public global::UnityEngine.GameObject LockedContainer;

		public global::UnityEngine.UI.Button BuyButton;

		public global::UnityEngine.UI.Button DropdownButton;

		public global::UnityEngine.EventSystems.EventTrigger Trigger;

		public global::UnityEngine.RectTransform DetailPanelAnchor;

		public global::UnityEngine.RectTransform DropdownAnchor;

		public global::UnityEngine.RectTransform TopDropdownAnchor;

		public global::System.Action hoverStart;

		public global::System.Action hoverEnd;

		public global::System.Action onClicked;

		public global::System.Action onDropdownClicked;

		public global::ScheduleOne.UI.Shop.ShopListing Listing { get; protected set; }

		public virtual void Initialize(global::ScheduleOne.UI.Shop.ShopListing listing)
		{
		}

		public virtual global::UnityEngine.RectTransform GetIconCopy(global::UnityEngine.RectTransform parent)
		{
			return null;
		}

		public void Update()
		{
		}

		private void Clicked()
		{
		}

		private void DropdownClicked()
		{
		}

		private void HoverStart()
		{
		}

		private void HoverEnd()
		{
		}

		private void StockChanged()
		{
		}

		private void UpdatePrice()
		{
		}

		private void UpdateStock()
		{
		}

		private void UpdateButtons()
		{
		}

		public bool CanAddToCart()
		{
			return false;
		}

		public void UpdateLockStatus()
		{
		}
	}
}
