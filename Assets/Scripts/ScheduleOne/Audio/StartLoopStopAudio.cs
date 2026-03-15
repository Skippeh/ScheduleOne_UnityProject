namespace ScheduleOne.Audio
{
	public class StartLoopStopAudio : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CStartAudioRoutine_003Ed__10 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Audio.StartLoopStopAudio _003C_003E4__this;

			private float _003Ctimer_003E5__2;

			private float _003Cduration_003E5__3;

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
			public _003CStartAudioRoutine_003Ed__10(int _003C_003E1__state)
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

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CStopAudioRoutine_003Ed__11 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Audio.StartLoopStopAudio _003C_003E4__this;

			private float _003Ctimer_003E5__2;

			private float _003Cduration_003E5__3;

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
			public _003CStopAudioRoutine_003Ed__11(int _003C_003E1__state)
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

		[global::UnityEngine.Serialization.FormerlySerializedAs("FadeLoopIn")]
		[global::UnityEngine.SerializeField]
		private bool _fadeLoopIn;

		[global::UnityEngine.Serialization.FormerlySerializedAs("FadeLoopOut")]
		[global::UnityEngine.SerializeField]
		private bool _fadeLoopOut;

		[global::UnityEngine.Serialization.FormerlySerializedAs("StartSound")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _startSound;

		[global::UnityEngine.Serialization.FormerlySerializedAs("LoopSound")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _loopSound;

		[global::UnityEngine.Serialization.FormerlySerializedAs("StopSound")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _stopSound;

		private global::UnityEngine.Coroutine _audioRoutine;

		private bool _isRunning;

		private void Awake()
		{
		}

		public void StartAudio()
		{
		}

		public void StopAudio()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Audio.StartLoopStopAudio._003CStartAudioRoutine_003Ed__10))]
		private global::System.Collections.IEnumerator StartAudioRoutine()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Audio.StartLoopStopAudio._003CStopAudioRoutine_003Ed__11))]
		private global::System.Collections.IEnumerator StopAudioRoutine()
		{
			return null;
		}

		private void TryStartAudio()
		{
		}

		private void TryStopAudio()
		{
		}
	}
}
