namespace ScheduleOne.DevUtilities
{
	public class VehicleSelector : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.DevUtilities.VehicleSelector>
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected float detectionRange;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.LayerMask detectionMask;

		private global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> selectedVehicles;

		public global::System.Action onClose;

		private int selectionLimit;

		private bool exitOnSelectionLimit;

		private global::ScheduleOne.Vehicles.LandVehicle hoveredVehicle;

		private global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> outlinedVehicles;

		private global::System.Func<global::ScheduleOne.Vehicles.LandVehicle, bool> vehicleFilter;

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

		private global::ScheduleOne.Vehicles.LandVehicle GetHoveredVehicle()
		{
			return null;
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		public void StartSelecting(string selectionTitle, ref global::System.Collections.Generic.List<global::ScheduleOne.Vehicles.LandVehicle> initialSelection, int _selectionLimit, bool _exitOnSelectionLimit, global::System.Func<global::ScheduleOne.Vehicles.LandVehicle, bool> filter = null)
		{
		}

		public void StopSelecting()
		{
		}
	}
}
