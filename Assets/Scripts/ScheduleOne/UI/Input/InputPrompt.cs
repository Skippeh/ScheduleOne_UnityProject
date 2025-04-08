namespace ScheduleOne.UI.Input
{
	[global::UnityEngine.ExecuteInEditMode]
	public class InputPrompt : global::UnityEngine.MonoBehaviour
	{
		public enum EInputPromptAlignment
		{
			Left = 0,
			Middle = 1,
			Right = 2
		}

		public static float Spacing;

		[global::UnityEngine.Header("Settings")]
		public global::System.Collections.Generic.List<global::UnityEngine.InputSystem.InputActionReference> Actions;

		public string Label;

		public global::ScheduleOne.UI.Input.InputPrompt.EInputPromptAlignment Alignment;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.RectTransform ImagesContainer;

		public global::TMPro.TextMeshProUGUI LabelComponent;

		public global::UnityEngine.RectTransform Shade;

		[global::UnityEngine.Header("Settings")]
		public bool OverridePromptImageColor;

		public global::UnityEngine.Color PromptImageColor;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.UI.Input.PromptImage> promptImages;

		private global::System.Collections.Generic.List<global::UnityEngine.InputSystem.InputActionReference> displayedActions;

		private global::ScheduleOne.UI.Input.InputPrompt.EInputPromptAlignment AppliedAlignment;

		private global::ScheduleOne.UI.Input.InputPromptsManager manager => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void RefreshPromptImages()
		{
		}

		public void SetLabel(string label)
		{
		}

		private void UpdateShade()
		{
		}
	}
}
