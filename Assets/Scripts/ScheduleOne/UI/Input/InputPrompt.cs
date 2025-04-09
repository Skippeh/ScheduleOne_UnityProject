using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne.UI.Input
{
	[ExecuteInEditMode]
	public class InputPrompt : MonoBehaviour
	{
		public enum EInputPromptAlignment
		{
			Left = 0,
			Middle = 1,
			Right = 2
		}

		public static float Spacing;

		[Header("Settings")]
		public List<InputActionReference> Actions;

		public string Label;

		public EInputPromptAlignment Alignment;

		[Header("References")]
		public RectTransform Container;

		public RectTransform ImagesContainer;

		public TextMeshProUGUI LabelComponent;

		public RectTransform Shade;

		[Header("Settings")]
		public bool OverridePromptImageColor;

		public Color PromptImageColor;

		[SerializeField]
		private List<PromptImage> promptImages;

		private List<InputActionReference> displayedActions;

		private EInputPromptAlignment AppliedAlignment;

		private InputPromptsManager manager => null;

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
