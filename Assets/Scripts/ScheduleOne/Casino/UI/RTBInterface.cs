namespace ScheduleOne.Casino.UI
{
	public class RTBInterface : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Casino.UI.RTBInterface>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::ScheduleOne.Casino.UI.CasinoGamePlayerDisplay PlayerDisplay;

		public global::TMPro.TextMeshProUGUI StatusLabel;

		public global::UnityEngine.RectTransform BetContainer;

		public global::TMPro.TextMeshProUGUI BetTitleLabel;

		public global::UnityEngine.UI.Slider BetSlider;

		public global::TMPro.TextMeshProUGUI BetAmount;

		public global::UnityEngine.UI.Button ReadyButton;

		public global::TMPro.TextMeshProUGUI ReadyLabel;

		public global::TMPro.TextMeshProUGUI WinningsMultiplierLabel;

		[global::UnityEngine.Header("Question and answers")]
		public global::UnityEngine.RectTransform QuestionContainer;

		public global::TMPro.TextMeshProUGUI QuestionLabel;

		public global::UnityEngine.UI.Slider TimerSlider;

		public global::UnityEngine.UI.Button[] AnswerButtons;

		public global::TMPro.TextMeshProUGUI[] AnswerLabels;

		public global::UnityEngine.UI.Button ForfeitButton;

		public global::TMPro.TextMeshProUGUI ForfeitLabel;

		public global::UnityEngine.Animation QuestionContainerAnimation;

		public global::UnityEngine.AnimationClip QuestionContainerFadeIn;

		public global::UnityEngine.AnimationClip QuestionContainerFadeOut;

		public global::UnityEngine.CanvasGroup QuestionCanvasGroup;

		public global::UnityEngine.RectTransform SelectionIndicator;

		public global::UnityEngine.Events.UnityEvent onCorrect;

		public global::UnityEngine.Events.UnityEvent onFinalCorrect;

		public global::UnityEngine.Events.UnityEvent onIncorrect;

		public global::ScheduleOne.Casino.RTBGameController CurrentGame { get; private set; }

		protected override void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		private string GetStatusText()
		{
			return null;
		}

		public void Open(global::ScheduleOne.Casino.RTBGameController game)
		{
		}

		public void Close()
		{
		}

		private void BetSliderChanged(float newValue)
		{
		}

		private float GetBetFromSliderValue(float sliderVal)
		{
			return 0f;
		}

		private void RefreshDisplayedBet()
		{
		}

		private void RefreshReadyButton()
		{
		}

		private void QuestionReady(string question, string[] answers)
		{
		}

		private void AnswerButtonClicked(int index)
		{
		}

		private void ForfeitClicked()
		{
		}

		private void QuestionDone()
		{
		}

		private void LocalPlayerExitRound()
		{
		}

		private void Correct()
		{
		}

		private void Incorrect()
		{
		}

		private void ReadyButtonClicked()
		{
		}
	}
}
