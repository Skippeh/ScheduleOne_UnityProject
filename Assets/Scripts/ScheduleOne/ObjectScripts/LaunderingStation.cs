namespace ScheduleOne.ObjectScripts
{
	public class LaunderingStation : global::ScheduleOne.EntityFramework.GridItem
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.UI.LaunderingInterface Interface;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.ObjectScripts.CashCounter CashCounter;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ELaunderingStationAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ELaunderingStationAssembly_002DCSharp_002Edll_Excuted;

		public override void InitializeGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void Update()
		{
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
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
