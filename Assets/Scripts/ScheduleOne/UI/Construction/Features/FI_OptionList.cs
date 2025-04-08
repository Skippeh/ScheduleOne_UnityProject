namespace ScheduleOne.UI.Construction.Features
{
	public class FI_OptionList : global::ScheduleOne.UI.Construction.Features.FI_Base
	{
		public class Option
		{
			public string optionLabel;

			public global::UnityEngine.Color optionColor;

			public float optionPrice;

			public Option(string _optionLabel, global::UnityEngine.Color _optionColor, float _optionPrice)
			{
			}
		}

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform buttonContainer;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button buyButton;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI buyButtonText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform bar;

		[global::UnityEngine.Header("Prefab")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject buttonPrefab;

		public global::UnityEngine.Events.UnityEvent<int> onSelectionChanged;

		public global::UnityEngine.Events.UnityEvent<int> onSelectionPurchased;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Construction.Features.FI_OptionList.Option> options;

		public global::ScheduleOne.Construction.Features.OptionListFeature specificFeature;

		private int selectionIndex;

		public virtual void Initialize(global::ScheduleOne.Construction.Features.OptionListFeature _feature, global::System.Collections.Generic.List<global::ScheduleOne.UI.Construction.Features.FI_OptionList.Option> _options)
		{
		}

		public override void Close()
		{
		}

		public void BuyButtonClicked()
		{
		}

		public void Select(int index)
		{
		}

		private void UpdateSelection()
		{
		}
	}
}
