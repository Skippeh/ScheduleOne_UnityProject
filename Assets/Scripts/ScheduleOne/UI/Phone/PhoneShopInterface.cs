namespace ScheduleOne.UI.Phone
{
	public class PhoneShopInterface : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class Listing
		{
			public global::ScheduleOne.ItemFramework.StorableItemDefinition Item;

			public float Price => 0f;

			public Listing(global::ScheduleOne.ItemFramework.StorableItemDefinition item)
			{
			}
		}

		[global::System.Serializable]
		public class CartEntry
		{
			public global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing Listing;

			public int Quantity;

			public CartEntry(global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing listing, int quantity)
			{
			}
		}

		public global::UnityEngine.RectTransform EntryPrefab;

		public global::UnityEngine.Color ValidAmountColor;

		public global::UnityEngine.Color InvalidAmountColor;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.UI.Text TitleLabel;

		public global::UnityEngine.UI.Text SubtitleLabel;

		public global::UnityEngine.RectTransform EntryContainer;

		public global::UnityEngine.UI.Text OrderTotalLabel;

		public global::UnityEngine.UI.Text OrderLimitLabel;

		public global::UnityEngine.UI.Text DebtLabel;

		public global::UnityEngine.UI.Button ConfirmButton;

		public global::UnityEngine.GameObject ItemLimitContainer;

		public global::UnityEngine.UI.Text ItemLimitLabel;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> _entries;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing> _items;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.CartEntry> _cart;

		private float orderLimit;

		private global::System.Action<global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.CartEntry>, float> orderConfirmedCallback;

		private global::ScheduleOne.Messaging.MSGConversation conversation;

		public bool IsOpen { get; private set; }

		private void Start()
		{
		}

		public void Open(string title, string subtitle, global::ScheduleOne.Messaging.MSGConversation _conversation, global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing> listings, float _orderLimit, float debt, global::System.Action<global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.CartEntry>, float> _orderConfirmedCallback)
		{
		}

		public void Close()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void ChangeListingQuantity(global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing listing, int change)
		{
		}

		private void CartChanged()
		{
		}

		private void ConfirmOrderPressed()
		{
		}

		private bool CanConfirmOrder()
		{
			return false;
		}

		private void UpdateOrderTotal()
		{
		}

		private float GetOrderTotal(out int itemCount)
		{
			itemCount = default(int);
			return 0f;
		}
	}
}
