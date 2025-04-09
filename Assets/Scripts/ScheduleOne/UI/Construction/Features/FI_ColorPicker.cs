using ScheduleOne.Construction.Features;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Construction.Features
{
	public class FI_ColorPicker : FI_Base
	{
		[Header("References")]
		[SerializeField]
		protected RectTransform colorButtonContainer;

		[SerializeField]
		protected Button buyButton;

		[SerializeField]
		protected TextMeshProUGUI buyButtonText;

		[SerializeField]
		protected TextMeshProUGUI colorLabel;

		[SerializeField]
		protected RectTransform bar;

		[Header("Prefab")]
		[SerializeField]
		protected GameObject colorButtonPrefab;

		public UnityEvent<ColorFeature.NamedColor> onSelectionChanged;

		public UnityEvent<ColorFeature.NamedColor> onSelectionPurchased;

		private ColorFeature specificFeature;

		private int selectionIndex;

		public override void Initialize(Feature _feature)
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
