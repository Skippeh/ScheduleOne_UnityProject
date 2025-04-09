using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	public class Cart : MonoBehaviour
	{
		[Header("References")]
		public ShopInterface Shop;

		public Image CartIcon;

		public TextMeshProUGUI ViewCartText;

		public RectTransform CartEntryContainer;

		public TextMeshProUGUI ProblemText;

		public TextMeshProUGUI WarningText;

		public Button BuyButton;

		public RectTransform CartContainer;

		public Image CartArea;

		public TextMeshProUGUI TotalText;

		public Toggle LoadVehicleToggle;

		[Header("Prefabs")]
		public CartEntry EntryPrefab;

		public Dictionary<ShopListing, int> cartDictionary;

		private Coroutine cartIconBop;

		private List<CartEntry> cartEntries;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void AddItem(ShopListing listing, int quantity)
		{
		}

		public void RemoveItem(ShopListing listing, int quantity)
		{
		}

		public void ClearCart()
		{
		}

		public int GetCartCount(ShopListing listing)
		{
			return 0;
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

		private CartEntry GetEntry(ShopListing listing)
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
