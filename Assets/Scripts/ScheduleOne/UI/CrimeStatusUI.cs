namespace ScheduleOne.UI
{
	public class CrimeStatusUI : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRoutine_003Ed__14 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.CrimeStatusUI _003C_003E4__this;

			private float _003ClerpTime_003E5__2;

			private float _003Ct_003E5__3;

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
			public _003CRoutine_003Ed__14(int _003C_003E1__state)
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

		public const float SmallTextSize = 0.75f;

		public const float LargeTextSize = 1f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform CrimeStatusContainer;

		public global::UnityEngine.CanvasGroup CrimeStatusGroup;

		public global::UnityEngine.GameObject BodysearchLabel;

		public global::UnityEngine.UI.Image InvestigatingMask;

		public global::UnityEngine.UI.Image UnderArrestMask;

		public global::UnityEngine.UI.Image WantedMask;

		public global::UnityEngine.UI.Image WantedDeadMask;

		public global::UnityEngine.GameObject ArrestProgressContainer;

		private bool animateText;

		private global::UnityEngine.Coroutine routine;

		public void UpdateStatus()
		{
		}

		private void OnDestroy()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.CrimeStatusUI._003CRoutine_003Ed__14))]
		private global::System.Collections.IEnumerator Routine()
		{
			return null;
		}
	}
}
