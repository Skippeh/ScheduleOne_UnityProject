namespace ScheduleOne.UI
{
	public class TabController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDoDelayRoutine_003Ed__20 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public global::System.Action onComplete;

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
			public _003CDoDelayRoutine_003Ed__20(int _003C_003E1__state)
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
		private sealed class _003CDoMoveTabIndicatorRoutine_003Ed__15 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.TabController _003C_003E4__this;

			private float _003Celapsed_003E5__2;

			private global::UnityEngine.Vector2 _003CstartingPosition_003E5__3;

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
			public _003CDoMoveTabIndicatorRoutine_003Ed__15(int _003C_003E1__state)
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
		private global::UnityEngine.RectTransform _tabIndicator;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.UI.TabItemUI> _tabItems;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private float _indicatorMoveTime;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.AnimationCurve _indicatorMoveCurve;

		[global::UnityEngine.Header("Fonts")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _tabColorFont;

		private int _currentTabIndex;

		private global::UnityEngine.Vector2 _indicatorPosition;

		private global::UnityEngine.Coroutine _moveIndicatorCo;

		private global::ScheduleOne.UI.TabSelectedEvent _onTabSelected;

		public int CurrentTabIndex => 0;

		public void Start()
		{
		}

		private void SetTab(int index)
		{
		}

		public void SetToSelectedTab(bool instantIndicatorMove = false)
		{
		}

		public void SetTab(int index, bool instantIndicatorMove = false)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.TabController._003CDoMoveTabIndicatorRoutine_003Ed__15))]
		private global::System.Collections.IEnumerator DoMoveTabIndicatorRoutine()
		{
			return null;
		}

		public void SetTabIndicatorText(int index, string text)
		{
		}

		public void HideTabIndicator(int index)
		{
		}

		public void SubscribeToTabSelected(global::ScheduleOne.UI.TabSelectedEvent handler)
		{
		}

		public void UnsubscribeFromTabSelected(global::ScheduleOne.UI.TabSelectedEvent handler)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.TabController._003CDoDelayRoutine_003Ed__20))]
		private global::System.Collections.IEnumerator DoDelayRoutine(float delay, global::System.Action onComplete)
		{
			return null;
		}
	}
}
