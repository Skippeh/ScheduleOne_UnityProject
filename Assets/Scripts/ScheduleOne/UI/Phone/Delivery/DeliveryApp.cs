namespace ScheduleOne.UI.Phone.Delivery
{
	public class DeliveryApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.Delivery.DeliveryApp>
	{
		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Delivery.DeliveryShop> deliveryShops;

		public global::ScheduleOne.UI.Phone.Delivery.DeliveryStatusDisplay StatusDisplayPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Animation OrderSubmittedAnim;

		public global::ScheduleOne.Audio.AudioSourceController OrderSubmittedSound;

		public global::UnityEngine.RectTransform StatusDisplayContainer;

		public global::UnityEngine.RectTransform NoDeliveriesIndicator;

		public global::UnityEngine.UI.ScrollRect MainScrollRect;

		public global::UnityEngine.UI.LayoutGroup MainLayoutGroup;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Delivery.DeliveryStatusDisplay> statusDisplays;

		private bool started;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void Update()
		{
		}

		public override void SetOpen(bool open)
		{
		}

		private void OnMinPass()
		{
		}

		public void RefreshContent(bool keepScrollPosition = true)
		{
		}

		public void PlayOrderSubmittedAnim()
		{
		}

		private void CreateDeliveryStatusDisplay(global::ScheduleOne.Delivery.DeliveryInstance instance)
		{
		}

		private void DeliveryCompleted(global::ScheduleOne.Delivery.DeliveryInstance instance)
		{
		}

		private void SortStatusDisplays()
		{
		}

		private void RefreshNoDeliveriesIndicator()
		{
		}

		public static void RefreshLayoutGroupsImmediateAndRecursive(global::UnityEngine.GameObject root)
		{
		}

		public global::ScheduleOne.UI.Phone.Delivery.DeliveryShop GetShop(global::ScheduleOne.UI.Shop.ShopInterface matchingShop)
		{
			return null;
		}

		public global::ScheduleOne.UI.Phone.Delivery.DeliveryShop GetShop(string shopName)
		{
			return null;
		}
	}
}
