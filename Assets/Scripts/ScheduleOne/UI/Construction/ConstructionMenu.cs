using System;
using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Construction
{
	public class ConstructionMenu : Singleton<ConstructionMenu>
	{
		[Serializable]
		public class ConstructionMenuCategory
		{
			public string categoryName;

			public Sprite categoryIcon;

			[HideInInspector]
			public Button button;

			[HideInInspector]
			public RectTransform container;

			[HideInInspector]
			public List<ConstructionMenuListing> listings;
		}

		public class ConstructionMenuListing
		{
			public string ID;

			public float price;

			public ConstructionMenuCategory category;

			public RectTransform entry;

			public bool isSelected;

			public ConstructionMenuListing(string id, float _price, ConstructionMenuCategory _cat)
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

		public List<ConstructionMenuCategory> categories;

		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		[SerializeField]
		protected GraphicRaycaster raycaster;

		[SerializeField]
		protected Transform categoryButtonContainer;

		[SerializeField]
		protected RectTransform categoryContainer;

		[SerializeField]
		protected Text categoryNameDisplay;

		[SerializeField]
		protected RectTransform infoPopup;

		[SerializeField]
		protected TextMeshProUGUI infoPopup_ConstructableName;

		[SerializeField]
		protected EventSystem eventSystem;

		[SerializeField]
		protected Button destroyButton;

		[SerializeField]
		protected Button customizeButton;

		[SerializeField]
		protected Button moveButton;

		[SerializeField]
		protected TextMeshProUGUI infoPopup_Description;

		[Header("Prefabs")]
		[SerializeField]
		protected GameObject categoryButtonPrefab;

		[SerializeField]
		protected GameObject categoryContainerPrefab;

		public GameObject listingPrefab;

		[Header("Settings")]
		[SerializeField]
		protected Color iconColor_Unselected;

		[SerializeField]
		protected Color iconColor_Selected;

		public Color listingOutlineColor_Unselected;

		public Color listingOutlineColor_Selected;

		private ConstructionMenuCategory selectedCategory;

		private ConstructionMenuListing selectedListing;

		private Constructable selectedConstructable;

		public bool isOpen { get; protected set; }

		public Constructable SelectedConstructable => null;

		protected override void Start()
		{
		}

		private void Exit(ExitAction exit)
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

		private void OnConstructableBuilt(Constructable c)
		{
		}

		public void ClearSelectedListing()
		{
		}

		public void ListingClicked(ConstructionMenuListing listing)
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

		public void SelectConstructable(Constructable c)
		{
		}

		public void SelectConstructable(Constructable c, bool focusCameraTo)
		{
		}

		private void SetButtonInteractable(Button b, bool interactable, Color32 iconDefaultColor)
		{
		}

		public void DeselectConstructable()
		{
		}

		private Constructable GetHoveredConstructable()
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
