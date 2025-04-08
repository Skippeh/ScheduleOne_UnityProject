namespace ScheduleOne.UI.Construction
{
	public class ConstructionMenu : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Construction.ConstructionMenu>
	{
		[global::System.Serializable]
		public class ConstructionMenuCategory
		{
			public string categoryName;

			public global::UnityEngine.Sprite categoryIcon;

			[global::UnityEngine.HideInInspector]
			public global::UnityEngine.UI.Button button;

			[global::UnityEngine.HideInInspector]
			public global::UnityEngine.RectTransform container;

			[global::UnityEngine.HideInInspector]
			public global::System.Collections.Generic.List<global::ScheduleOne.UI.Construction.ConstructionMenu.ConstructionMenuListing> listings;
		}

		public class ConstructionMenuListing
		{
			public string ID;

			public float price;

			public global::ScheduleOne.UI.Construction.ConstructionMenu.ConstructionMenuCategory category;

			public global::UnityEngine.RectTransform entry;

			public bool isSelected;

			public ConstructionMenuListing(string id, float _price, global::ScheduleOne.UI.Construction.ConstructionMenu.ConstructionMenuCategory _cat)
			{
			}

			private void CreateUI()
			{
			}

			private void ListingClicked()
			{
			}

			public void ListingUnselected()
			{
			}

			public void SetSelected(bool selected)
			{
			}
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.Construction.ConstructionMenu.ConstructionMenuCategory> categories;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Canvas canvas;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.GraphicRaycaster raycaster;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform categoryButtonContainer;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform categoryContainer;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text categoryNameDisplay;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform infoPopup;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI infoPopup_ConstructableName;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.EventSystems.EventSystem eventSystem;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button destroyButton;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button customizeButton;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button moveButton;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI infoPopup_Description;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject categoryButtonPrefab;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject categoryContainerPrefab;

		public global::UnityEngine.GameObject listingPrefab;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Color iconColor_Unselected;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Color iconColor_Selected;

		public global::UnityEngine.Color listingOutlineColor_Unselected;

		public global::UnityEngine.Color listingOutlineColor_Selected;

		private global::ScheduleOne.UI.Construction.ConstructionMenu.ConstructionMenuCategory selectedCategory;

		private global::ScheduleOne.UI.Construction.ConstructionMenu.ConstructionMenuListing selectedListing;

		private global::ScheduleOne.ConstructableScripts.Constructable selectedConstructable;

		public bool isOpen { get; protected set; }

		public global::ScheduleOne.ConstructableScripts.Constructable SelectedConstructable => null;

		protected override void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exit)
		{
		}

		protected virtual void Update()
		{
		}

		private void SetupListings()
		{
		}

		private void AddListing(string ID, float price, string category)
		{
		}

		private void SetIsOpen(bool open)
		{
		}

		private void OnConstructableBuilt(global::ScheduleOne.ConstructableScripts.Constructable c)
		{
		}

		public void ClearSelectedListing()
		{
		}

		public void ListingClicked(global::ScheduleOne.UI.Construction.ConstructionMenu.ConstructionMenuListing listing)
		{
		}

		public bool IsHoveringUI()
		{
			return false;
		}

		public void MoveButtonPressed()
		{
		}

		public void CustomizeButtonPressed()
		{
		}

		public void BulldozeButtonPressed()
		{
		}

		private void CheckConstructableSelection()
		{
		}

		public void SelectConstructable(global::ScheduleOne.ConstructableScripts.Constructable c)
		{
		}

		public void SelectConstructable(global::ScheduleOne.ConstructableScripts.Constructable c, bool focusCameraTo)
		{
		}

		private void SetButtonInteractable(global::UnityEngine.UI.Button b, bool interactable, global::UnityEngine.Color32 iconDefaultColor)
		{
		}

		public void DeselectConstructable()
		{
		}

		private global::ScheduleOne.ConstructableScripts.Constructable GetHoveredConstructable()
		{
			return null;
		}

		private void GenerateCategories()
		{
		}

		public void SelectCategory(string categoryName)
		{
		}

		public float GetListingPrice(string id)
		{
			return 0f;
		}
	}
}
