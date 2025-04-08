namespace ScheduleOne.ObjectScripts
{
	public class PotSoilCover : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CCheckQueue_003Ed__25 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.ObjectScripts.PotSoilCover _003C_003E4__this;

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
			public _003CCheckQueue_003Ed__25(int _003C_003E1__state)
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

		public const int TEXTURE_SIZE = 128;

		public const int POUR_RADIUS = 32;

		public const int UPDATES_PER_SECOND = 24;

		public const float COVERAGE_THRESHOLD = 0.5f;

		public const float BASE_COVERAGE = 0.215f;

		public const float SUCCESS_COVERAGE_THRESHOLD = 0.95f;

		public const float DELAY = 0.35f;

		public float CurrentCoverage;

		[global::UnityEngine.Header("Settings")]
		public float Radius;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.MeshRenderer MeshRenderer;

		public global::UnityEngine.Texture2D PourMask;

		public global::UnityEngine.Events.UnityEvent onSufficientCoverage;

		private bool queued;

		private global::UnityEngine.Vector3 queuedWorldPos;

		private global::UnityEngine.Texture2D mainTex;

		private global::UnityEngine.Vector3 relative;

		private global::UnityEngine.Vector2 vector2;

		private global::UnityEngine.Vector2 normalizedOffset;

		private global::UnityEngine.Vector2 originPixel;

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

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.ObjectScripts.PotSoilCover._003CCheckQueue_003Ed__25))]
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

		private void ApplyPour(global::UnityEngine.Vector3 worldSpace)
		{
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
