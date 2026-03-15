namespace ScheduleOne.UI.Phone
{
	public class CounterOfferProductSelector : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDelaySelectSearchPanel_003Ed__24 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Phone.CounterOfferProductSelector _003C_003E4__this;

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
			public _003CDelaySelectSearchPanel_003Ed__24(int _003C_003E1__state)
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

		public const int ENTRIES_PER_PAGE = 25;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.UI.InputField SearchBar;

		public global::UnityEngine.RectTransform ProductContainer;

		public global::UnityEngine.UI.Text PageLabel;

		public global::UnityEngine.GameObject ProductEntryPrefab;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onProductPreviewed;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onProductSelected;

		[global::UnityEngine.Header("Custom UI")]
		public global::ScheduleOne.UIScreen uiSelectionScreen;

		public global::ScheduleOne.UIPanel uiSearchPanel;

		public global::ScheduleOne.UIPanel uiWindowPanel;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> productEntries;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Product.ProductDefinition, global::UnityEngine.RectTransform> productEntriesDict;

		private string searchTerm;

		private int pageIndex;

		private int pageCount;

		private global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> results;

		private global::ScheduleOne.Product.ProductDefinition lastPreviewedResult;

		public bool IsOpen { get; private set; }

		public void Awake()
		{
		}

		public void Open()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.CounterOfferProductSelector._003CDelaySelectSearchPanel_003Ed__24))]
		private global::System.Collections.IEnumerator DelaySelectSearchPanel()
		{
			return null;
		}

		public void Close()
		{
		}

		private void Update()
		{
		}

		public void SetSearchTerm(string search)
		{
		}

		private void RebuildResultsList()
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> GetMatchingProducts(string searchTerm)
		{
			return null;
		}

		private void EnsureAllEntriesExist()
		{
		}

		private void CreateProductEntry(global::ScheduleOne.Product.ProductDefinition product)
		{
		}

		public void ChangePage(int change)
		{
		}

		private void SetPage(int page)
		{
		}

		private void ProductHovered(global::ScheduleOne.Product.ProductDefinition def)
		{
		}

		private void ProductSelected(global::ScheduleOne.Product.ProductDefinition def)
		{
		}

		public bool IsMouseOverSelector()
		{
			return false;
		}
	}
}
