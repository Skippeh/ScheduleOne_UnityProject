namespace ScheduleOne
{
	public class UIPopupScreen_ConfirmationMenu : global::ScheduleOne.UIPopupScreen
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			public global::System.Action onConfirm;

			public global::ScheduleOne.UIPopupScreen_ConfirmationMenu _003C_003E4__this;

			public global::System.Action onCancel;

			internal void _003CRegisterInput_003Eb__0()
			{
			}

			internal void _003CRegisterInput_003Eb__1()
			{
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRegisterInput_003Ed__8 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::System.Action onConfirm;

			public global::ScheduleOne.UIPopupScreen_ConfirmationMenu _003C_003E4__this;

			public global::System.Action onCancel;

			private global::ScheduleOne.UIPopupScreen_ConfirmationMenu._003C_003Ec__DisplayClass8_0 _003C_003E8__1;

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
			public _003CRegisterInput_003Ed__8(int _003C_003E1__state)
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

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text titleText;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TMP_Text messageText;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UISelectable confirmButton;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UISelectable cancelButton;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Canvas canvas;

		public override void Close()
		{
		}

		private void Open()
		{
		}

		public override void Open(params object[] args)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UIPopupScreen_ConfirmationMenu._003CRegisterInput_003Ed__8))]
		private global::System.Collections.IEnumerator RegisterInput(global::System.Action onConfirm, global::System.Action onCancel)
		{
			return null;
		}

		private void SelectPanel(global::ScheduleOne.UISelectable selectable)
		{
		}
	}
}
