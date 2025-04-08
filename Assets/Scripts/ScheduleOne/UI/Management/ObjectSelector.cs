namespace ScheduleOne.UI.Management
{
	public class ObjectSelector : global::UnityEngine.MonoBehaviour
	{
		public delegate bool ObjectFilter(global::ScheduleOne.EntityFramework.BuildableItem obj, out string reason);

		public const float SELECTION_RANGE = 5f;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask DetectionMask;

		public global::UnityEngine.Color HoverOutlineColor;

		public global::UnityEngine.Color SelectOutlineColor;

		private int maxSelectedObjects;

		private global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> selectedObjects;

		private global::System.Collections.Generic.List<global::System.Type> typeRequirements;

		private global::ScheduleOne.UI.Management.ObjectSelector.ObjectFilter objectFilter;

		private global::System.Action<global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem>> callback;

		private global::ScheduleOne.EntityFramework.BuildableItem hoveredObj;

		private global::ScheduleOne.EntityFramework.BuildableItem highlightedObj;

		private string selectionTitle;

		private bool changesMade;

		private global::System.Collections.Generic.List<global::UnityEngine.Transform> transitSources;

		private global::System.Collections.Generic.List<global::ScheduleOne.Management.TransitLineVisuals> transitLines;

		private global::ScheduleOne.Property.Property targetProperty;

		public bool IsOpen { get; protected set; }

		private void Start()
		{
		}

		public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem> _selectedObjects, global::System.Collections.Generic.List<global::System.Type> _typeRequirements, global::ScheduleOne.Property.Property property, global::ScheduleOne.UI.Management.ObjectSelector.ObjectFilter _objectFilter, global::System.Action<global::System.Collections.Generic.List<global::ScheduleOne.EntityFramework.BuildableItem>> _callback, global::System.Collections.Generic.List<global::UnityEngine.Transform> transitLineSources = null)
		{
		}

		private void UpdateTransitLines()
		{
		}

		public virtual void Close(bool returnToClipboard, bool pushChanges)
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateInstructions()
		{
		}

		private global::ScheduleOne.EntityFramework.BuildableItem GetHoveredObject()
		{
			return null;
		}

		public bool IsObjectTypeValid(global::ScheduleOne.EntityFramework.BuildableItem obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void ObjectClicked(global::ScheduleOne.EntityFramework.BuildableItem obj)
		{
		}

		private void SetSelectionOutline(global::ScheduleOne.EntityFramework.BuildableItem obj, bool on)
		{
		}

		private void ClipboardClosed()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction exitAction)
		{
		}
	}
}
