namespace ScheduleOne.UI.Construction.Features
{
	public class FI_ColorPicker : global::ScheduleOne.UI.Construction.Features.FI_Base
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform colorButtonContainer;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Button buyButton;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI buyButtonText;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI colorLabel;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform bar;

		[global::UnityEngine.Header("Prefab")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject colorButtonPrefab;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Construction.Features.ColorFeature.NamedColor> onSelectionChanged;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Construction.Features.ColorFeature.NamedColor> onSelectionPurchased;

		private global::ScheduleOne.Construction.Features.ColorFeature specificFeature;

		private int selectionIndex;

		public override void Initialize(global::ScheduleOne.Construction.Features.Feature _feature)
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
