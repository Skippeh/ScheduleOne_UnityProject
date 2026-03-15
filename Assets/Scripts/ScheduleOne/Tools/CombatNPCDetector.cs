namespace ScheduleOne.Tools
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	public class CombatNPCDetector : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CUpdateWhileDetected_003Ed__7 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Tools.CombatNPCDetector _003C_003E4__this;

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
			public _003CUpdateWhileDetected_003Ed__7(int _003C_003E1__state)
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

		public bool DetectOnlyInCombat;

		public global::UnityEngine.Events.UnityEvent onDetected;

		public float ContactTimeForDetection;

		private global::ScheduleOne.NPCs.NPC npcInContact;

		private float contactTime;

		private global::UnityEngine.Coroutine detectionRoutine;

		private void Awake()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Tools.CombatNPCDetector._003CUpdateWhileDetected_003Ed__7))]
		private global::System.Collections.IEnumerator UpdateWhileDetected()
		{
			return null;
		}

		private void OnTriggerEnter(global::UnityEngine.Collider other)
		{
		}

		private void OnTriggerExit(global::UnityEngine.Collider other)
		{
		}
	}
}
