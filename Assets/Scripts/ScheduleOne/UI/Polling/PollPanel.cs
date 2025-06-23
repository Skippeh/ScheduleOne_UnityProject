namespace ScheduleOne.UI.Polling
{
	public class PollPanel : global::UnityEngine.MonoBehaviour
	{
		public const float BUTTON_PRESS_TIME = 0.8f;

		public const string ResponseSubmittedMessage = "Your vote has been recorded.\n Thank you!";

		public global::UnityEngine.GameObject ButtonPrefab;

		public global::UnityEngine.Color TextColor_Green;

		public global::UnityEngine.Color TextColor_Red;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Polling.PollManager PollManager;

		public global::UnityEngine.GameObject Container;

		public global::UnityEngine.GameObject ActivePill;

		public global::UnityEngine.GameObject ClosedPill;

		public global::TMPro.TextMeshProUGUI QuestionLabel;

		public global::UnityEngine.RectTransform ButtonContainer;

		public global::TMPro.TextMeshProUGUI InstructionLabel;

		public global::TMPro.TextMeshProUGUI ConfirmationMessageLabel;

		public global::ScheduleOne.Audio.AudioSourceController SubmissionStartSound;

		public global::ScheduleOne.Audio.AudioSourceController SubmissionSuccessSound;

		public global::ScheduleOne.Audio.AudioSourceController SubmissionFailSound;

		private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> buttons;

		private global::System.Collections.Generic.List<global::UnityEngine.UI.Image> buttonFills;

		private int heldButton;

		private int selectedButton;

		private int lastHeldButton;

		private float buttonPressTime;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void DisplayActivePoll(global::ScheduleOne.Polling.PollData poll)
		{
		}

		public void DisplayConfirmedPoll(global::ScheduleOne.Polling.PollData poll)
		{
		}

		private void DisplaySubmittedAnswer(int buttonIndex)
		{
		}

		private void Rebuild()
		{
		}

		private global::System.Collections.Generic.List<global::UnityEngine.UI.Button> CreateButtons(global::ScheduleOne.Polling.PollData data)
		{
			return null;
		}

		private void ButtonPressed(int buttonIndex)
		{
		}

		private void FinalizeButtonPress(int buttonIndex)
		{
		}
	}
}
