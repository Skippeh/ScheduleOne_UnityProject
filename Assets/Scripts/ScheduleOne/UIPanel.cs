namespace ScheduleOne
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.RectTransform))]
	public abstract class UIPanel : global::UnityEngine.MonoBehaviour
	{
		public enum UINavigationType
		{
			ImmediateDirection = 0,
			NearestDirectionAndDistance = 1
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CSmoothScrollContent_003Ed__77 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UIPanel _003C_003E4__this;

			public float duration;

			public global::UnityEngine.Vector3 targetLocalPosition;

			private global::UnityEngine.RectTransform _003Ccontent_003E5__2;

			private global::UnityEngine.Vector3 _003CstartPos_003E5__3;

			private float _003Ctime_003E5__4;

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
			public _003CSmoothScrollContent_003Ed__77(int _003C_003E1__state)
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

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Manually assign the UIPanel attached to this screen in editor. Alternatively, you can use AddSelectable and RemoveSelectable to add/remove UISelectable.")]
		protected global::System.Collections.Generic.List<global::ScheduleOne.UISelectable> selectables;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Default selectable to focus when the panel is selected.")]
		protected global::ScheduleOne.UISelectable defaultSelectable;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("ScrollRect for scrolling Layout Group.")]
		protected global::UnityEngine.UI.ScrollRect scrollRect;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Priority value to control which panel will be selected by default by the Screen.")]
		private int priority;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("When selected, the input action in the inputDescriptor list will be active")]
		private global::System.Collections.Generic.List<global::ScheduleOne.InputDescriptor> inputDescriptors;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Select this panel on Start")]
		private bool selectPanelOnStart;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Select this panel on OnEnable")]
		private bool selectPanelOnEnable;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Deselect this panel on OnDisable")]
		private bool deselectPanelOnDisable;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Set to true if this panel is supporting UIOptions to prevent left/right navigation of UISelectable and UIPanel")]
		protected bool preventSideNavigation;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Events.UnityEvent OnPanelSelected;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Events.UnityEvent OnPanelDeselected;

		private global::ScheduleOne.UISelectable currentSelectedSelectable;

		protected int currentIndex;

		protected float navTimer;

		protected bool wasNavPressedLastFrame;

		protected float scrollSpeed;

		private global::UnityEngine.Coroutine scrollCoroutine;

		private bool isDisabled;

		private bool isQuitting;

		private global::UnityEngine.Vector2 scrollMargin;

		protected bool lockInputThisFrame;

		public int Priority => 0;

		public global::UnityEngine.RectTransform RectTransform { get; private set; }

		public bool IsSelected { get; private set; }

		public bool IsLocked { get; set; }

		public global::ScheduleOne.UIScreen ParentScreen { get; private set; }

		public global::ScheduleOne.UISelectable CurrentSelectedSelectable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::System.Collections.Generic.IReadOnlyList<global::ScheduleOne.UISelectable> Selectables => null;

		public bool IsNavigablePanel => false;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		private void LateUpdate()
		{
		}

		protected virtual void EarlyUpdate()
		{
		}

		protected virtual void HandleInputDeviceChanged(global::ScheduleOne.GameInput.InputDeviceType type)
		{
		}

		protected virtual void DetectInput()
		{
		}

		protected void DetectScreenInputDescriptors()
		{
		}

		private void DetectSelectableInput()
		{
		}

		protected void SendClickEventToCurrentSelectedSelectable()
		{
		}

		public void SetParentScreen(global::ScheduleOne.UIScreen screen)
		{
		}

		internal bool IsPanelVisible()
		{
			return false;
		}

		internal bool IsAnySelectablesActive()
		{
			return false;
		}

		public global::ScheduleOne.UISelectable GetAValidCurrentSelectedSelectable(bool returnFirstFound = false)
		{
			return null;
		}

		public void SelectSelectable(global::ScheduleOne.UISelectable selectable, bool scrollToSelectable = false)
		{
		}

		public void SelectSelectable(int index, bool scrollToSelectable = false)
		{
		}

		public void SelectSelectable(bool returnFirstFound, bool scrollToSelectable = false)
		{
		}

		public bool AddSelectable(global::ScheduleOne.UISelectable selectable)
		{
			return false;
		}

		public void RemoveSelectable(global::ScheduleOne.UISelectable selectable, bool autoFallback = true)
		{
		}

		public void ClearAllSelectables()
		{
		}

		private global::ScheduleOne.UISelectable GetFallbackSelectable(bool returnFirstFound = false)
		{
			return null;
		}

		internal global::ScheduleOne.UISelectable Select(global::ScheduleOne.UISelectable overrideSelectable = null, bool scrollToChild = true)
		{
			return null;
		}

		internal void Deselect()
		{
		}

		internal void OnReset()
		{
		}

		private void ResetCurrentSelectedSelectable()
		{
		}

		public void ScrollToCurrentSelectedSelectable()
		{
		}

		protected void ScrollToChild(global::UnityEngine.RectTransform child, float duration = 0.25f)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UIPanel._003CSmoothScrollContent_003Ed__77))]
		private global::System.Collections.IEnumerator SmoothScrollContent(global::UnityEngine.Vector3 targetLocalPosition, float duration)
		{
			return null;
		}

		public void EnableSideNavigation(bool enabled)
		{
		}

		protected virtual bool Navigate(global::UnityEngine.Vector2 navDir)
		{
			return false;
		}

		private void ResetNavigationData()
		{
		}

		internal void LockNavigationTemporarily()
		{
		}

		protected virtual bool NavigateUsingCyclePanel(global::UnityEngine.Vector2 dir)
		{
			return false;
		}
	}
}
