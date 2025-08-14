namespace ScheduleOne.Dialogue
{
	public class DialogueHandler : global::UnityEngine.MonoBehaviour
	{
		public const float TimePerChar = 0.2f;

		public const float WorldspaceDialogueMinDuration = 1.5f;

		public const float WorldspaceDialogueMaxDuration = 5f;

		public static global::ScheduleOne.Dialogue.DialogueContainer activeDialogue;

		public static global::ScheduleOne.Dialogue.DialogueNodeData activeDialogueNode;

		public global::ScheduleOne.Dialogue.DialogueDatabase Database;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform LookPosition;

		public global::ScheduleOne.UI.WorldspaceDialogueRenderer WorldspaceRend;

		public global::ScheduleOne.VoiceOver.VOEmitter VOEmitter;

		[global::UnityEngine.HideInInspector]
		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> CurrentChoices;

		[global::UnityEngine.Header("Events")]
		public global::ScheduleOne.Dialogue.DialogueEvent[] DialogueEvents;

		public global::UnityEngine.Events.UnityEvent onConversationStart;

		public global::UnityEngine.Events.UnityEvent<string> onDialogueNodeDisplayed;

		public global::UnityEngine.Events.UnityEvent<string> onDialogueChoiceChosen;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueContainer> dialogueContainers;

		protected string overrideText;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.NodeLinkData> tempLinks;

		protected bool skipNextDialogueBehaviourEnd;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> finalChoices;

		private bool passChecked;

		public bool IsDialogueInProgress { get; private set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueModule> runtimeModules { get; private set; }

		public global::ScheduleOne.NPCs.NPC NPC { get; protected set; }

		protected global::ScheduleOne.UI.DialogueCanvas canvas => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public void InitializeDialogue(global::ScheduleOne.Dialogue.DialogueContainer container)
		{
		}

		public void InitializeDialogue(global::ScheduleOne.Dialogue.DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
		}

		public void InitializeDialogue(string dialogueContainerName, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
		}

		public virtual bool CanBeginConversation()
		{
			return false;
		}

		public void OverrideShownDialogue(string _overrideText)
		{
		}

		public void StopOverride()
		{
		}

		public virtual void EndDialogue()
		{
		}

		public void SkipNextDialogueBehaviourEnd()
		{
		}

		protected virtual global::ScheduleOne.Dialogue.DialogueNodeData FinalizeDialogueNode(global::ScheduleOne.Dialogue.DialogueNodeData data)
		{
			return null;
		}

		public void ShowNode(global::ScheduleOne.Dialogue.DialogueNodeData node)
		{
		}

		private void EvaluateBranch(global::ScheduleOne.Dialogue.BranchNodeData node)
		{
		}

		public void ChoiceSelected(int choiceIndex)
		{
		}

		public void ContinueSubmitted()
		{
		}

		public virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		public virtual bool ShouldChoiceBeShown(string choiceLabel)
		{
			return false;
		}

		protected virtual int CheckBranch(string branchLabel)
		{
			return 0;
		}

		protected virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			return null;
		}

		protected virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			return null;
		}

		protected virtual void ChoiceCallback(string choiceLabel)
		{
		}

		protected virtual void DialogueCallback(string dialogueLabel)
		{
		}

		protected virtual void ModifyChoiceList(string dialogueLabel, ref global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> existingChoices)
		{
		}

		protected void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID)
		{
		}

		private global::ScheduleOne.Dialogue.NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			return null;
		}

		public virtual void Hovered()
		{
		}

		public virtual void Interacted()
		{
		}

		public virtual void PlayReaction_Local(string key)
		{
		}

		public virtual void PlayReaction_Networked(string key)
		{
		}

		public virtual void PlayReaction(string key, float duration, bool network)
		{
		}

		public virtual void HideWorldspaceDialogue()
		{
		}

		public virtual void ShowWorldspaceDialogue(string text, float duration)
		{
		}

		public virtual void ShowWorldspaceDialogue_5s(string text)
		{
		}
	}
}
