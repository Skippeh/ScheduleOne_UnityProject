namespace ScheduleOne.UI
{
	public class LoadingScreen : global::ScheduleOne.DevUtilities.PersistentSingleton<global::ScheduleOne.UI.LoadingScreen>
	{
		public const float FADE_TIME = 0.25f;

		public const float BACKGROUND_IMAGE_TIME = 8f;

		public const float BACKGROUND_IMAGE_FADE_TIME = 1f;

		public global::ScheduleOne.ScriptableObjects.StringDatabase LoadingMessagesDatabase;

		public global::UnityEngine.Sprite[] BackgroundImages;

		public global::UnityEngine.Sprite[] TutorialBackgroundImages;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.CanvasGroup Group;

		public global::TMPro.TextMeshProUGUI LoadStatusLabel;

		public global::TMPro.TextMeshProUGUI LoadingMessageLabel;

		public global::UnityEngine.UI.Image BackgroundImage1;

		public global::UnityEngine.UI.Image BackgroundImage2;

		public global::UnityEngine.RectTransform TutorialContainer;

		public global::UnityEngine.RectTransform CoopTutorialHint;

		private string[] loadingMessages;

		private int currentBackgroundImageIndex;

		private global::UnityEngine.Coroutine fadeRoutine;

		private global::UnityEngine.Coroutine animateBackgroundRoutine;

		private global::UnityEngine.Coroutine scaleBackgroundRoutine;

		private bool isLoadingTutorial;

		public bool IsOpen { get; protected set; }

		public global::UnityEngine.Sprite[] ContextualBackgroundImages => null;

		protected override void Awake()
		{
		}

		protected void Update()
		{
		}

		public void Open(bool loadingTutorial = false)
		{
		}

		public void Close()
		{
		}

		private void AnimateBackground()
		{
		}

		private void Fade(float endAlpha)
		{
		}
	}
}
