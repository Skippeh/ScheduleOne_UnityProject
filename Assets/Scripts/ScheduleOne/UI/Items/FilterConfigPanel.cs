namespace ScheduleOne.UI.Items
{
	public class FilterConfigPanel : global::UnityEngine.MonoBehaviour
	{
		public class SearchCategory
		{
			public class Item
			{
				public global::ScheduleOne.ItemFramework.ItemDefinition ItemDefinition;

				public global::UnityEngine.RectTransform Entry;
			}

			public global::ScheduleOne.ItemFramework.EItemCategory Category;

			public global::UnityEngine.RectTransform Container;

			public global::System.Collections.Generic.List<global::ScheduleOne.UI.Items.FilterConfigPanel.SearchCategory.Item> Items;

			public void AddItem(global::ScheduleOne.ItemFramework.ItemDefinition item, global::UnityEngine.RectTransform entry)
			{
			}

			public void SetSearch(string search)
			{
			}

			public global::ScheduleOne.UI.Items.FilterConfigPanel.SearchCategory.Item GetItem(string itemID)
			{
				return null;
			}
		}

		public global::UnityEngine.GameObject ItemEntryPrefab;

		public global::UnityEngine.GameObject CategoryPrefab;

		public global::UnityEngine.GameObject SearchItemPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Rect;

		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.UI.Button TypeButton_None;

		public global::UnityEngine.UI.Button TypeButton_Whitelist;

		public global::UnityEngine.UI.Button TypeButton_Blacklist;

		public global::TMPro.TextMeshProUGUI TypeLabel;

		public global::TMPro.TextMeshProUGUI ListLabel;

		public global::UnityEngine.RectTransform ListContainer;

		public global::UnityEngine.GameObject ListBlocker;

		public global::UnityEngine.UI.Button[] QualityButtons;

		public global::UnityEngine.UI.ScrollRect ListScrollRect;

		public global::UnityEngine.RectTransform Dropdown;

		public global::UnityEngine.UI.Button CopyButton;

		public global::UnityEngine.UI.Button PasteButton;

		public global::UnityEngine.UI.Button ApplyToSiblingsButton;

		public global::UnityEngine.UI.Button ClearButton;

		[global::UnityEngine.Header("Search")]
		public global::UnityEngine.RectTransform SearchContainer;

		public global::TMPro.TMP_InputField SearchInput;

		public global::UnityEngine.RectTransform CategoryContainer;

		private bool mouseUp;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Items.FilterConfigPanel.SearchCategory> searchCategories;

		private global::System.Collections.Generic.List<global::UnityEngine.RectTransform> itemEntries;

		private static global::ScheduleOne.ItemFramework.SlotFilter copiedFilter;

		public bool IsOpen { get; private set; }

		public global::ScheduleOne.ItemFramework.ItemSlot OpenSlot { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		private void Update()
		{
		}

		public void Open(global::ScheduleOne.UI.ItemSlotUI ui)
		{
		}

		public void Close()
		{
		}

		private void UpdateSearch()
		{
		}

		public void FilterModeSelected(int filterType)
		{
		}

		public void FilterModeSelected(global::ScheduleOne.ItemFramework.SlotFilter.EType filterType)
		{
		}

		public void QualitySelected(int quality)
		{
		}

		public void QualitySelected(global::ScheduleOne.ItemFramework.EQuality quality)
		{
		}

		public void AddClicked()
		{
		}

		public void CopyClicked()
		{
		}

		public void PasteClicked()
		{
		}

		public void ApplyToSiblingsClicked()
		{
		}

		public void ClearClicked()
		{
		}

		public void ToggleDropdown()
		{
		}

		public void OpenDropdown()
		{
		}

		public void CloseDropdown()
		{
		}

		private void ItemClicked(string itemID)
		{
		}

		private void AddItem(string itemID)
		{
		}

		private void RemoveItem(string itemID)
		{
		}

		private void RefreshDisplay()
		{
		}

		private bool IsMouseOverPanel()
		{
			return false;
		}

		private bool IsMouseOverSearch()
		{
			return false;
		}

		private bool IsMouseOverDropdown()
		{
			return false;
		}

		private global::ScheduleOne.UI.Items.FilterConfigPanel.SearchCategory GetSearchCategory(global::ScheduleOne.ItemFramework.EItemCategory category)
		{
			return null;
		}

		private void OpenSearch()
		{
		}

		private void CloseSearch()
		{
		}

		private void SearchChanged(string search)
		{
		}

		private void RefreshSearchResults()
		{
		}
	}
}
