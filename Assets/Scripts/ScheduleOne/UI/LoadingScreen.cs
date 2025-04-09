using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class LoadingScreen : PersistentSingleton<LoadingScreen>
	{
		public const float FADE_TIME = 0.25f;

		public const float BACKGROUND_IMAGE_TIME = 8f;

		public const float BACKGROUND_IMAGE_FADE_TIME = 1f;

		public StringDatabase LoadingMessagesDatabase;

		public Sprite[] BackgroundImages;

		public Sprite[] TutorialBackgroundImages;

		[Header("References")]
		public Canvas Canvas;

		public CanvasGroup Group;

		public TextMeshProUGUI LoadStatusLabel;

		public TextMeshProUGUI LoadingMessageLabel;

		public Image BackgroundImage1;

		public Image BackgroundImage2;

		public RectTransform TutorialContainer;

		public RectTransform CoopTutorialHint;

		private string[] loadingMessages;

		private int currentBackgroundImageIndex;

		private Coroutine fadeRoutine;

		private Coroutine animateBackgroundRoutine;

		private Coroutine scaleBackgroundRoutine;

		private bool isLoadingTutorial;

		public bool IsOpen { get; protected set; }

		public Sprite[] ContextualBackgroundImages => null;

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
