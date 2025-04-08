namespace ScheduleOne.Casino.UI
{
	public class BlackjackInterface : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Casino.UI.BlackjackInterface>
	{
		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::ScheduleOne.Casino.UI.CasinoGamePlayerDisplay PlayerDisplay;

		public global::UnityEngine.RectTransform BetContainer;

		public global::TMPro.TextMeshProUGUI BetTitleLabel;

		public global::UnityEngine.UI.Slider BetSlider;

		public global::TMPro.TextMeshProUGUI BetAmount;

		public global::UnityEngine.UI.Button ReadyButton;

		public global::TMPro.TextMeshProUGUI ReadyLabel;

		public global::UnityEngine.RectTransform WaitingContainer;

		public global::TMPro.TextMeshProUGUI WaitingLabel;

		public global::TMPro.TextMeshProUGUI DealerScoreLabel;

		public global::TMPro.TextMeshProUGUI PlayerScoreLabel;

		public global::UnityEngine.UI.Button HitButton;

		public global::UnityEngine.UI.Button StandButton;

		public global::UnityEngine.Animation InputContainerAnimation;

		public global::UnityEngine.CanvasGroup InputContainerCanvasGroup;

		public global::UnityEngine.AnimationClip InputContainerFadeIn;

		public global::UnityEngine.AnimationClip InputContainerFadeOut;

		public global::UnityEngine.RectTransform SelectionIndicator;

		public global::UnityEngine.Animation ScoresContainerAnimation;

		public global::UnityEngine.CanvasGroup ScoresContainerCanvasGroup;

		public global::TMPro.TextMeshProUGUI PositiveOutcomeLabel;

		public global::TMPro.TextMeshProUGUI PayoutLabel;

		public global::UnityEngine.Events.UnityEvent onBust;

		public global::UnityEngine.Events.UnityEvent onBlackjack;

		public global::UnityEngine.Events.UnityEvent onWin;

		public global::UnityEngine.Events.UnityEvent onLose;

		public global::UnityEngine.Events.UnityEvent onPush;

		public global::ScheduleOne.Casino.BlackjackGameController CurrentGame { get; private set; }

		protected override void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		public void Open(global::ScheduleOne.Casino.BlackjackGameController game)
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

		private void LocalPlayerReadyForInput()
		{
		}

		private void ShowScores()
		{
		}

		private void HideScores()
		{
		}

		private void HitClicked()
		{
		}

		private void StandClicked()
		{
		}

		private void LocalPlayerExitRound()
		{
		}

		private void ReadyButtonClicked()
		{
		}

		private void OnLocalPlayerBust()
		{
		}

		private void OnLocalPlayerRoundCompleted(global::ScheduleOne.Casino.BlackjackGameController.EPayoutType payout)
		{
		}
	}
}
