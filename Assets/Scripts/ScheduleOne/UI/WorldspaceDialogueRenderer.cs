using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class WorldspaceDialogueRenderer : MonoBehaviour
	{
		private const float FadeDist = 2f;

		[Header("Settings")]
		public float MaxRange;

		public float BaseScale;

		public AnimationCurve Scale;

		public Vector2 Padding;

		public Vector3 WorldSpaceOffset;

		[Header("References")]
		public Canvas Canvas;

		public CanvasGroup CanvasGroup;

		public RectTransform Background;

		public TextMeshProUGUI Text;

		public Animation Anim;

		private Vector3 localOffset;

		private float CurrentOpacity;

		private Coroutine hideCoroutine;

		public string ShownText { get; protected set; }

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdatePosition()
		{
		}

		public void ShowText(string text, float duration = 0f)
		{
		}

		public void HideText()
		{
		}

		private void SetOpacity(float op)
		{
		}
	}
}
