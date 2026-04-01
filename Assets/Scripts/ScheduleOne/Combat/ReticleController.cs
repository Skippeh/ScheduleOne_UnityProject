namespace ScheduleOne.Combat
{
	public class ReticleController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDoRecticleFade_003Ed__10 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Combat.ReticleController _003C_003E4__this;

			public float duration;

			public float endAlpha;

			private float _003CstartAlpha_003E5__2;

			private float _003Celapsed_003E5__3;

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
			public _003CDoRecticleFade_003Ed__10(int _003C_003E1__state)
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

		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.ReticleUI _reticleUI;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private float _fadeDuration;

		private bool _isActive;

		private global::UnityEngine.Coroutine _fadeCo;

		public bool IsActive => false;

		private void Awake()
		{
		}

		public void ShowReticle(float duration = -1f)
		{
		}

		public void HideReticle(float duration = -1f)
		{
		}

		public void SetReticle(float spreadAngle)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Combat.ReticleController._003CDoRecticleFade_003Ed__10))]
		private global::System.Collections.IEnumerator DoRecticleFade(float endAlpha, float duration)
		{
			return null;
		}
	}
}
