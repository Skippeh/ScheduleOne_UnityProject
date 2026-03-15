namespace ScheduleOne.UI.Phone
{
	public class CounterofferInterface : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDelaySelectPanel_003Ed__33 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Phone.CounterofferInterface _003C_003E4__this;

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
			public _003CDelaySelectPanel_003Ed__33(int _003C_003E1__state)
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

		public const int COUNTEROFFER_SUCCESS_XP = 5;

		public const int MinQuantity = 1;

		public int MaxQuantity;

		public const float MinPrice = 1f;

		public const float MaxPrice = 9999f;

		public float IconAlignment;

		public global::UnityEngine.GameObject ProductEntryPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.UI.Text TitleLabel;

		public global::UnityEngine.UI.Button ConfirmButton;

		public global::UnityEngine.UI.Image ProductIcon;

		public global::UnityEngine.UI.Text ProductLabel;

		public global::UnityEngine.RectTransform ProductLabelRect;

		public global::UnityEngine.UI.InputField PriceInput;

		public global::UnityEngine.UI.Text FairPriceLabel;

		public global::ScheduleOne.UI.Phone.CounterOfferProductSelector ProductSelector;

		[global::UnityEngine.Header("Custom UI")]
		public global::ScheduleOne.UIScreen uiScreen;

		public global::ScheduleOne.UIPanel uiPanel;

		private global::System.Action<global::ScheduleOne.Product.ProductDefinition, int, float> orderConfirmedCallback;

		private global::ScheduleOne.Product.ProductDefinition selectedProduct;

		private int quantity;

		private float price;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Product.ProductDefinition, global::UnityEngine.RectTransform> productEntries;

		private bool mouseUp;

		private global::ScheduleOne.Messaging.MSGConversation conversation;

		public bool IsOpen { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Open(global::ScheduleOne.Product.ProductDefinition product, int quantity, float price, global::ScheduleOne.Messaging.MSGConversation _conversation, global::System.Action<global::ScheduleOne.Product.ProductDefinition, int, float> _orderConfirmedCallback)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.CounterofferInterface._003CDelaySelectPanel_003Ed__33))]
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

		public void Send()
		{
		}

		private void UpdateFairPrice()
		{
		}

		private void SetProduct(global::ScheduleOne.Product.ProductDefinition newProduct)
		{
		}

		private void DisplayProduct(global::ScheduleOne.Product.ProductDefinition tempProduct)
		{
		}

		public void ChangeQuantity(int change)
		{
		}

		private void UpdatePriceQuantityLabel(string productName)
		{
		}

		public void ChangePrice(float change)
		{
		}

		public void PriceSubmitted(string value)
		{
		}

		public void OpenProductSelector()
		{
		}
	}
}
