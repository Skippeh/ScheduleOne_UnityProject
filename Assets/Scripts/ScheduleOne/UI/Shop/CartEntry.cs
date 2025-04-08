namespace ScheduleOne.UI.Shop
{
	public class CartEntry : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::TMPro.TextMeshProUGUI NameLabel;

		public global::TMPro.TextMeshProUGUI PriceLabel;

		public global::UnityEngine.UI.Button IncrementButton;

		public global::UnityEngine.UI.Button DecrementButton;

		public global::UnityEngine.UI.Button RemoveButton;

		public int Quantity { get; protected set; }

		public global::ScheduleOne.UI.Shop.Cart Cart { get; protected set; }

		public global::ScheduleOne.UI.Shop.ShopListing Listing { get; protected set; }

		public void Initialize(global::ScheduleOne.UI.Shop.Cart cart, global::ScheduleOne.UI.Shop.ShopListing listing, int quantity)
		{
		}

		public void SetQuantity(int quantity)
		{
		}

		protected virtual void UpdateTitle()
		{
		}

		private void UpdatePrice()
		{
		}

		private void ChangeAmount(int change)
		{
		}
	}
}
