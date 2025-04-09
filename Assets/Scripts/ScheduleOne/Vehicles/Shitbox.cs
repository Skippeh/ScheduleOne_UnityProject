using System;
using System.Collections.Generic;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Vehicles
{
	public class Shitbox : LandVehicle
	{
		[Serializable]
		public class LoanSharkVisualsData : SaveData
		{
			public bool Enabled;

			public bool NoteVisible;
		}

		public LoanSharkCarVisuals LoanSharkVisuals;

		private bool NetworkInitialize___EarlyScheduleOne_002EVehicles_002EShitboxAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EVehicles_002EShitboxAssembly_002DCSharp_002Edll_Excuted;

		public override List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public override void Load(VehicleData data, string containerPath)
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
