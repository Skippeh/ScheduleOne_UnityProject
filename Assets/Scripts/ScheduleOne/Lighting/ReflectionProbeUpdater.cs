namespace ScheduleOne.Lighting
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.ReflectionProbe))]
	public class ReflectionProbeUpdater : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CProcessQueue_003Ed__6 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003CrenderDuration_Frames_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CProcessQueue_003Ed__6(int _003C_003E1__state)
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

		public global::UnityEngine.ReflectionProbe Probe;

		private static global::System.Collections.Generic.List<global::UnityEngine.ReflectionProbe> renderQueue;

		private static global::UnityEngine.Coroutine RenderRoutine;

		private void OnValidate()
		{
		}

		private void Start()
		{
		}

		private void UpdateProbe()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Lighting.ReflectionProbeUpdater._003CProcessQueue_003Ed__6))]
		private global::System.Collections.IEnumerator ProcessQueue()
		{
			return null;
		}
	}
}
