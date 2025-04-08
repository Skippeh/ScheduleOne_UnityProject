namespace ScheduleOne.UI.Shop
{
	public class Cart : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.Shop.ShopInterface Shop;

		public global::UnityEngine.UI.Image CartIcon;

		public global::TMPro.TextMeshProUGUI ViewCartText;

		public global::UnityEngine.RectTransform CartEntryContainer;

		public global::TMPro.TextMeshProUGUI ProblemText;

		public global::TMPro.TextMeshProUGUI WarningText;

		public global::UnityEngine.UI.Button BuyButton;

		public global::UnityEngine.RectTransform CartContainer;

		public global::UnityEngine.UI.Image CartArea;

		public global::TMPro.TextMeshProUGUI TotalText;

		public global::UnityEngine.UI.Toggle LoadVehicleToggle;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.UI.Shop.CartEntry EntryPrefab;

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.UI.Shop.ShopListing, int> cartDictionary;

		private global::UnityEngine.Coroutine cartIconBop;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Shop.CartEntry> cartEntries;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void AddItem(global::ScheduleOne.UI.Shop.ShopListing listing, int quantity)
		{
		}

		public void RemoveItem(global::ScheduleOne.UI.Shop.ShopListing listing, int quantity)
		{
		}

		public void ClearCart()
		{
		}

		public void BopCartIcon()
		{
		}

		public bool CanPlayerAffordCart()
		{
			return false;
		}

		public void Buy()
		{
		}

		private void UpdateEntries()
		{
		}

		private void UpdateTotal()
		{
		}

		private void UpdateProblem()
		{
		}

		private bool CanCheckout(out string reason)
		{
			reason = null;
			return false;
		}

		private bool GetWarning(out string warning)
		{
			warning = null;
			return false;
		}

		private void UpdateViewCartText()
		{
		}

		private void UpdateLoadVehicleToggle()
		{
		}

		private int GetItemSum()
		{
			return 0;
		}

		private float GetPriceSum()
		{
			return 0f;
		}

		private global::ScheduleOne.UI.Shop.CartEntry GetEntry(global::ScheduleOne.UI.Shop.ShopListing listing)
		{
			return null;
		}

		private bool IsMouseOverMenuArea()
		{
			return false;
		}

		public int GetTotalSlotRequirement()
		{
			return 0;
		}
	}
}
