using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class ItemSelector : ClipboardScreen
	{
		[Serializable]
		public class Option
		{
			public string Title;

			public ItemDefinition Item;

			public Option(string title, ItemDefinition item)
			{
			}
		}

		[Header("References")]
		public RectTransform OptionContainer;

		public TextMeshProUGUI TitleLabel;

		public TextMeshProUGUI HoveredItemLabel;

		public GameObject OptionPrefab;

		[Header("Settings")]
		public Sprite EmptyOptionSprite;

		private Coroutine lerpRoutine;

		private List<Option> options;

		private Option selectedOption;

		private List<RectTransform> optionButtons;

		private Action<Option> optionCallback;

		public void Initialize(string selectionTitle, List<Option> _options, Option _selectedOption = null, Action<Option> _optionCallback = null)
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		private void ButtonClicked(Option option)
		{
		}

		private void ButtonHovered(Option option)
		{
		}

		private void ButtonHoverEnd(Option option)
		{
		}

		private void CreateOptions(List<Option> options)
		{
		}

		private void DeleteOptions()
		{
		}
	}
}
