namespace ScheduleOne.ObjectScripts
{
	public class Bed : global::FishNet.Object.NetworkBehaviour
	{
		public const int MIN_SLEEP_TIME = 1800;

		public const float SLEEP_TIME_SCALE = 1f;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject intObj;

		public global::ScheduleOne.Employees.EmployeeHome EmployeeStationThing;

		public global::UnityEngine.MeshRenderer BlanketMesh;

		[global::UnityEngine.Header("Materials")]
		public global::UnityEngine.Material DefaultBlanket;

		public global::UnityEngine.Material BotanistBlanket;

		public global::UnityEngine.Material ChemistBlanket;

		public global::UnityEngine.Material PackagerBlanket;

		public global::UnityEngine.Material CleanerBlanket;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EBedAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EBedAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Employees.Employee AssignedEmployee => null;

		public virtual void Awake()
		{
		}

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private bool CanSleep(out string noSleepReason)
		{
			noSleepReason = null;
			return false;
		}

		public void UpdateMaterial()
		{
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EBed_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
