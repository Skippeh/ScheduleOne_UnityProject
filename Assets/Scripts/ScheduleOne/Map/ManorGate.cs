namespace ScheduleOne.Map
{
	public class ManorGate : global::ScheduleOne.Map.Gate
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject IntercomInt;

		public global::UnityEngine.Light IntercomLight;

		public global::ScheduleOne.DevUtilities.VehicleDetector ExteriorVehicleDetector;

		public global::ScheduleOne.Tools.PlayerDetector ExteriorPlayerDetector;

		public global::ScheduleOne.DevUtilities.VehicleDetector InteriorVehicleDetector;

		public global::ScheduleOne.Tools.PlayerDetector InteriorPlayerDetector;

		private bool intercomActive;

		private bool NetworkInitialize___EarlyScheduleOne_002EMap_002EManorGateAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EMap_002EManorGateAssembly_002DCSharp_002Edll_Excuted;

		protected virtual void Start()
		{
		}

		private void UpdateDetection()
		{
		}

		public void IntercomBuzzed()
		{
		}

		public void SetEnterable(bool enterable)
		{
		}

		[global::EasyButtons.Button]
		public void ActivateIntercom()
		{
		}

		public void SetIntercomActive(bool active)
		{
		}

		private void UpdateIntercom()
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
