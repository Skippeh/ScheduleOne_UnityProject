namespace ScheduleOne.UI
{
	public class DialogueCanvas : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.DialogueCanvas>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CChoiceSelectionResidual_003Ed__23 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float fadeTime;

			public global::ScheduleOne.UI.DialogueChoiceEntry choice;

			public global::ScheduleOne.UI.DialogueCanvas _003C_003E4__this;

			private float _003CrealFadeTime_003E5__2;

			private float _003Ci_003E5__3;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CChoiceSelectionResidual_003Ed__23(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRolloutDialogue_003Ed__21 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string text;

			public global::ScheduleOne.UI.DialogueCanvas _003C_003E4__this;

			public global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> choices;

			private global::System.Collections.Generic.List<int> _003CactiveDialogueChoices_003E5__2;

			private float _003CrolloutTime_003E5__3;

			private float _003Ci_003E5__4;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CRolloutDialogue_003Ed__21(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		public const float TIME_PER_CHAR = 0.015f;

		public bool SkipNextRollout;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Canvas canvas;

		public global::UnityEngine.RectTransform Container;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI dialogueText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject continuePopup;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.UI.DialogueChoiceEntry> dialogueChoices;

		private global::ScheduleOne.Dialogue.DialogueHandler currentHandler;

		private global::ScheduleOne.Dialogue.DialogueNodeData currentNode;

		private bool spaceDownThisFrame;

		private bool leftClickThisFrame;

		private string overrideText;

		private global::UnityEngine.Coroutine dialogueRollout;

		private global::UnityEngine.Coroutine choiceSelectionResidualCoroutine;

		private bool hasChoiceBeenSelected;

		public bool isActive => false;

		protected override void Awake()
		{
		}

		public void DisplayDialogueNode(global::ScheduleOne.Dialogue.DialogueHandler diag, global::ScheduleOne.Dialogue.DialogueNodeData node, string dialogueText, global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> choices)
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

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.DialogueCanvas._003CRolloutDialogue_003Ed__21))]
		protected global::System.Collections.IEnumerator RolloutDialogue(string text, global::System.Collections.Generic.List<global::ScheduleOne.Dialogue.DialogueChoiceData> choices)
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.DialogueCanvas._003CChoiceSelectionResidual_003Ed__23))]
		private global::System.Collections.IEnumerator ChoiceSelectionResidual(global::ScheduleOne.UI.DialogueChoiceEntry choice, float fadeTime)
		{
			return null;
		}

		private void StartDialogue(global::ScheduleOne.Dialogue.DialogueHandler handler)
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
