namespace ScheduleOne.UI.Stations
{
	public class ChemistryStationCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Stations.ChemistryStationCanvas>
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationRecipe> Recipes;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.UI.Stations.StationRecipeEntry RecipeEntryPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.RectTransform InputSlotsContainer;

		public global::ScheduleOne.UI.ItemSlotUI[] InputSlotUIs;

		public global::ScheduleOne.UI.ItemSlotUI OutputSlotUI;

		public global::UnityEngine.RectTransform RecipeSelectionContainer;

		public global::TMPro.TextMeshProUGUI InstructionLabel;

		public global::UnityEngine.UI.Button BeginButton;

		public global::UnityEngine.RectTransform SelectionIndicator;

		public global::UnityEngine.RectTransform RecipeContainer;

		public global::UnityEngine.RectTransform CookingInProgressContainer;

		public global::ScheduleOne.UI.Stations.StationRecipeEntry InProgressRecipeEntry;

		public global::TMPro.TextMeshProUGUI InProgressLabel;

		public global::TMPro.TextMeshProUGUI ErrorLabel;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Stations.StationRecipeEntry> recipeEntries;

		private global::ScheduleOne.UI.Stations.StationRecipeEntry selectedRecipe;

		public bool isOpen { get; protected set; }

		public global::ScheduleOne.ObjectScripts.ChemistryStation ChemistryStation { get; protected set; }

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

		public void Open(global::ScheduleOne.ObjectScripts.ChemistryStation station)
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

		private void SortRecipes(global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemInstance> ingredients)
		{
		}

		private void SetSelectedRecipe(global::ScheduleOne.UI.Stations.StationRecipeEntry entry)
		{
		}
	}
}
