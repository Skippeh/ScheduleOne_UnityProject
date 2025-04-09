using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Management;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class TransitEntitySelector : MonoBehaviour
	{
		public delegate bool ObjectFilter(ITransitEntity obj, out string reason);

		public const float SELECTION_RANGE = 5f;

		[Header("Settings")]
		public LayerMask DetectionMask;

		public Color HoverOutlineColor;

		public Color SelectOutlineColor;

		private int maxSelectedObjects;

		private List<ITransitEntity> selectedObjects;

		private List<Type> typeRequirements;

		private ObjectFilter objectFilter;

		private Action<List<ITransitEntity>> callback;

		private ITransitEntity hoveredObj;

		private ITransitEntity highlightedObj;

		private string selectionTitle;

		private bool changesMade;

		private List<Transform> transitSources;

		private List<TransitLineVisuals> transitLines;

		private bool selectDestination;

		public bool IsOpen { get; protected set; }

		private void Start()
		{
		}

		public virtual void Open(string _selectionTitle, string instruction, int _maxSelectedObjects, List<ITransitEntity> _selectedObjects, List<Type> _typeRequirements, ObjectFilter _objectFilter, Action<List<ITransitEntity>> _callback, List<Transform> transitLineSources = null, bool selectingDestination = true)
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

		private ITransitEntity GetHoveredObject()
		{
			return null;
		}

		public bool IsObjectTypeValid(ITransitEntity obj, out string reason)
		{
			reason = null;
			return false;
		}

		public void ObjectClicked(ITransitEntity obj)
		{
		}

		private void SetSelectionOutline(ITransitEntity obj, bool on)
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
