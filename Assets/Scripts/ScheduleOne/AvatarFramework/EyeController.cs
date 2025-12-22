namespace ScheduleOne.AvatarFramework
{
	[global::UnityEngine.ExecuteInEditMode]
	public class EyeController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CBlinkRoutine_003Ed__47 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.AvatarFramework.EyeController _003C_003E4__this;

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
			public _003CBlinkRoutine_003Ed__47(int _003C_003E1__state)
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

		private static float eyeHeightMultiplier;

		public bool DEBUG;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		public global::ScheduleOne.AvatarFramework.Eye leftEye;

		[global::UnityEngine.SerializeField]
		public global::ScheduleOne.AvatarFramework.Eye rightEye;

		[global::UnityEngine.Header("Location Settings")]
		[global::UnityEngine.Range(0f, 45f)]
		[global::UnityEngine.SerializeField]
		protected float eyeSpacing;

		[global::UnityEngine.Range(-1f, 1f)]
		[global::UnityEngine.SerializeField]
		protected float eyeHeight;

		[global::UnityEngine.Range(0.5f, 1.5f)]
		[global::UnityEngine.SerializeField]
		protected float eyeSize;

		[global::UnityEngine.Header("Eyelid Settings")]
		public global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration LeftRestingEyeState;

		public global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration RightRestingEyeState;

		[global::UnityEngine.Header("Eyeball Settings")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material eyeBallMaterial;

		[global::UnityEngine.Header("Pupil State")]
		[global::UnityEngine.Range(0f, 1f)]
		public float PupilDilation;

		[global::UnityEngine.Header("Blinking Settings")]
		public bool BlinkingEnabled;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		protected float blinkInterval;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 2f)]
		protected float blinkIntervalSpread;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		protected float blinkDuration;

		private global::ScheduleOne.AvatarFramework.Avatar avatar;

		private global::UnityEngine.Coroutine blinkRoutine;

		private float timeUntilNextBlink;

		private bool eyeBallTintOverridden;

		private bool eyeLidOverridden;

		private global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration defaultLeftEyeRestingState;

		private global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration defaultRightEyeRestingState;

		private float defaultDilation;

		private global::UnityEngine.Color defaultEyeballColor;

		private global::UnityEngine.Color currentEyeballColor;

		public bool EyesOpen { get; protected set; }

		protected virtual void Awake()
		{
		}

		protected void Update()
		{
		}

		private void OnEnable()
		{
		}

		public void SetEyeballTint(global::UnityEngine.Color col, bool overrideDefault = false)
		{
		}

		public void ResetEyeballTint()
		{
		}

		public void OverrideEyeLids(global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration eyeLidConfiguration)
		{
		}

		public void ResetEyeLids()
		{
		}

		private void RagdollChange(bool oldValue, bool newValue, bool playStandUpAnim)
		{
		}

		public void SetEyesOpen(bool open)
		{
		}

		private void ApplyDilation()
		{
		}

		public void SetPupilDilation(float dilation, bool writeDefault = true)
		{
		}

		public void SetEyeballMaterial(global::UnityEngine.Material material)
		{
		}

		public void ResetEyeballMaterial()
		{
		}

		public void ResetPupilDilation()
		{
		}

		private void ApplyRestingEyeLidState()
		{
		}

		public void ForceBlink()
		{
		}

		public void SetLeftEyeRestingLidState(global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration config)
		{
		}

		public void SetRightEyeRestingLidState(global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration config)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.AvatarFramework.EyeController._003CBlinkRoutine_003Ed__47))]
		private global::System.Collections.IEnumerator BlinkRoutine()
		{
			return null;
		}

		private void ResetBlinkCounter()
		{
		}

		public void LookAt(global::UnityEngine.Vector3 position, bool instant = false)
		{
		}
	}
}
