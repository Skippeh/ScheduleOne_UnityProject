using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Input;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class HintDisplay : Singleton<HintDisplay>
	{
		private class Hint
		{
			public string Text;

			public float Duration;

			public Hint(string text, float duration)
			{
			}
		}

		public const float FadeTime = 0.3f;

		[Header("References")]
		public RectTransform Container;

		public TextMeshProUGUI Label;

		public CanvasGroup Group;

		public InputPrompt DismissPrompt;

		public Animation FlashAnim;

		[Header("Settings")]
		public Vector2 Padding;

		public Vector2 Offset;

		private Coroutine autoCloseRoutine;

		private Coroutine fadeRoutine;

		private List<Hint> hintQueue;

		private float timeSinceOpened;

		public bool IsOpen { get; protected set; }

		protected override void Start()
		{
		}

		public void Update()
		{
		}

		public void ShowHint_10s(string text)
		{
		}

		public void ShowHint_20s(string text)
		{
		}

		public void ShowHint(string text)
		{
		}

		public void ShowHint(string text, float autoCloseTime = 0f)
		{
		}

		public void Hide()
		{
		}

		private void SetAlpha(float alpha)
		{
		}

		public void QueueHint_10s(string message)
		{
		}

		public void QueueHint_20s(string message)
		{
		}

		public void QueueHint(string message, float time)
		{
		}

		private string ProcessText(string text)
		{
			return null;
		}
	}
}
