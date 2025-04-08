namespace ScheduleOne.UI
{
	public class BlackOverlay : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.BlackOverlay>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CFade_003Ed__10 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.BlackOverlay _003C_003E4__this;

			public float endOpacity;

			public float fadeTime;

			private float _003Cstart_003E5__2;

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
			public _003CFade_003Ed__10(int _003C_003E1__state)
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

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas canvas;

		public global::UnityEngine.CanvasGroup group;

		private global::UnityEngine.Coroutine fadeRoutine;

		public bool isShown { get; protected set; }

		protected override void Awake()
		{
		}

		public void Open(float fadeTime = 0.5f)
		{
		}

		public void Close(float fadeTime = 0.5f)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.BlackOverlay._003CFade_003Ed__10))]
		private global::System.Collections.IEnumerator Fade(float endOpacity, float fadeTime)
		{
			return null;
		}
	}
}
