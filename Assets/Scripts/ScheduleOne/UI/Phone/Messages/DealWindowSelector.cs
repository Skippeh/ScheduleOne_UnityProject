namespace ScheduleOne.UI.Phone.Messages
{
	public class DealWindowSelector : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDelaySelectPanel_003Ed__24 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Phone.Messages.DealWindowSelector _003C_003E4__this;

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
			public _003CDelaySelectPanel_003Ed__24(int _003C_003E1__state)
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

		public const float TIME_ARM_ROTATION_0000 = 0f;

		public const float TIME_ARM_ROTATION_2400 = -360f;

		public const int WINDOW_CUTOFF_MINS = 120;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Economy.EDealWindow> OnSelected;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject Container;

		public global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton MorningButton;

		public global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton AfternoonButton;

		public global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton NightButton;

		public global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton LateNightButton;

		public global::UnityEngine.RectTransform CurrentTimeArm;

		public global::UnityEngine.UI.Text CurrentTimeLabel;

		[global::UnityEngine.Header("Custom UI")]
		public global::ScheduleOne.UIScreen uiScreen;

		public global::ScheduleOne.UIPanel uiPanel;

		private global::System.Action<global::ScheduleOne.Economy.EDealWindow> callback;

		private global::ScheduleOne.UI.Phone.Messages.WindowSelectorButton[] buttons;

		private bool hintShown;

		public bool IsOpen { get; private set; }

		private void Start()
		{
		}

		public void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void SetIsOpen(bool open)
		{
		}

		public void SetIsOpen(bool open, global::ScheduleOne.Messaging.MSGConversation conversation, global::System.Action<global::ScheduleOne.Economy.EDealWindow> callback = null)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.Messages.DealWindowSelector._003CDelaySelectPanel_003Ed__24))]
		private global::System.Collections.IEnumerator DelaySelectPanel()
		{
			return null;
		}

		public void Update()
		{
		}

		private void UpdateTime()
		{
		}

		private void UpdateWindowValidity()
		{
		}

		private void Close()
		{
		}

		private void ButtonClicked(global::ScheduleOne.Economy.EDealWindow window)
		{
		}
	}
}
