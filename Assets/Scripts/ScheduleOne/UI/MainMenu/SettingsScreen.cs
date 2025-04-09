using System;
using ScheduleOne.UI.Settings;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.MainMenu
{
	public class SettingsScreen : MainMenuScreen
	{
		[Serializable]
		public class SettingsCategory
		{
			public Button Button;

			public GameObject Panel;
		}

		public SettingsCategory[] Categories;

		public Button ApplyDisplayButton;

		public ConfirmDisplaySettings ConfirmDisplaySettings;

		protected override void Awake()
		{
		}

		protected void Start()
		{
		}

		public void ShowCategory(int index)
		{
		}

		public void DisplayChanged()
		{
		}

		private void ApplyDisplaySettings()
		{
		}
	}
}
