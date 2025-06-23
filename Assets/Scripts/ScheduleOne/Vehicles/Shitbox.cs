namespace ScheduleOne.Vehicles
{
	public class Shitbox : global::ScheduleOne.Vehicles.LandVehicle
	{
		[global::System.Serializable]
		public class LoanSharkVisualsData : global::ScheduleOne.Persistence.Datas.SaveData
		{
			public bool Enabled;

			public bool NoteVisible;
		}

		public global::ScheduleOne.Vehicles.LoanSharkCarVisuals LoanSharkVisuals;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EShitboxAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EShitboxAssembly_002DCSharp_002Edll_Excuted;

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
