namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.AudioSource))]
	public class AudioSourceController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CStart_003Ed__23 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Audio.AudioSourceController _003C_003E4__this;

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
			public _003CStart_003Ed__23(int _003C_003E1__state)
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

		public bool DEBUG;

		public global::UnityEngine.AudioSource AudioSource;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Audio.EAudioType AudioType;

		[global::UnityEngine.Range(0f, 1f)]
		public float DefaultVolume;

		public bool RandomizePitch;

		public float MinPitch;

		public float MaxPitch;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		private float VolumeMultiplier;

		[global::UnityEngine.Range(0f, 2f)]
		[global::UnityEngine.SerializeField]
		private float PitchMultiplier;

		private float basePitch;

		public float Volume { get; protected set; }

		public bool isPlaying => false;

		public float volumeMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pitchMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Audio.AudioSourceController._003CStart_003Ed__23))]
		private global::System.Collections.IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}

		private void Pause()
		{
		}

		private void Unpause()
		{
		}

		public void SetVolume(float volume)
		{
		}

		public void ApplyVolume()
		{
		}

		public void ApplyPitch()
		{
		}

		public virtual void Play()
		{
		}

		public virtual void PlayOneShot()
		{
		}

		public void DuplicateAndPlayOneShot()
		{
		}

		public virtual void DuplicateAndPlayOneShot(global::UnityEngine.Transform parent)
		{
		}

		public void Stop()
		{
		}
	}
}
