namespace ScheduleOne
{
	public class UIScreen : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Manually assign the UIPanel attached to this screen in editor.")]
		private global::System.Collections.Generic.List<global::ScheduleOne.UIPanel> panels;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("When selected, the input action in the inputDescriptor list will be active")]
		private global::System.Collections.Generic.List<global::ScheduleOne.InputDescriptor> inputDescriptors;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Each screen support 1 active scroll rect to scroll. You can use uiScreen.ChangeActiveScrollRect(newScrollRect) to change the active scroll rect via script at runtime.")]
		private global::UnityEngine.UI.ScrollRect activeScrollRect;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Add this screen to UIScreenManger on Start")]
		private bool addScreenOnStart;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Add this screen to UIScreenManger on OnEnable")]
		private bool addScreenOnEnable;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Remove this screen from UIScreenManger on OnDisable")]
		private bool removeScreenOnDisable;

		private global::ScheduleOne.UIPanel currentSelectedPanel;

		private bool isSelected;

		private bool wasNavPressedLastFrame;

		public bool IsSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::ScheduleOne.UIPanel CurrentSelectedPanel => null;

		public global::System.Collections.Generic.IReadOnlyList<global::ScheduleOne.UIPanel> Panels => null;

		private void Awake()
		{
		}

		protected virtual void OnAwake()
		{
		}

		private void Start()
		{
		}

		protected virtual void OnStarted()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void OnDestroyed()
		{
		}

		protected virtual void Update()
		{
		}

		private void InitScreen()
		{
		}

		public void AddPanel(global::ScheduleOne.UIPanel panel)
		{
		}

		public void RemovePanel(global::ScheduleOne.UIPanel panel)
		{
		}

		public void ClearPanels()
		{
		}

		public void SetCurrentSelectedPanel(global::ScheduleOne.UISelectable overrideSelectable = null, bool scrollToChild = true)
		{
		}

		public void SetCurrentSelectedPanel(global::ScheduleOne.UIPanel panel, global::ScheduleOne.UISelectable overrideSelectable = null, bool scrollToChild = true)
		{
		}

		private void UpdateScrollbar()
		{
		}

		private void DetectInput()
		{
		}

		private void DetectScreenInputDescriptors()
		{
		}

		internal bool ForceNavigate(global::UnityEngine.Vector2 navDir, global::UnityEngine.Vector2 fromPos)
		{
			return false;
		}

		private bool Navigate(global::UnityEngine.Vector2 navDir, global::UnityEngine.Vector2 fromPos)
		{
			return false;
		}

		public void ChangeActiveScrollRect(global::UnityEngine.UI.ScrollRect newScrollRect)
		{
		}
	}
}
