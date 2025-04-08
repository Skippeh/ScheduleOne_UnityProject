namespace ScheduleOne.UI.Phone
{
	public class AppsCanvas : global::ScheduleOne.DevUtilities.PlayerSingleton<global::ScheduleOne.UI.Phone.AppsCanvas>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDelayedSetCanvasActive_003Ed__10 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public global::ScheduleOne.UI.Phone.AppsCanvas _003C_003E4__this;

			public bool active;

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
			public _003CDelayedSetCanvasActive_003Ed__10(int _003C_003E1__state)
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

		private global::UnityEngine.Coroutine delayedSetOpenRoutine;

		public bool isOpen { get; private set; }

		protected override void Awake()
		{
		}

		public override void OnStartClient(bool IsOwner)
		{
		}

		protected void PhoneOpened()
		{
		}

		protected void PhoneClosed()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.AppsCanvas._003CDelayedSetCanvasActive_003Ed__10))]
		private global::System.Collections.IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			return null;
		}

		public void SetIsOpen(bool o)
		{
		}

		private void SetCanvasActive(bool a)
		{
		}

		protected override void Start()
		{
		}
	}
}
