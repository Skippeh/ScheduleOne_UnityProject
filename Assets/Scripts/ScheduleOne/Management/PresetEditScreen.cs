using System;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management.Presets;
using ScheduleOne.Management.Presets.Options.SetterScreens;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Management
{
	public class PresetEditScreen : MonoBehaviour
	{
		[Serializable]
		public class OptionData
		{
			public GameObject OptionEntryPrefab;

			public OptionSetterScreen OptionSetterScreen;
		}

		public Preset EditedPreset;

		[Header("References")]
		public RectTransform IconBackgroundRect;

		public Image IconBackground;

		public RectTransform InputFieldRect;

		public TMP_InputField InputField;

		public RectTransform EditButtonRect;

		public Button ReturnButton;

		public Button DeleteButton;

		public bool isOpen => false;

		protected virtual void Awake()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		public virtual void Open(Preset preset)
		{
		}

		public void Close()
		{
		}

		private void RefreshIcon()
		{
		}

		private void RefreshTransforms()
		{
		}

		private void NameFieldChange(string newVal)
		{
		}

		private void NameFieldDone(string piss)
		{
		}

		private bool IsNameAppropriate(string name)
		{
			return false;
		}

		public void DeleteButtonClicked()
		{
		}

		public void ReturnButtonClicked()
		{
		}
	}
}
