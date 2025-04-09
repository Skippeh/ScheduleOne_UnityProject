using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class InputPromptsCanvas : Singleton<InputPromptsCanvas>
	{
		[Serializable]
		public class Module
		{
			public string key;

			public GameObject module;
		}

		public RectTransform InputPromptsContainer;

		[Header("Input prompt modules")]
		public List<Module> Modules;

		public string currentModuleLabel { get; protected set; }

		public RectTransform currentModule { get; private set; }

		public void LoadModule(string key)
		{
		}

		public void UnloadModule()
		{
		}
	}
}
