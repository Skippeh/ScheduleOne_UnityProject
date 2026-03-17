namespace ScheduleOne
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.RectTransform))]
	public class UISelectable : global::ScheduleOne.UITrigger, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerExitHandler, global::UnityEngine.EventSystems.ISelectHandler, global::UnityEngine.EventSystems.IDeselectHandler
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("When selected, the input action in the inputDescriptor list will be active")]
		private global::System.Collections.Generic.List<global::ScheduleOne.InputDescriptor> inputDescriptors;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Support default A to fire the button click event even if there are inputDescriptors")]
		private bool allowTriggerSubmitWithInputDescriptors;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("A gameobject that will show when selected. Only shown when in Controller mode")]
		private global::UnityEngine.GameObject selectedImage;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Search and Add selectable to a parent Panel on Awake")]
		private bool addToPanelOnAwake;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("On Disable, tell the parent Panel to search for another valid selectable to select")]
		private bool findAnotherSelectableInPanelOnDisable;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Set to true if you want this to be not selectable when UGUI interactable is set to false")]
		private bool blockSelectionOnInteractableFalse;

		public global::UnityEngine.Events.UnityEvent OnSelected;

		public global::UnityEngine.Events.UnityEvent OnDeselected;

		public global::UnityEngine.RectTransform RectTransform { get; private set; }

		public global::ScheduleOne.UIPanel ParentPanel { get; private set; }

		public bool AllowTriggerSubmitWithInputDescriptors => false;

		public bool CanBeSelected => false;

		internal global::System.Collections.Generic.IReadOnlyList<global::ScheduleOne.InputDescriptor> GetInputDescriptors()
		{
			return null;
		}

		protected override void Awake()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnEnable()
		{
		}

		public virtual void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
		{
		}

		public override void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
		{
		}

		protected virtual bool DeselectOnPointerExit()
		{
			return false;
		}

		public override void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
		{
		}

		public void OnSelect(global::UnityEngine.EventSystems.BaseEventData eventData)
		{
		}

		public void OnDeselect(global::UnityEngine.EventSystems.BaseEventData eventData)
		{
		}

		internal override void OnReset()
		{
		}

		internal void SetParentPanel(global::ScheduleOne.UIPanel panel)
		{
		}

		internal bool IsSelected()
		{
			return false;
		}

		private void SetSelectedImageVisible(bool visible)
		{
		}
	}
}
