using System.Collections.Generic;
using ScheduleOne.Construction.Features;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI.Construction.Features
{
	public class FI_OptionList : FI_Base
	{
		public class Option
		{
			public string optionLabel;

			public Color optionColor;

			public float optionPrice;

			public Option(string _optionLabel, Color _optionColor, float _optionPrice)
			{
			}
		}

		[Header("References")]
		[SerializeField]
		protected RectTransform buttonContainer;

		[SerializeField]
		protected Button buyButton;

		[SerializeField]
		protected TextMeshProUGUI buyButtonText;

		[SerializeField]
		protected RectTransform bar;

		[Header("Prefab")]
		[SerializeField]
		protected GameObject buttonPrefab;

		public UnityEvent<int> onSelectionChanged;

		public UnityEvent<int> onSelectionPurchased;

		private List<Option> options;

		public OptionListFeature specificFeature;

		private int selectionIndex;

		public virtual void Initialize(OptionListFeature _feature, List<Option> _options)
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
