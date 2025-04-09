using System;
using System.Collections.Generic;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	public class VehicleSelector : Singleton<VehicleSelector>
	{
		[Header("Settings")]
		[SerializeField]
		protected float detectionRange;

		[SerializeField]
		protected LayerMask detectionMask;

		private List<LandVehicle> selectedVehicles;

		public Action onClose;

		private int selectionLimit;

		private bool exitOnSelectionLimit;

		private LandVehicle hoveredVehicle;

		private List<LandVehicle> outlinedVehicles;

		private Func<LandVehicle, bool> vehicleFilter;

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

		private LandVehicle GetHoveredVehicle()
		{
			return null;
		}

		private void Exit(ExitAction action)
		{
		}

		public void StartSelecting(string selectionTitle, ref List<LandVehicle> initialSelection, int _selectionLimit, bool _exitOnSelectionLimit, Func<LandVehicle, bool> filter = null)
		{
		}

		public void StopSelecting()
		{
		}
	}
}
