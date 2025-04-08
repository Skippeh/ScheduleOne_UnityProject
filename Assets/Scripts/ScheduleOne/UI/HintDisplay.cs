namespace ScheduleOne.UI
{
	public class HintDisplay : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.HintDisplay>
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

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Container;

		public global::TMPro.TextMeshProUGUI Label;

		public global::UnityEngine.CanvasGroup Group;

		public global::ScheduleOne.UI.Input.InputPrompt DismissPrompt;

		public global::UnityEngine.Animation FlashAnim;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Vector2 Padding;

		public global::UnityEngine.Vector2 Offset;

		private global::UnityEngine.Coroutine autoCloseRoutine;

		private global::UnityEngine.Coroutine fadeRoutine;

		private global::System.Collections.Generic.List<global::ScheduleOne.UI.HintDisplay.Hint> hintQueue;

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
