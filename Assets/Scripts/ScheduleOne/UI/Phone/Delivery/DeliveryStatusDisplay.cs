namespace ScheduleOne.UI.Phone.Delivery
{
	public class DeliveryStatusDisplay : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.Items.ItemEntryUI ItemEntryPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.UI.Text DestinationLabel;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _loadingDockLabel;

		public global::UnityEngine.UI.Text ShopLabel;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Text _shopDescriptionLabel;

		public global::UnityEngine.UI.Image StatusImage;

		public global::UnityEngine.UI.Text StatusLabel;

		public global::ScheduleOne.UI.Tooltips.Tooltip StatusTooltip;

		public global::UnityEngine.RectTransform ItemEntryContainer;

		public global::UnityEngine.Animation FlashAnimation;

		public global::UnityEngine.GameObject FlashObject;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private int _maxItemsShown;

		public global::UnityEngine.Color StatusColor_Transit;

		public global::UnityEngine.Color StatusColor_Waiting;

		public global::UnityEngine.Color StatusColor_Arrived;

		[global::UnityEngine.Header("Fonts")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _shopTextColorFont;

		public global::ScheduleOne.Delivery.DeliveryInstance DeliveryInstance { get; private set; }

		public void AssignDelivery(global::ScheduleOne.Delivery.DeliveryInstance instance)
		{
		}

		public void RefreshStatus()
		{
		}

		public void Flash()
		{
		}

		private void OnDisable()
		{
		}
	}
}
