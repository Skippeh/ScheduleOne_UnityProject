using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.StationFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Stations
{
	public class ChemistryStationCanvas : Singleton<ChemistryStationCanvas>
	{
		public List<StationRecipe> Recipes;

		[Header("Prefabs")]
		public StationRecipeEntry RecipeEntryPrefab;

		[Header("References")]
		public Canvas Canvas;

		public RectTransform Container;

		public RectTransform InputSlotsContainer;

		public ItemSlotUI[] InputSlotUIs;

		public ItemSlotUI OutputSlotUI;

		public RectTransform RecipeSelectionContainer;

		public TextMeshProUGUI InstructionLabel;

		public Button BeginButton;

		public RectTransform SelectionIndicator;

		public RectTransform RecipeContainer;

		public RectTransform CookingInProgressContainer;

		public StationRecipeEntry InProgressRecipeEntry;

		public TextMeshProUGUI InProgressLabel;

		public TextMeshProUGUI ErrorLabel;

		private List<StationRecipeEntry> recipeEntries;

		private StationRecipeEntry selectedRecipe;

		public bool isOpen { get; protected set; }

		public ChemistryStation ChemistryStation { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateUI()
		{
		}

		private void UpdateInput()
		{
		}

		public void Open(ChemistryStation station)
		{
		}

		public void Close(bool removeUI)
		{
		}

		public void BeginButtonPressed()
		{
		}

		private void StationSlotsChanged()
		{
		}

		private void SortRecipes(List<ItemInstance> ingredients)
		{
		}

		private void SetSelectedRecipe(StationRecipeEntry entry)
		{
		}
	}
}
