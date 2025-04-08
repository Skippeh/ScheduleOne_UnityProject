namespace ScheduleOne.UI.Phone.Delivery
{
	public class ListingEntry : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Image Icon;

		public global::UnityEngine.UI.Text ItemNameLabel;

		public global::UnityEngine.UI.Text ItemPriceLabel;

		public global::UnityEngine.UI.InputField QuantityInput;

		public global::UnityEngine.UI.Button IncrementButton;

		public global::UnityEngine.UI.Button DecrementButton;

		public global::UnityEngine.RectTransform LockedContainer;

		public global::UnityEngine.Events.UnityEvent onQuantityChanged;

		public global::ScheduleOne.UI.Shop.ShopListing MatchingListing { get; private set; }

		public int SelectedQuantity { get; private set; }

		public void Initialize(global::ScheduleOne.UI.Shop.ShopListing match)
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
