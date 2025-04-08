namespace ScheduleOne.UI.Input
{
	public class InputPromptsManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Input.InputPromptsManager>
	{
		[global::UnityEngine.Header("Input Prompt Prefabs")]
		public global::UnityEngine.GameObject KeyPromptPrefab;

		public global::UnityEngine.GameObject WideKeyPromptPrefab;

		public global::UnityEngine.GameObject ExtraWideKeyPromptPrefab;

		public global::UnityEngine.GameObject LeftClickPromptPrefab;

		public global::UnityEngine.GameObject MiddleClickPromptPrefab;

		public global::UnityEngine.GameObject RightClickPromptPrefab;

		public global::ScheduleOne.UI.Input.PromptImage GetPromptImage(string controlPath, global::UnityEngine.RectTransform parent)
		{
			return null;
		}

		private bool IsControlPathMouseRelated(string controlPath)
		{
			return false;
		}

		private bool IsControlPathWideKey(string controlPath)
		{
			return false;
		}

		private bool IsControlPathExtraWideKey(string controlPath)
		{
			return false;
		}

		public string GetDisplayNameForControlPath(string controlPath)
		{
			return null;
		}
	}
}
