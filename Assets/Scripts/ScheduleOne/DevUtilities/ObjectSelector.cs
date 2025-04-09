using System;
using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	public class ObjectSelector : Singleton<ObjectSelector>
	{
		[Header("Settings")]
		[SerializeField]
		protected float detectionRange;

		[SerializeField]
		protected LayerMask detectionMask;

		private List<Type> allowedTypes;

		private List<BuildableItem> selectedObjects;

		private List<Constructable> selectedConstructables;

		public Action onClose;

		private int selectionLimit;

		private bool exitOnSelectionLimit;

		private BuildableItem hoveredBuildable;

		private Constructable hoveredConstructable;

		private List<BuildableItem> outlinedObjects;

		private List<Constructable> outlinedConstructables;

		public bool isSelecting { get; protected set; }

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private BuildableItem GetHoveredBuildable()
		{
			return null;
		}

		private Constructable GetHoveredConstructable()
		{
			return null;
		}

		private void Exit(ExitAction action)
		{
		}

		public void StartSelecting(string selectionTitle, List<Type> _typeRestriction, ref List<BuildableItem> initialSelection_Objects, ref List<Constructable> initalSelection_Constructables, int _selectionLimit, bool _exitOnSelectionLimit)
		{
		}

		public void StopSelecting()
		{
		}
	}
}
