using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Management;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class ObjectSelector : MonoBehaviour
	{
		public delegate bool ObjectFilter(BuildableItem obj, out string reason);

		public const float SELECTION_RANGE = 5f;

		[Header("Settings")]
		public LayerMask DetectionMask;

		public Color HoverOutlineColor;

		public Color SelectOutlineColor;

		private int maxSelectedObjects;

		private List<BuildableItem> selectedObjects;

		private List<Type> typeRequirements;

		private ObjectFilter objectFilter;

		private Action<List<BuildableItem>> callback;

		private BuildableItem hoveredObj;

		private BuildableItem highlightedObj;

		private string selectionTitle;

		private bool changesMade;

		private List<Transform> transitSources;

		private List<TransitLineVisuals> transitLines;

		private ScheduleOne.Property.Property targetProperty;

		public bool IsOpen { get; protected set; }

		private void Start()
		{
		}

		public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<BuildableItem> _selectedObjects, List<Type> _typeRequirements, ScheduleOne.Property.Property property, ObjectFilter _objectFilter, Action<List<BuildableItem>> _callback, List<Transform> transitLineSources = null)
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

		private BuildableItem GetHoveredObject()
		{
			return null;
		}

		public bool IsObjectTypeValid(BuildableItem obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void ObjectClicked(BuildableItem obj)
		{
		}

		private void SetSelectionOutline(BuildableItem obj, bool on)
		{
		}

		private void ClipboardClosed()
		{
		}

		private void Exit(ExitAction exitAction)
		{
		}
	}
}
