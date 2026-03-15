namespace ScheduleOne.UI.Phone
{
	public class PhoneShopInterface : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class Listing
		{
			public global::ScheduleOne.ItemFramework.StorableItemDefinition Item;

			public float Price => 0f;

			public Listing(global::ScheduleOne.ItemFramework.StorableItemDefinition item)
			{
			}
		}

		[global::System.Serializable]
		public class CartEntry
		{
			public global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing Listing;

			public int Quantity;

			public CartEntry(global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing listing, int quantity)
			{
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDelaySelectPanel_003Ed__29 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Phone.PhoneShopInterface _003C_003E4__this;

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
			public _003CDelaySelectPanel_003Ed__29(int _003C_003E1__state)
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

		public global::UnityEngine.RectTransform EntryPrefab;

		public global::UnityEngine.Color ValidAmountColor;

		public global::UnityEngine.Color InvalidAmountColor;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.UI.Text TitleLabel;

		public global::UnityEngine.UI.Text SubtitleLabel;

		public global::UnityEngine.RectTransform EntryContainer;

		public global::UnityEngine.UI.Text OrderTotalLabel;

		public global::UnityEngine.UI.Text OrderLimitLabel;

		public global::UnityEngine.UI.Text DebtLabel;

		public global::UnityEngine.UI.Button ConfirmButton;

		public global::UnityEngine.GameObject ItemLimitContainer;

		public global::UnityEngine.UI.Text ItemLimitLabel;

		[global::UnityEngine.Header("Custom UI")]
		public global::ScheduleOne.UIScreen uiScreen;

		public global::ScheduleOne.UIPanel uiPanel;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> _entries;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing> _items;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.CartEntry> _cart;

		private float orderLimit;

		private global::System.Action<global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.CartEntry>, float> orderConfirmedCallback;

		private global::ScheduleOne.Messaging.MSGConversation conversation;

		public bool IsOpen { get; private set; }

		private void Start()
		{
		}

		public void Open(string title, string subtitle, global::ScheduleOne.Messaging.MSGConversation _conversation, global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing> listings, float _orderLimit, float debt, global::System.Action<global::System.Collections.Generic.List<global::ScheduleOne.UI.Phone.PhoneShopInterface.CartEntry>, float> _orderConfirmedCallback)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.PhoneShopInterface._003CDelaySelectPanel_003Ed__29))]
		private global::System.Collections.IEnumerator DelaySelectPanel()
		{
			return null;
		}

		public void Close()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void ChangeListingQuantity(global::ScheduleOne.UI.Phone.PhoneShopInterface.Listing listing, int change)
		{
		}

		private void CartChanged()
		{
		}

		private void ConfirmOrderPressed()
		{
		}

		private bool CanConfirmOrder()
		{
			return false;
		}

		private void UpdateOrderTotal()
		{
		}

		private float GetOrderTotal(out int itemCount)
		{
			itemCount = default(int);
			return 0f;
		}
	}
}
