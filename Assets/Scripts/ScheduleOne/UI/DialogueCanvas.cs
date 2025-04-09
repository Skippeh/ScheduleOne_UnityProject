using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class DialogueCanvas : Singleton<DialogueCanvas>
	{
		[CompilerGenerated]
		private sealed class _003CChoiceSelectionResidual_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float fadeTime;

			public DialogueChoiceEntry choice;

			public DialogueCanvas _003C_003E4__this;

			private float _003CrealFadeTime_003E5__2;

			private float _003Ci_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CChoiceSelectionResidual_003Ed__23(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CRolloutDialogue_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DialogueCanvas _003C_003E4__this;

			public string text;

			public List<string> choices;

			private List<int> _003CactiveDialogueChoices_003E5__2;

			private float _003CrolloutTime_003E5__3;

			private float _003Ci_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRolloutDialogue_003Ed__21(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public const float TIME_PER_CHAR = 0.015f;

		public bool SkipNextRollout;

		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		public RectTransform Container;

		[SerializeField]
		protected TextMeshProUGUI dialogueText;

		[SerializeField]
		protected GameObject continuePopup;

		[SerializeField]
		protected List<DialogueChoiceEntry> dialogueChoices;

		private DialogueHandler currentHandler;

		private DialogueNodeData currentNode;

		private bool spaceDownThisFrame;

		private bool leftClickThisFrame;

		private string overrideText;

		private Coroutine dialogueRollout;

		private Coroutine choiceSelectionResidualCoroutine;

		private bool hasChoiceBeenSelected;

		public bool isActive => false;

		protected override void Awake()
		{
		}

		public void DisplayDialogueNode(DialogueHandler diag, DialogueNodeData node, string dialogueText, List<string> choices)
		{
		}

		public void OverrideText(string text)
		{
		}

		public void StopTextOverride()
		{
		}

		private void Update()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		[IteratorStateMachine(typeof(_003CRolloutDialogue_003Ed__21))]
		protected IEnumerator RolloutDialogue(string text, List<string> choices)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CChoiceSelectionResidual_003Ed__23))]
		private IEnumerator ChoiceSelectionResidual(DialogueChoiceEntry choice, float fadeTime)
		{
			return null;
		}

		private void StartDialogue(DialogueHandler handler)
		{
		}

		public void EndDialogue()
		{
		}

		public void ChoiceSelected(int choiceIndex)
		{
		}

		private bool IsChoiceValid(int choiceIndex, out string reason)
		{
			reason = null;
			return false;
		}
	}
}
