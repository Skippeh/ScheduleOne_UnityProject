namespace ScheduleOne.UI.Phone
{
	public class CounterOfferProductSelector : global::UnityEngine.MonoBehaviour
	{
		public const int ENTRIES_PER_PAGE = 25;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.UI.InputField SearchBar;

		public global::UnityEngine.RectTransform ProductContainer;

		public global::UnityEngine.UI.Text PageLabel;

		public global::UnityEngine.GameObject ProductEntryPrefab;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onProductPreviewed;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onProductSelected;

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
