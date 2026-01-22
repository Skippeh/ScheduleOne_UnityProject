namespace ScheduleOne.UI.Phone.Messages
{
	public class DealerManagementApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.Messages.DealerManagementApp>
	{
		private class InventoryItem
		{
			public string ID;

			public int Quantity;

			public int Quality;

			public InventoryItem(string id, int quantity, int quality)
			{
			}
		}

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Text NoDealersLabel;

		public global::UnityEngine.RectTransform Content;

		public global::ScheduleOne.UI.Phone.CustomerSelector CustomerSelector;

		[global::UnityEngine.Header("Selector")]
		public global::UnityEngine.UI.Image SelectorImage;

		public global::UnityEngine.UI.Text SelectorTitle;

		public global::UnityEngine.UI.Button BackButton;

		public global::UnityEngine.UI.Button NextButton;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.DropdownUI _dropdown;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Image _dropdownBackground;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Image _dropdownCaptionImage;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _dropDownCaptionText;

		[global::UnityEngine.Header("Basic Info")]
		public global::UnityEngine.UI.Text CashLabel;

		public global::UnityEngine.UI.Text CutLabel;

		public global::UnityEngine.UI.Text HomeLabel;

		[global::UnityEngine.Header("Inventory")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _inventoryTextLabel;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RectTransform _inventoryEntryContainer;

		public global::UnityEngine.RectTransform[] InventoryEntries;

		[global::UnityEngine.Header("Customers")]
		public global::UnityEngine.UI.Text CustomerTitleLabel;

		public global::UnityEngine.RectTransform[] CustomerEntries;

		public global::UnityEngine.UI.Button AssignCustomerButton;

		[global::UnityEngine.Header("Fonts")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.SpriteFont _uiGeneralSpriteFont;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _productColorFont;

		private global::System.Collections.Generic.List<global::ScheduleOne.Economy.Dealer> dealers;

		private bool _isOpen;

		public global::ScheduleOne.Economy.Dealer SelectedDealer { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void Refresh()
		{
		}

		public override void SetOpen(bool open)
		{
		}

		public void SetDisplayedDealer(global::ScheduleOne.Economy.Dealer dealer)
		{
		}

		private void AddDealer(global::ScheduleOne.Economy.Dealer dealer)
		{
		}

		private void AddCustomer(global::ScheduleOne.Economy.Customer customer)
		{
		}

		private void RemoveCustomer(global::ScheduleOne.Economy.Customer customer)
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

		private void SetDropDown()
		{
		}

		private void OnDropdownValueChanged(int value)
		{
		}

		private void OnDropdownOpen()
		{
		}
	}
}
