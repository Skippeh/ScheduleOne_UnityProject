using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	public class CounterofferInterface : MonoBehaviour
	{
		public const int COUNTEROFFER_SUCCESS_XP = 5;

		public const int MinQuantity = 1;

		public int MaxQuantity;

		public const float MinPrice = 1f;

		public const float MaxPrice = 9999f;

		public float IconAlignment;

		public GameObject ProductEntryPrefab;

		[Header("References")]
		public GameObject Container;

		public Text TitleLabel;

		public Button ConfirmButton;

		public Image ProductIcon;

		public Text ProductLabel;

		public RectTransform ProductLabelRect;

		public InputField PriceInput;

		public Text FairPriceLabel;

		public CounterOfferProductSelector ProductSelector;

		private Action<ProductDefinition, int, float> orderConfirmedCallback;

		private ProductDefinition selectedProduct;

		private int quantity;

		private float price;

		private Dictionary<ProductDefinition, RectTransform> productEntries;

		private bool mouseUp;

		private MSGConversation conversation;

		public bool IsOpen { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Open(ProductDefinition product, int quantity, float price, MSGConversation _conversation, Action<ProductDefinition, int, float> _orderConfirmedCallback)
		{
		}

		public void Close()
		{
		}

		public void Exit(ExitAction action)
		{
		}

		public void Send()
		{
		}

		private void UpdateFairPrice()
		{
		}

		private void SetProduct(ProductDefinition newProduct)
		{
		}

		private void DisplayProduct(ProductDefinition tempProduct)
		{
		}

		public void ChangeQuantity(int change)
		{
		}

		private void UpdatePriceQuantityLabel(string productName)
		{
		}

		public void ChangePrice(float change)
		{
		}

		public void PriceSubmitted(string value)
		{
		}

		public void OpenProductSelector()
		{
		}
	}
}
