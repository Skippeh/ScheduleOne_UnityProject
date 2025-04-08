namespace ScheduleOne.ObjectScripts
{
	public class CashCounter : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CLerpNote_003Ed__10 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.ObjectScripts.CashCounter _003C_003E4__this;

			public global::UnityEngine.Transform note;

			private float _003Ci_003E5__2;

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
			public _003CLerpNote_003Ed__10(int _003C_003E1__state)
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

		public const float NoteLerpTime = 0.18f;

		public bool IsOn;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject UpperNotes;

		public global::UnityEngine.GameObject LowerNotes;

		public global::UnityEngine.Transform NoteStartPoint;

		public global::UnityEngine.Transform NoteEndPoint;

		public global::System.Collections.Generic.List<global::UnityEngine.Transform> MovingNotes;

		public global::ScheduleOne.Audio.AudioSourceController Audio;

		private bool lerping;

		public virtual void LateUpdate()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.ObjectScripts.CashCounter._003CLerpNote_003Ed__10))]
		private global::System.Collections.IEnumerator LerpNote(global::UnityEngine.Transform note)
		{
			return null;
		}
	}
}
