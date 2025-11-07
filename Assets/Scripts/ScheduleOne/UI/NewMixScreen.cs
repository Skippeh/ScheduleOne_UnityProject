namespace ScheduleOne.UI
{
	public class NewMixScreen : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.NewMixScreen>
	{
		public const int MAX_PROPERTIES_DISPLAYED = 5;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Canvas canvas;

		public global::UnityEngine.RectTransform Container;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TMP_InputField nameInputField;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject mixAlreadyExistsText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform editIcon;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button randomizeNameButton;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button confirmButton;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI PropertiesLabel;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI MarketValueLabel;

		public global::ScheduleOne.Audio.AudioSourceController Sound;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject attributeEntryPrefab;

		[global::UnityEngine.Header("Name Library")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<string> name1Library;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<string> name2Library;

		public global::System.Action<string> onMixNamed;

		public bool IsOpen => false;

		protected override void Awake()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		protected virtual void Update()
		{
		}

		public void Open(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties, global::ScheduleOne.Product.EDrugType drugType, float productMarketValue)
		{
		}

		public void Close()
		{
		}

		public void RandomizeButtonClicked()
		{
		}

		public void ConfirmButtonClicked()
		{
		}

		public string GenerateUniqueName(global::ScheduleOne.Effects.Effect[] properties = null, global::ScheduleOne.Product.EDrugType drugType = global::ScheduleOne.Product.EDrugType.Marijuana)
		{
			return null;
		}

		protected void RefreshNameButtons()
		{
		}

		public void OnNameValueChanged(string newVal)
		{
		}
	}
}
