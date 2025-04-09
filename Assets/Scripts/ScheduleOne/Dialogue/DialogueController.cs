using System;
using System.Collections.Generic;
using ScheduleOne.Interaction;
using ScheduleOne.NPCs;
using ScheduleOne.VoiceOver;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Dialogue
{
	public class DialogueController : MonoBehaviour
	{
		[Serializable]
		public class DialogueChoice
		{
			public delegate bool ShouldShowCheck(bool enabled);

			public delegate bool IsChoiceValid(out string invalidReason);

			public bool Enabled;

			public string ChoiceText;

			public DialogueContainer Conversation;

			public UnityEvent onChoosen;

			public ShouldShowCheck shouldShowCheck;

			public IsChoiceValid isValidCheck;

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

		[Serializable]
		public class GreetingOverride
		{
			public string Greeting;

			public bool ShouldShow;

			public bool PlayVO;

			public EVOLineType VOType;
		}

		public static float GREETING_COOLDOWN;

		[Header("References")]
		public InteractableObject IntObj;

		public DialogueContainer GenericDialogue;

		[Header("Settings")]
		public bool DialogueEnabled;

		public bool UseDialogueBehaviour;

		public List<DialogueChoice> Choices;

		public List<GreetingOverride> GreetingOverrides;

		public DialogueContainer OverrideContainer;

		protected NPC npc;

		protected DialogueHandler handler;

		private float lastGreetingTime;

		private List<DialogueChoice> shownChoices;

		private bool dialogueQueued;

		private string cachedGreeting;

		protected virtual void Start()
		{
		}

		private void Update()
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

		private string GetActiveGreeting(out bool playVO, out EVOLineType voLineType)
		{
			playVO = default(bool);
			voLineType = default(EVOLineType);
			return null;
		}

		private List<DialogueChoice> GetActiveChoices()
		{
			return null;
		}

		protected virtual bool GetCustomGreeting(out string greeting, out bool playVO, out EVOLineType voLineType)
		{
			greeting = null;
			playVO = default(bool);
			voLineType = default(EVOLineType);
			return false;
		}

		public virtual int AddDialogueChoice(DialogueChoice data, int priority = 0)
		{
			return 0;
		}

		public virtual int AddGreetingOverride(GreetingOverride data)
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

		public virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
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

		public void SetOverrideContainer(DialogueContainer container)
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
