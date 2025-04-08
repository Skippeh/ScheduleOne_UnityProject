namespace ScheduleOne.UI.Phone.Messages
{
	public class DealerManagementApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.Messages.DealerManagementApp>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Text NoDealersLabel;

		public global::UnityEngine.RectTransform Content;

		public global::ScheduleOne.UI.Phone.CustomerSelector CustomerSelector;

		[global::UnityEngine.Header("Selector")]
		public global::UnityEngine.UI.Image SelectorImage;

		public global::UnityEngine.UI.Text SelectorTitle;

		public global::UnityEngine.UI.Button BackButton;

		public global::UnityEngine.UI.Button NextButton;

		[global::UnityEngine.Header("Basic Info")]
		public global::UnityEngine.UI.Text CashLabel;

		public global::UnityEngine.UI.Text CutLabel;

		public global::UnityEngine.UI.Text HomeLabel;

		[global::UnityEngine.Header("Inventory")]
		public global::UnityEngine.RectTransform[] InventoryEntries;

		[global::UnityEngine.Header("Customers")]
		public global::UnityEngine.UI.Text CustomerTitleLabel;

		public global::UnityEngine.RectTransform[] CustomerEntries;

		public global::UnityEngine.UI.Button AssignCustomerButton;

		private global::System.Collections.Generic.List<global::ScheduleOne.Economy.Dealer> dealers;

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
	}
}
