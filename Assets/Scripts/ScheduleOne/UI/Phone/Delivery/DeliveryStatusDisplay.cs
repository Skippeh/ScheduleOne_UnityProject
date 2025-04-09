using ScheduleOne.Delivery;
using ScheduleOne.UI.Tooltips;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Delivery
{
	public class DeliveryStatusDisplay : MonoBehaviour
	{
		public GameObject ItemEntryPrefab;

		[Header("References")]
		public RectTransform Rect;

		public Text DestinationLabel;

		public Text ShopLabel;

		public Image StatusImage;

		public Text StatusLabel;

		public Tooltip StatusTooltip;

		public RectTransform ItemEntryContainer;

		[Header("Settings")]
		public Color StatusColor_Transit;

		public Color StatusColor_Waiting;

		public Color StatusColor_Arrived;

		public DeliveryInstance DeliveryInstance { get; private set; }

		public void AssignDelivery(DeliveryInstance instance)
		{
		}

		public void RefreshStatus()
		{
		}
	}
}
