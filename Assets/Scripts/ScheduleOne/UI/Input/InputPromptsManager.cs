using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.Input
{
	public class InputPromptsManager : Singleton<InputPromptsManager>
	{
		[Header("Input Prompt Prefabs")]
		public GameObject KeyPromptPrefab;

		public GameObject WideKeyPromptPrefab;

		public GameObject ExtraWideKeyPromptPrefab;

		public GameObject LeftClickPromptPrefab;

		public GameObject MiddleClickPromptPrefab;

		public GameObject RightClickPromptPrefab;

		public PromptImage GetPromptImage(string controlPath, RectTransform parent)
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
