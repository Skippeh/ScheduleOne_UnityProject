namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.AudioSource))]
	public class AudioSourceController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDelayIE_003Ed__43 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public global::System.Action callback;

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
			public _003CDelayIE_003Ed__43(int _003C_003E1__state)
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

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private string _id;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("AudioType")]
		private global::ScheduleOne.Audio.EAudioType _audioType;

		[global::UnityEngine.Header("Volume")]
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("DefaultVolume")]
		[global::UnityEngine.Range(0f, 1f)]
		private float _defaultBaseVolume;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("VolumeMultiplier")]
		[global::UnityEngine.Range(0f, 2f)]
		private float _volumeMultiplier;

		[global::UnityEngine.Header("Pitch")]
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.1f, 3f)]
		private float _defaultBasePitch;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("PitchMultiplier")]
		[global::UnityEngine.Range(0f, 2f)]
		private float _pitchMultiplier;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("RandomizePitch")]
		private bool _randomizePitch;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("MinPitch")]
		[global::ScheduleOne.Core.Conditional("_randomizePitch", false)]
		private float _minRandomPitch;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("MaxPitch")]
		[global::ScheduleOne.Core.Conditional("_randomizePitch", false)]
		private float _maxRandomPitch;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("LowPassFilter")]
		[global::ScheduleOne.Core.Conditional("_lowPassFilter", false)]
		private global::UnityEngine.AudioLowPassFilter _lowPassFilter;

		protected global::UnityEngine.AudioSource _audioSource;

		protected float _baseVolume;

		protected float _basePitch;

		public bool IsPlaying => false;

		public float Time => 0f;

		public global::UnityEngine.AudioClip Clip => null;

		public string Id => null;

		public float VolumeMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float PitchMultiplier
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ApplyMixer()
		{
		}

		private void OnPause()
		{
		}

		private void OnUnpause()
		{
		}

		public void SetBaseVolume(float baseVolume)
		{
		}

		protected void ApplyVolume()
		{
		}

		public void SetBasePitch(float basePitch)
		{
		}

		private void ApplyPitch()
		{
		}

		public virtual void Play()
		{
		}

		public virtual void PlayOneShot()
		{
		}

		public void PlayOneShotDelayed(float delay)
		{
		}

		public void DuplicateAndPlayOneShot()
		{
		}

		public virtual void DuplicateAndPlayOneShot(global::UnityEngine.Transform parent)
		{
		}

		protected void Delay(float delay, global::System.Action callback)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Audio.AudioSourceController._003CDelayIE_003Ed__43))]
		protected global::System.Collections.IEnumerator DelayIE(float delay, global::System.Action callback)
		{
			return null;
		}

		public void ApplyAudioSettings(global::ScheduleOne.Audio.AudioSettingsWrapper settings)
		{
		}

		public global::ScheduleOne.Audio.AudioSettingsWrapper ExtractAudioSettings()
		{
			return null;
		}

		public void SetTime(float time)
		{
		}

		public void SetClip(global::UnityEngine.AudioClip clip)
		{
		}

		public void SetLoop(bool loop)
		{
		}

		public void Stop()
		{
		}
	}
}
