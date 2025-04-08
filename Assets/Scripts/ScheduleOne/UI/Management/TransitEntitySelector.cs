namespace ScheduleOne.UI.Management
{
	public class TransitEntitySelector : global::UnityEngine.MonoBehaviour
	{
		public delegate bool ObjectFilter(global::ScheduleOne.Management.ITransitEntity obj, out string reason);

		public const float SELECTION_RANGE = 5f;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask DetectionMask;

		public global::UnityEngine.Color HoverOutlineColor;

		public global::UnityEngine.Color SelectOutlineColor;

		private int maxSelectedObjects;

		private global::System.Collections.Generic.List<global::ScheduleOne.Management.ITransitEntity> selectedObjects;

		private global::System.Collections.Generic.List<global::System.Type> typeRequirements;

		private global::ScheduleOne.UI.Management.TransitEntitySelector.ObjectFilter objectFilter;

		private global::System.Action<global::System.Collections.Generic.List<global::ScheduleOne.Management.ITransitEntity>> callback;

		private global::ScheduleOne.Management.ITransitEntity hoveredObj;

		private global::ScheduleOne.Management.ITransitEntity highlightedObj;

		private string selectionTitle;

		private bool changesMade;

		private global::System.Collections.Generic.List<global::UnityEngine.Transform> transitSources;

		private global::System.Collections.Generic.List<global::ScheduleOne.Management.TransitLineVisuals> transitLines;

		private bool selectDestination;

		public bool IsOpen { get; protected set; }

		private void Start()
		{
		}

		public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, global::System.Collections.Generic.List<global::ScheduleOne.Management.ITransitEntity> _selectedObjects, global::System.Collections.Generic.List<global::System.Type> _typeRequirements, global::ScheduleOne.UI.Management.TransitEntitySelector.ObjectFilter _objectFilter, global::System.Action<global::System.Collections.Generic.List<global::ScheduleOne.Management.ITransitEntity>> _callback, global::System.Collections.Generic.List<global::UnityEngine.Transform> transitLineSources = null, bool selectingDestination = true)
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

		private global::ScheduleOne.Management.ITransitEntity GetHoveredObject()
		{
			return null;
		}

		public bool IsObjectTypeValid(global::ScheduleOne.Management.ITransitEntity obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void ObjectClicked(global::ScheduleOne.Management.ITransitEntity obj)
		{
		}

		private void SetSelectionOutline(global::ScheduleOne.Management.ITransitEntity obj, bool on)
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
