namespace ScheduleOne.UI.Phone.Delivery
{
	public class DeliveryStatusDisplay : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.GameObject ItemEntryPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Rect;

		public global::UnityEngine.UI.Text DestinationLabel;

		public global::UnityEngine.UI.Text ShopLabel;

		public global::UnityEngine.UI.Image StatusImage;

		public global::UnityEngine.UI.Text StatusLabel;

		public global::ScheduleOne.UI.Tooltips.Tooltip StatusTooltip;

		public global::UnityEngine.RectTransform ItemEntryContainer;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Color StatusColor_Transit;

		public global::UnityEngine.Color StatusColor_Waiting;

		public global::UnityEngine.Color StatusColor_Arrived;

		public global::ScheduleOne.Delivery.DeliveryInstance DeliveryInstance { get; private set; }

		public void AssignDelivery(global::ScheduleOne.Delivery.DeliveryInstance instance)
		{
		}

		public void RefreshStatus()
		{
		}
	}
}
