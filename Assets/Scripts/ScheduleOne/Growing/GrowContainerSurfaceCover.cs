namespace ScheduleOne.Growing
{
	public class GrowContainerSurfaceCover : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CApplyPourOverTime_003Ed__44 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Growing.GrowContainerSurfaceCover _003C_003E4__this;

			private global::UnityEngine.Color[] _003Cpixels_003E5__2;

			private float _003CelapasedTime_003E5__3;

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
			public _003CApplyPourOverTime_003Ed__44(int _003C_003E1__state)
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
		private sealed class _003CCheckQueue_003Ed__40 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Growing.GrowContainerSurfaceCover _003C_003E4__this;

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
			public _003CCheckQueue_003Ed__40(int _003C_003E1__state)
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

		public const int TextureSize = 128;

		public const int PourRadius = 32;

		public const int UpdatesPerSecond = 24;

		public const float CoveredPixelThreshold = 0.8f;

		public const float Delay = 0.35f;

		[global::UnityEngine.Header("Settings")]
		public float SuccessfulCoverageThreshold;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Growing.GrowContainer GrowContainer;

		public global::UnityEngine.MeshRenderer MeshRenderer;

		public global::UnityEngine.Texture2D PourMask;

		[global::UnityEngine.Header("Pour Over time Settings")]
		[global::UnityEngine.SerializeField]
		private float _applyPoutOverTimeDuration;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.AnimationCurve _applyPoutOverTimeCurve;

		public global::UnityEngine.Events.UnityEvent onSufficientCoverage;

		private bool queued;

		private global::UnityEngine.Vector3 queuedWorldPos;

		private global::UnityEngine.Texture2D mainTex;

		private global::UnityEngine.Texture2D tempTex;

		private global::UnityEngine.Vector3 relative;

		private global::UnityEngine.Vector2 vector2;

		private global::UnityEngine.Vector2 normalizedOffset;

		private global::UnityEngine.Vector2 originPixel;

		private float _pourApplicationStrength;

		public float CurrentCoverage { get; private set; }

		public float PourApplicationStrength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool UseApplyOverTime { get; set; }

		private float _sideLength => 0f;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void ConfigureAppearance(global::UnityEngine.Color col, float transparency)
		{
		}

		public void Reset()
		{
		}

		public void QueuePour(global::UnityEngine.Vector3 worldSpacePosition)
		{
		}

		public float GetNormalizedProgress()
		{
			return 0f;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Growing.GrowContainerSurfaceCover._003CCheckQueue_003Ed__40))]
		private global::System.Collections.IEnumerator CheckQueue()
		{
			return null;
		}

		private void Blank()
		{
		}

		private void DelayedApplyPour(global::UnityEngine.Vector3 worldSpace)
		{
		}

		private void ApplyPour(global::UnityEngine.Vector3 worldSpace, bool applyOverTime = false)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Growing.GrowContainerSurfaceCover._003CApplyPourOverTime_003Ed__44))]
		private global::System.Collections.IEnumerator ApplyPourOverTime()
		{
			return null;
		}

		private float GetPourMaskValue(int x, int y)
		{
			return 0f;
		}

		private float GetCoverage()
		{
			return 0f;
		}
	}
}
