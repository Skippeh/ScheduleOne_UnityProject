namespace ScheduleOne.Dialogue
{
	public class DialogueController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class DialogueChoice
		{
			public delegate bool ShouldShowCheck(bool enabled);

			public delegate bool IsChoiceValid(out string invalidReason);

			public bool Enabled;

			public string ChoiceText;

			public bool ShowWorldspaceDialogue;

			public global::ScheduleOne.Dialogue.DialogueContainer Conversation;

			public global::UnityEngine.Events.UnityEvent onChoosen;

			public global::ScheduleOne.Dialogue.DialogueController.DialogueChoice.ShouldShowCheck shouldShowCheck;

			public global::ScheduleOne.Dialogue.DialogueController.DialogueChoice.IsChoiceValid isValidCheck;

			public int Priority;

			public bool ShouldShow()
			{
				return false;
			}

			public bool IsValid(out string invalidReason)
			{
				invalidReason = null;
				return false;
			}
		}

		[global::System.Serializable]
		public class GreetingOverride
		{
			public string Greeting;

			public bool ShouldShow;

			public bool PlayVO;

			public global::ScheduleOne.VoiceOver.EVOLineType VOType;
		}

		public static float GREETING_COOLDOWN;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::ScheduleOne.Dialogue.DialogueContainer GenericDialogue;

		[global::UnityEngine.Header("Settings")]
		public bool DialogueEnabled;

		public bool UseDialogueBehaviour;

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueController.DialogueChoice> Choices;

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueController.GreetingOverride> GreetingOverrides;

		public global::ScheduleOne.Dialogue.DialogueContainer OverrideContainer;

		protected global::ScheduleOne.NPCs.NPC npc;

		protected global::ScheduleOne.Dialogue.DialogueHandler handler;

		private float lastGreetingTime;

		private global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueController.DialogueChoice> shownChoices;

		private bool dialogueQueued;

		private string cachedGreeting;

		protected virtual void Start()
		{
		}

		private void Hovered()
		{
		}

		public void StartGenericDialogue(bool allowExit = true)
		{
		}

		private void Interacted()
		{
		}

		private void Unqueue()
		{
		}

		private string GetActiveGreeting(out bool playVO, out global::ScheduleOne.VoiceOver.EVOLineType voLineType)
		{
			playVO = default(bool);
			voLineType = default(global::ScheduleOne.VoiceOver.EVOLineType);
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueController.DialogueChoice> GetActiveChoices()
		{
			return null;
		}

		protected virtual bool GetCustomGreeting(out string greeting, out bool playVO, out global::ScheduleOne.VoiceOver.EVOLineType voLineType)
		{
			greeting = null;
			playVO = default(bool);
			voLineType = default(global::ScheduleOne.VoiceOver.EVOLineType);
			return false;
		}

		public virtual int AddDialogueChoice(global::ScheduleOne.Dialogue.DialogueController.DialogueChoice data, int priority = 0)
		{
			return 0;
		}

		public virtual int AddGreetingOverride(global::ScheduleOne.Dialogue.DialogueController.GreetingOverride data)
		{
			return 0;
		}

		public virtual bool CanStartDialogue()
		{
			return false;
		}

		public virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		public virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		public virtual void ModifyChoiceList(string dialogueLabel, ref global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> existingChoices)
		{
		}

		public virtual void ChoiceCallback(string choiceLabel)
		{
		}

		public virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public void SetOverrideContainer(global::ScheduleOne.Dialogue.DialogueContainer container)
		{
		}

		public void ClearOverrideContainer()
		{
		}

		public virtual bool DecideBranch(string branchLabel, out int index)
		{
			index = default(int);
			return false;
		}

		public void SetDialogueEnabled(bool enabled)
		{
		}
	}
}
