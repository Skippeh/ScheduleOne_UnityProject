using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	public class ListingUI : MonoBehaviour
	{
		public static Color32 PriceLabelColor_Normal;

		public static Color32 PriceLabelColor_NoStock;

		[Header("Colors")]
		public Color32 StockLabelDefault;

		public Color32 StockLabelNone;

		[Header("References")]
		public Image Icon;

		public TextMeshProUGUI NameLabel;

		public TextMeshProUGUI PriceLabel;

		public TextMeshProUGUI StockLabel;

		public GameObject LockedContainer;

		public Button BuyButton;

		public Button DropdownButton;

		public EventTrigger Trigger;

		public RectTransform DetailPanelAnchor;

		public RectTransform DropdownAnchor;

		public RectTransform TopDropdownAnchor;

		public Action hoverStart;

		public Action hoverEnd;

		public Action onClicked;

		public Action onDropdownClicked;

		public ShopListing Listing { get; protected set; }

		public virtual void Initialize(ShopListing listing)
		{
		}

		public virtual RectTransform GetIconCopy(RectTransform parent)
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
