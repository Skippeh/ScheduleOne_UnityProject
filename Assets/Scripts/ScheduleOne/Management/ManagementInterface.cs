namespace ScheduleOne.Management
{
	public class ManagementInterface : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Management.ManagementInterface>
	{
		[global::System.Serializable]
		public class ConfigurableTypePanel
		{
			public global::ScheduleOne.Management.EConfigurableType Type;

			public global::ScheduleOne.Management.UI.ConfigPanel Panel;
		}

		public const float PANEL_SLIDE_TIME = 0f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::TMPro.TextMeshProUGUI NothingSelectedLabel;

		public global::TMPro.TextMeshProUGUI DifferentTypesSelectedLabel;

		public global::UnityEngine.RectTransform PanelContainer;

		public global::ScheduleOne.UI.Management.ClipboardScreen MainScreen;

		public global::ScheduleOne.UI.Management.ItemSelector ItemSelectorScreen;

		public global::ScheduleOne.UI.Management.NPCSelector NPCSelector;

		public global::ScheduleOne.UI.Management.ObjectSelector ObjectSelector;

		public global::ScheduleOne.UI.Management.RecipeSelector RecipeSelectorScreen;

		public global::ScheduleOne.UI.Management.TransitEntitySelector TransitEntitySelector;

		public global::ScheduleOne.UI.Management.StringSetter StringSetterScreen;

		public global::UnityEngine.UI.Button RenameButton;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Management.ManagementInterface.ConfigurableTypePanel[] ConfigPanelPrefabs;

		public global::System.Collections.Generic.List<global::ScheduleOne.Management.IConfigurable> Configurables;

		private bool areConfigurablesUniform;

		private global::ScheduleOne.Management.UI.ConfigPanel loadedPanel;

		public global::ScheduleOne.Tools.ManagementClipboard_Equippable EquippedClipboard { get; protected set; }

		protected override void Start()
		{
		}

		public void Open(global::System.Collections.Generic.List<global::ScheduleOne.Management.IConfigurable> configurables, global::ScheduleOne.Tools.ManagementClipboard_Equippable _equippedClipboard)
		{
		}

		public void Close(bool preserveState = false)
		{
		}

		private void UpdateMainLabels()
		{
		}

		private void InitializeConfigPanel()
		{
		}

		private void DestroyConfigPanel()
		{
		}

		public global::ScheduleOne.Management.UI.ConfigPanel GetConfigPanelPrefab(global::ScheduleOne.Management.EConfigurableType type)
		{
			return null;
		}

		public void RenameButtonClicked()
		{
		}
	}
}
