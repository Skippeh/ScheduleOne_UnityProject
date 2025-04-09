using ScheduleOne.UI.Shop;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	public class ListingEntry : MonoBehaviour
	{
		[Header("References")]
		public Image Icon;

		public Text ItemNameLabel;

		public Text ItemPriceLabel;

		public InputField QuantityInput;

		public Button IncrementButton;

		public Button DecrementButton;

		public RectTransform LockedContainer;

		public UnityEvent onQuantityChanged;

		public ShopListing MatchingListing { get; private set; }

		public int SelectedQuantity { get; private set; }

		public void Initialize(ShopListing match)
		{
		}

		public void RefreshLocked()
		{
		}

		public void SetQuantity(int quant, bool notify = true)
		{
		}

		private void ChangeQuantity(int change)
		{
		}

		private void OnQuantityInputSubmitted(string value)
		{
		}

		private void ValidateInput()
		{
		}
	}
}
