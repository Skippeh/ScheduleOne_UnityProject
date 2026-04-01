namespace ScheduleOne.UI.Phone.Delivery
{
	public class DeliveryApp : global::ScheduleOne.UI.App<global::ScheduleOne.UI.Phone.Delivery.DeliveryApp>
	{
		[global::System.Serializable]
		public class DeliveryShopElement
		{
			public global::ScheduleOne.UI.Phone.Delivery.DeliveryShop Shop;

			public global::UnityEngine.UI.Button Button;
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDoShopTransitionRoutine_003Ed__27 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::System.Collections.Generic.List<global::UnityEngine.RectTransform> panels;

			public global::ScheduleOne.UI.Phone.Delivery.DeliveryApp _003C_003E4__this;

			public int direction;

			public float duration;

			public global::System.Action onComplete;

			private float _003CelapsedTime_003E5__2;

			private global::System.Collections.Generic.List<global::UnityEngine.Vector2> _003CstartPos_003E5__3;

			private global::System.Collections.Generic.List<global::UnityEngine.Vector2> _003CtargetPos_003E5__4;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CDoShopTransitionRoutine_003Ed__27(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Delivery.DeliveryShop> deliveryShops;

		public global::ScheduleOne.UI.Phone.Delivery.DeliveryStatusDisplay StatusDisplayPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Animation OrderSubmittedAnim;

		public global::ScheduleOne.Audio.AudioSourceController OrderSubmittedSound;

		public global::UnityEngine.RectTransform StatusDisplayContainer;

		public global::UnityEngine.GameObject NoDeliveriesIndicator;

		public global::UnityEngine.GameObject NoPastDeliveriesIndicator;

		public global::UnityEngine.UI.ScrollRect MainScrollRect;

		public global::UnityEngine.UI.LayoutGroup MainLayoutGroup;

		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.Phone.Delivery.DeliveryReceiptDisplay _deliveryReceiptPrefab;

		public global::UnityEngine.RectTransform PastDeliveriesContainer;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.TabController _tabController;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.CanvasGroup shopListCanvas;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.CanvasGroup orderCanvas;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Delivery.DeliveryApp.DeliveryShopElement> _shopElements;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private float shopPanelWidth;

		[global::UnityEngine.SerializeField]
		private float shopTransitionDuration;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.Delivery.DeliveryStatusDisplay> statusDisplays;

		private global::ScheduleOne.UI.Phone.Delivery.DeliveryReceiptDisplay[] _pastDeliveries;

		private bool started;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> _shopPanels;

		private global::System.Collections.Generic.List<global::UnityEngine.Vector2> _shopPanelInitialAnchors;

		private global::UnityEngine.Coroutine _shopTransitionCoroutine;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void OpenShop(global::ScheduleOne.UI.Phone.Delivery.DeliveryShop shop)
		{
		}

		public void CloseShop(global::ScheduleOne.UI.Phone.Delivery.DeliveryShop shop)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.Delivery.DeliveryApp._003CDoShopTransitionRoutine_003Ed__27))]
		private global::System.Collections.IEnumerator DoShopTransitionRoutine(float duration, int direction, global::System.Collections.Generic.List<global::UnityEngine.RectTransform> panels, global::System.Action onComplete)
		{
			return null;
		}

		public override void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		private void SetCanvasInteraction(global::UnityEngine.CanvasGroup canvas, bool interactable)
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

		public void OnSubmitOrder(global::ScheduleOne.UI.Phone.Delivery.DeliveryShop shop)
		{
		}

		public void PlayOrderSubmittedAnim()
		{
		}

		public void Reorder(global::ScheduleOne.Delivery.DeliveryReceipt receipt)
		{
		}

		public bool CanReorder(global::ScheduleOne.Delivery.DeliveryReceipt receipt, out string reason)
		{
			reason = null;
			return false;
		}

		public float GetDeliveryCost(global::ScheduleOne.Delivery.DeliveryReceipt receipt)
		{
			return 0f;
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

		public global::ScheduleOne.UI.Phone.Delivery.DeliveryShop GetShop(string shopName)
		{
			return null;
		}

		public void SetIsAvailable(global::ScheduleOne.UI.Shop.ShopInterface matchingShop, bool available)
		{
		}

		private void OnTabChange(int index)
		{
		}

		private void UpdatePastDeliveries()
		{
		}

		private bool IsValidReceipt(global::ScheduleOne.Delivery.DeliveryReceipt receipt)
		{
			return false;
		}

		private void RefreshNotifications()
		{
		}
	}
}
