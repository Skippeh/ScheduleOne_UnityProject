namespace ScheduleOne.Calling
{
	public class PayPhone : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CPeriodicRing_003Ed__18 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Calling.PayPhone _003C_003E4__this;

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
			public _003CPeriodicRing_003Ed__18(int _003C_003E1__state)
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

		public const float RING_INTERVAL = 4f;

		public const float RING_RANGE = 9f;

		public global::ScheduleOne.ScriptableObjects.PhoneCallData QueuedCall;

		public global::ScheduleOne.ScriptableObjects.PhoneCallData ActiveCall;

		public global::ScheduleOne.Lighting.BlinkingLight Light;

		public global::ScheduleOne.Audio.AudioSourceController RingSound;

		public global::ScheduleOne.Audio.AudioSourceController AnswerSound;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform CameraPosition;

		private float lastRingTime;

		private const float ringRangeSquared = 81f;

		private global::UnityEngine.Coroutine periodicRingHandle;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnCallStarted(global::ScheduleOne.ScriptableObjects.PhoneCallData data)
		{
		}

		private void OnCallCompleted(global::ScheduleOne.ScriptableObjects.PhoneCallData data)
		{
		}

		private void OnCallQueued(global::ScheduleOne.ScriptableObjects.PhoneCallData data)
		{
		}

		private void UpdateCallState()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Calling.PayPhone._003CPeriodicRing_003Ed__18))]
		private global::System.Collections.IEnumerator PeriodicRing()
		{
			return null;
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private bool CanInteract()
		{
			return false;
		}
	}
}
