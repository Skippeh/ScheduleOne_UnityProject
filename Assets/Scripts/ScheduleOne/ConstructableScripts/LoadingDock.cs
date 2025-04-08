namespace ScheduleOne.ConstructableScripts
{
	public class LoadingDock : global::ScheduleOne.ConstructableScripts.Constructable_GridBased
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.DevUtilities.VehicleDetector vehicleDetector;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer[] redLightMeshes;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer[] greenLightMeshes;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform[] sideWalls;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Animation gateAnim;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Collider reservationBlocker;

		public global::UnityEngine.Transform vehiclePosition;

		[global::UnityEngine.Header("Materials")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material redLightMat_On;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material redLightMat_Off;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material greenLightMat_On;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material greenLightMat_Off;

		private bool wallsOpen;

		private global::ScheduleOne.Vehicles.LandVehicle currentOccupant;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstructableScripts_002ELoadingDockAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstructableScripts_002ELoadingDockAssembly_002DCSharp_002Edll_Excuted;

		public bool isOccupied => false;

		public global::ScheduleOne.Vehicles.LandVehicle reservant { get; protected set; }

		private void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public override void DestroyConstructable(bool callOnServer = true)
		{
		}

		public void SetReservant(global::ScheduleOne.Vehicles.LandVehicle _res)
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
