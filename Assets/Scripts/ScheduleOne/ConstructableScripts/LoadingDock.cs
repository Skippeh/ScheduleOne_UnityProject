using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.ConstructableScripts
{
	public class LoadingDock : Constructable_GridBased
	{
		[Header("References")]
		[SerializeField]
		protected VehicleDetector vehicleDetector;

		[SerializeField]
		protected MeshRenderer[] redLightMeshes;

		[SerializeField]
		protected MeshRenderer[] greenLightMeshes;

		[SerializeField]
		protected Transform[] sideWalls;

		[SerializeField]
		protected Animation gateAnim;

		[SerializeField]
		protected Collider reservationBlocker;

		public Transform vehiclePosition;

		[Header("Materials")]
		[SerializeField]
		protected Material redLightMat_On;

		[SerializeField]
		protected Material redLightMat_Off;

		[SerializeField]
		protected Material greenLightMat_On;

		[SerializeField]
		protected Material greenLightMat_Off;

		private bool wallsOpen;

		private LandVehicle currentOccupant;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstructableScripts_002ELoadingDockAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstructableScripts_002ELoadingDockAssembly_002DCSharp_002Edll_Excuted;

		public bool isOccupied => false;

		public LandVehicle reservant { get; protected set; }

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

		public void SetReservant(LandVehicle _res)
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
