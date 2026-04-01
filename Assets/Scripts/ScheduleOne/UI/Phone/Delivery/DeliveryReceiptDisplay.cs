namespace ScheduleOne.UI.Phone.Delivery
{
	public class DeliveryReceiptDisplay : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.Items.ItemEntryUI ItemEntryPrefab;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _DestinationLabel;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _loadingDockLabel;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _shopLabel;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _shopDescriptionLabel;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RectTransform _ItemEntryContainer;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button _ReorderButton;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.Tooltips.Tooltip _ReorderTooltip;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _reorderPriceLabel;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private int _maxItemsShown;

		[global::UnityEngine.Header("Fonts")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _generalColorFont;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _shopTextColorFont;

		private global::ScheduleOne.Delivery.DeliveryReceipt _receipt;

		private global::ScheduleOne.UI.Items.ItemEntryUI[] _itemEntries;

		private global::System.Action<global::ScheduleOne.Delivery.DeliveryReceipt> _onSelect;

		public global::UnityEngine.UI.Button ReorderButton => null;

		public global::ScheduleOne.Delivery.DeliveryReceipt Receipt => null;

		public void Initialise()
		{
		}

		public void Set(global::ScheduleOne.Delivery.DeliveryReceipt receipt, float deliveryCost, bool canAfford)
		{
		}

		public void SetTooltip(string tooltip)
		{
		}

		public void SetActiveTooltip(bool active)
		{
		}

		public void SubscribeToOnSelect(global::System.Action<global::ScheduleOne.Delivery.DeliveryReceipt> callback)
		{
		}

		public void UnsubscribeFromOnSelect(global::System.Action<global::ScheduleOne.Delivery.DeliveryReceipt> callback)
		{
		}
	}
}
