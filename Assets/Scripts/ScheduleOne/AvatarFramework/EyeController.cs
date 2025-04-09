using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	[ExecuteInEditMode]
	public class EyeController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CBlinkRoutine_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EyeController _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CBlinkRoutine_003Ed__48(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static float eyeHeightMultiplier;

		public bool DEBUG;

		[Header("References")]
		[SerializeField]
		public Eye leftEye;

		[SerializeField]
		public Eye rightEye;

		[Header("Location Settings")]
		[Range(0f, 45f)]
		[SerializeField]
		protected float eyeSpacing;

		[Range(-1f, 1f)]
		[SerializeField]
		protected float eyeHeight;

		[Range(0.5f, 1.5f)]
		[SerializeField]
		protected float eyeSize;

		[Header("Eyelid Settings")]
		[SerializeField]
		protected Color leftEyeLidColor;

		[SerializeField]
		protected Color rightEyeLidColor;

		public Eye.EyeLidConfiguration LeftRestingEyeState;

		public Eye.EyeLidConfiguration RightRestingEyeState;

		[Header("Eyeball Settings")]
		[SerializeField]
		protected Material eyeBallMaterial;

		[SerializeField]
		protected Color eyeBallColor;

		[Header("Pupil State")]
		[Range(0f, 1f)]
		public float PupilDilation;

		[Header("Blinking Settings")]
		public bool BlinkingEnabled;

		[SerializeField]
		[Range(0f, 10f)]
		protected float blinkInterval;

		[SerializeField]
		[Range(0f, 2f)]
		protected float blinkIntervalSpread;

		[SerializeField]
		[Range(0f, 1f)]
		protected float blinkDuration;

		private Avatar avatar;

		private Coroutine blinkRoutine;

		private float timeUntilNextBlink;

		private bool eyeBallTintOverridden;

		private bool eyeLidOverridden;

		private Eye.EyeLidConfiguration defaultLeftEyeRestingState;

		private Eye.EyeLidConfiguration defaultRightEyeRestingState;

		private float defaultDilation;

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

		[Button]
		public void ApplySettings()
		{
		}

		public void SetEyeballTint(Color col)
		{
		}

		public void OverrideEyeballTint(Color col)
		{
		}

		public void ResetEyeballTint()
		{
		}

		public void OverrideEyeLids(Eye.EyeLidConfiguration eyeLidConfiguration)
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

		public void ResetPupilDilation()
		{
		}

		private void ApplyRestingEyeLidState()
		{
		}

		public void ForceBlink()
		{
		}

		public void SetLeftEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
		}

		public void SetRightEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
		}

		[IteratorStateMachine(typeof(_003CBlinkRoutine_003Ed__48))]
		private IEnumerator BlinkRoutine()
		{
			return null;
		}

		private void ResetBlinkCounter()
		{
		}

		public void LookAt(Vector3 position, bool instant = false)
		{
		}
	}
}
