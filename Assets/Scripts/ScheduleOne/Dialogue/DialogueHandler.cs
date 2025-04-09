using System.Collections.Generic;
using ScheduleOne.NPCs;
using ScheduleOne.UI;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	public class DialogueHandler : MonoBehaviour
	{
		public const float TimePerChar = 0.2f;

		public const float WorldspaceDialogueMinDuration = 1.5f;

		public const float WorldspaceDialogueMaxDuration = 5f;

		public static DialogueContainer activeDialogue;

		public static DialogueNodeData activeDialogueNode;

		public DialogueDatabase Database;

		[Header("References")]
		public Transform LookPosition;

		public WorldspaceDialogueRenderer WorldspaceRend;

		public VOEmitter VOEmitter;

		[HideInInspector]
		public List<DialogueChoiceData> CurrentChoices;

		[Header("Events")]
		public DialogueEvent[] DialogueEvents;

		public UnityEvent onConversationStart;

		public UnityEvent<string> onDialogueNodeDisplayed;

		public UnityEvent<string> onDialogueChoiceChosen;

		protected string overrideText;

		[SerializeField]
		private List<DialogueContainer> dialogueContainers;

		private List<NodeLinkData> TempLinks;

		private bool skipNextDialogueBehaviourEnd;

		private bool passChecked;

		public bool IsPlaying { get; private set; }

		public NPC NPC { get; protected set; }

		private DialogueCanvas canvas => null;

		public List<DialogueModule> runtimeModules { get; private set; }

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public void InitializeDialogue(DialogueContainer container)
		{
		}

		public void InitializeDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
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

		protected virtual DialogueNodeData FinalizeDialogueNode(DialogueNodeData data)
		{
			return null;
		}

		public void ShowNode(DialogueNodeData node)
		{
		}

		private void EvaluateBranch(BranchNodeData node)
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

		protected virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
		}

		protected void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID)
		{
		}

		private NodeLinkData GetLink(string baseChoiceOrOptionGUID)
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
