namespace ScheduleOne.UI
{
	public class PauseMenu : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.PauseMenu>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDelayPanelSelect_003Ed__24 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.PauseMenu _003C_003E4__this;

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
			public _003CDelayPanelSelect_003Ed__24(int _003C_003E1__state)
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

		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::ScheduleOne.UI.MainMenu.MainMenuScreen Screen;

		public global::ScheduleOne.UI.FeedbackForm FeedbackForm;

		[global::UnityEngine.Header("Custom UI")]
		public global::ScheduleOne.UIScreen uiScreen;

		public global::ScheduleOne.UIPanel uiPanel;

		private bool justPaused;

		private bool justResumed;

		private bool couldLook;

		private bool lockedMouse;

		private bool crosshairVisible;

		private bool hudVisible;

		public global::System.Action onPause;

		public global::System.Action onResume;

		public bool IsPaused { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void Pause()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.PauseMenu._003CDelayPanelSelect_003Ed__24))]
		private global::System.Collections.IEnumerator DelayPanelSelect()
		{
			return null;
		}

		public void Resume()
		{
		}

		public void StuckButtonClicked()
		{
		}
	}
}
