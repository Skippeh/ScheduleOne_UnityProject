using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.Casino.UI
{
	public class RTBInterface : Singleton<RTBInterface>
	{
		[Header("References")]
		public Canvas Canvas;

		public CasinoGamePlayerDisplay PlayerDisplay;

		public TextMeshProUGUI StatusLabel;

		public RectTransform BetContainer;

		public TextMeshProUGUI BetTitleLabel;

		public Slider BetSlider;

		public TextMeshProUGUI BetAmount;

		public Button ReadyButton;

		public TextMeshProUGUI ReadyLabel;

		public TextMeshProUGUI WinningsMultiplierLabel;

		[Header("Question and answers")]
		public RectTransform QuestionContainer;

		public TextMeshProUGUI QuestionLabel;

		public Slider TimerSlider;

		public Button[] AnswerButtons;

		public TextMeshProUGUI[] AnswerLabels;

		public Button ForfeitButton;

		public TextMeshProUGUI ForfeitLabel;

		public Animation QuestionContainerAnimation;

		public AnimationClip QuestionContainerFadeIn;

		public AnimationClip QuestionContainerFadeOut;

		public CanvasGroup QuestionCanvasGroup;

		public RectTransform SelectionIndicator;

		public UnityEvent onCorrect;

		public UnityEvent onFinalCorrect;

		public UnityEvent onIncorrect;

		public RTBGameController CurrentGame { get; private set; }

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

		public void Open(RTBGameController game)
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
