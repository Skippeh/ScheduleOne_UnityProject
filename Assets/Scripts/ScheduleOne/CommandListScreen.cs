using System.Collections.Generic;
using ScheduleOne.UI.MainMenu;
using UnityEngine;

namespace ScheduleOne
{
	public class CommandListScreen : MainMenuScreen
	{
		public RectTransform CommandEntryContainer;

		public RectTransform CommandEntryPrefab;

		private List<RectTransform> commandEntries;

		private void Start()
		{
		}
	}
}
