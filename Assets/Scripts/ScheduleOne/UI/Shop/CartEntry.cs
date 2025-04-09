using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	public class CartEntry : MonoBehaviour
	{
		[Header("References")]
		public TextMeshProUGUI NameLabel;

		public TextMeshProUGUI PriceLabel;

		public Button IncrementButton;

		public Button DecrementButton;

		public Button RemoveButton;

		public int Quantity { get; protected set; }

		public Cart Cart { get; protected set; }

		public ShopListing Listing { get; protected set; }

		public void Initialize(Cart cart, ShopListing listing, int quantity)
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
