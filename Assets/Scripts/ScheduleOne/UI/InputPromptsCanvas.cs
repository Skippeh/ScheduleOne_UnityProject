namespace ScheduleOne.UI
{
	public class InputPromptsCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.InputPromptsCanvas>
	{
		[global::System.Serializable]
		public class Module
		{
			public string key;

			public global::UnityEngine.GameObject module;
		}

		public global::UnityEngine.RectTransform InputPromptsContainer;

		[global::UnityEngine.Header("Input prompt modules")]
		public global::System.Collections.Generic.List<global::ScheduleOne.UI.InputPromptsCanvas.Module> Modules;

		public string currentModuleLabel { get; protected set; }

		public global::UnityEngine.RectTransform currentModule { get; private set; }

		public void LoadModule(string key)
		{
		}

		public void UnloadModule()
		{
		}
	}
}
