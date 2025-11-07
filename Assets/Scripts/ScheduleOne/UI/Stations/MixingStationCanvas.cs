namespace ScheduleOne.UI.Stations
{
	public class MixingStationCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Stations.MixingStationCanvas>
	{
		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.UI.Stations.StationRecipeEntry RecipeEntryPrefab;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::ScheduleOne.UI.ItemSlotUI ProductSlotUI;

		public global::TMPro.TextMeshProUGUI ProductPropertiesLabel;

		public global::ScheduleOne.UI.ItemSlotUI IngredientSlotUI;

		public global::TMPro.TextMeshProUGUI IngredientProblemLabel;

		public global::ScheduleOne.UI.ItemSlotUI PreviewSlotUI;

		public global::UnityEngine.UI.Image PreviewIcon;

		public global::TMPro.TextMeshProUGUI PreviewLabel;

		public global::UnityEngine.RectTransform UnknownOutputIcon;

		public global::TMPro.TextMeshProUGUI PreviewPropertiesLabel;

		public global::ScheduleOne.UI.ItemSlotUI OutputSlotUI;

		public global::TMPro.TextMeshProUGUI InstructionLabel;

		public global::UnityEngine.RectTransform TitleContainer;

		public global::UnityEngine.RectTransform MainContainer;

		public global::UnityEngine.UI.Button BeginButton;

		public global::UnityEngine.RectTransform ProductHint;

		public global::UnityEngine.RectTransform MixerHint;

		private global::ScheduleOne.StationFramework.StationRecipe selectedRecipe;

		public bool isOpen { get; protected set; }

		public global::ScheduleOne.ObjectScripts.MixingStation MixingStation { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateUI()
		{
		}

		private void UpdateInput()
		{
		}

		public void Open(global::ScheduleOne.ObjectScripts.MixingStation station)
		{
		}

		public void Close(bool enablePlayerControl = true)
		{
		}

		private void MixingDone()
		{
		}

		private void StationContentsChanged()
		{
		}

		private void UpdateDisplayMode()
		{
		}

		private void UpdateInstruction()
		{
		}

		private void UpdatePreview()
		{
		}

		private string GetPropertyListString(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
			return null;
		}

		private string GetPropertyString(global::ScheduleOne.Effects.Effect property)
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> GetOutputProperties(global::ScheduleOne.Product.ProductDefinition product, global::ScheduleOne.Product.PropertyItemDefinition mixer)
		{
			return null;
		}

		private bool IsOutputKnown(out global::ScheduleOne.Product.ProductDefinition knownProduct)
		{
			knownProduct = null;
			return false;
		}

		private void UpdateBeginButton()
		{
		}

		public void BeginButtonPressed()
		{
		}

		public void StartMixOperation(global::ScheduleOne.ObjectScripts.MixOperation mixOperation)
		{
		}

		private void MixNamed(string mixName)
		{
		}
	}
}
