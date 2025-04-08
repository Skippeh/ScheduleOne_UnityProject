namespace ScheduleOne.Lighting
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Misc.ToggleableLight))]
	public class BlinkingLight : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CBlink_003Ed__7 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Lighting.BlinkingLight _003C_003E4__this;

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
			public _003CBlink_003Ed__7(int _003C_003E1__state)
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

		public bool IsOn;

		public float OnTime;

		public float OffTime;

		private global::ScheduleOne.Misc.ToggleableLight light;

		private global::UnityEngine.Coroutine blinkRoutine;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Lighting.BlinkingLight._003CBlink_003Ed__7))]
		private global::System.Collections.IEnumerator Blink()
		{
			return null;
		}
	}
}
