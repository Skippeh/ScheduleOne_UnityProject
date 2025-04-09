using System.Collections.Generic;
using ScheduleOne.Economy;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	public class DealerManagementApp : App<DealerManagementApp>
	{
		[Header("References")]
		public Text NoDealersLabel;

		public RectTransform Content;

		public CustomerSelector CustomerSelector;

		[Header("Selector")]
		public Image SelectorImage;

		public Text SelectorTitle;

		public Button BackButton;

		public Button NextButton;

		[Header("Basic Info")]
		public Text CashLabel;

		public Text CutLabel;

		public Text HomeLabel;

		[Header("Inventory")]
		public RectTransform[] InventoryEntries;

		[Header("Customers")]
		public Text CustomerTitleLabel;

		public RectTransform[] CustomerEntries;

		public Button AssignCustomerButton;

		private List<Dealer> dealers;

		public Dealer SelectedDealer { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void SetOpen(bool open)
		{
		}

		public void SetDisplayedDealer(Dealer dealer)
		{
		}

		private void AddDealer(Dealer dealer)
		{
		}

		private void AddCustomer(Customer customer)
		{
		}

		private void RemoveCustomer(Customer customer)
		{
		}

		private void BackPressed()
		{
		}

		private void NextPressed()
		{
		}

		public void AssignCustomer()
		{
		}
	}
}
